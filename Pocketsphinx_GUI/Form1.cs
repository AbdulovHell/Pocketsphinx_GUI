using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocketsphinx_GUI
{
    public partial class Form1 : Form
    {
        Process ps_proc;
        string path = @"C:\Users\drono\Desktop\voice recognition\pocketsphinx\bin\Release\x64\pocketsphinx_continuous.exe";
        string args_rec = @"-infile models\ru\my2.wav -hmm models\ru\cont -lm models\ru\ru.lm -dict models\ru\ru.dic";
        string args_live = @"-inmic yes -hmm models\ru\cont -lm models\ru\ru.lm -dict models\ru\ru.dic";
        string module_root = string.Empty;
        string rec_file = string.Empty;
        IAsyncResult connectionResult;
        IAsyncResult readResult;
        byte[] buffer = new byte[2048];

        System.IO.Pipes.NamedPipeServerStream pocketsphinxPipe;

        public Form1()
        {
            InitializeComponent();

            ModulePathBox.Text = module_root = Properties.Settings.Default.LastModulePath;
            RecordPathBox.Text = rec_file = Properties.Settings.Default.LastRecordPath;
            ProgPath.Text = path = Properties.Settings.Default.LastProgPath;

            pocketsphinxPipe = new System.IO.Pipes.NamedPipeServerStream("pocketsphinx_c", System.IO.Pipes.PipeDirection.InOut, 1, System.IO.Pipes.PipeTransmissionMode.Byte, System.IO.Pipes.PipeOptions.Asynchronous);
            connectionResult = pocketsphinxPipe.BeginWaitForConnection(PipeConnectedCallback, null);
        }

        void PipeConnectedCallback(object obj)
        {
            pocketsphinxPipe.EndWaitForConnection(connectionResult);
            readResult = pocketsphinxPipe.BeginRead(buffer, 0, buffer.Length, PipeReadCallback, null);
            //connectionResult = pocketsphinxPipe.BeginWaitForConnection(PipeConnectedCallback, null);
        }

        void PipeReadCallback(object obj)
        {
            int readed = 0;

            try
            {
                readed = pocketsphinxPipe.EndRead(readResult);
            }
            catch (Exception) {
                pocketsphinxPipe.Close();
                pocketsphinxPipe = new System.IO.Pipes.NamedPipeServerStream("pocketsphinx_c", System.IO.Pipes.PipeDirection.InOut, 1, System.IO.Pipes.PipeTransmissionMode.Byte, System.IO.Pipes.PipeOptions.Asynchronous);
                connectionResult = pocketsphinxPipe.BeginWaitForConnection(PipeConnectedCallback, null);
                return;
            }            

            if (readed > 0)
            {
                WriteLog(Encoding.UTF8.GetString(buffer.Take(readed).Where(b => b != 0).ToArray()));
            }
            readResult = pocketsphinxPipe.BeginRead(buffer, 0, buffer.Length, PipeReadCallback, null);
        }

        void WriteLog(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(WriteLog), text);
            }
            else
            {
                ProgLog.AppendText(text + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (module_root != string.Empty && rec_file != string.Empty)
            {
                args_rec = $"-infile \"{rec_file}\" -hmm \"{module_root.GetAC()}\" -lm \"{module_root.GetLM()}\" -dict \"{module_root.GetDic()}\"";

                ps_proc = Process.Start(path, args_rec);
                ps_proc.Exited += Ps_proc_Exited;
                ShowWindow(ps_proc.MainWindowHandle, 0);                
            }
        }

        private void Ps_proc_Exited(object sender, EventArgs e)
        {
            WriteLog("");
            WriteLog($"Pocketsphinx завершило работу с кодом {ps_proc.ExitCode}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            module_root = folderBrowserDialog1.SelectedPath;
            ModulePathBox.Text = module_root;
            Properties.Settings.Default.LastModulePath = module_root;
            Properties.Settings.Default.Save();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            rec_file = openFileDialog1.FileName;
            RecordPathBox.Text = rec_file;
            Properties.Settings.Default.LastRecordPath = rec_file;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr handle, int cmdShow);

        private void StartLiveBtn_Click(object sender, EventArgs e)
        {
            if (module_root != string.Empty)
            {
                args_live = $"-inmic yes -hmm \"{ module_root.GetAC()}\" -lm \"{module_root.GetLM()}\" -dict \"{module_root.GetDic()}\"";
                ps_proc = Process.Start(path, args_live);
                ps_proc.Exited += Ps_proc_Exited;
                ShowWindow(ps_proc.MainWindowHandle, 0);
            }
        }

        private void GetProgBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog2.FileName;
            ProgPath.Text = path;
            Properties.Settings.Default.LastProgPath = path;
            Properties.Settings.Default.Save();
        }
    }
}
