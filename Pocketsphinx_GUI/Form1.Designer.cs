
namespace Pocketsphinx_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBtn = new System.Windows.Forms.Button();
            this.ProgLog = new System.Windows.Forms.RichTextBox();
            this.ModulePathBox = new System.Windows.Forms.TextBox();
            this.SelectModuleBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.RecordPathBox = new System.Windows.Forms.TextBox();
            this.SelectRecordBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StartLiveBtn = new System.Windows.Forms.Button();
            this.ProgPath = new System.Windows.Forms.TextBox();
            this.GetProgBtn = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(523, 91);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(121, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Запуск по файлу";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgLog
            // 
            this.ProgLog.Location = new System.Drawing.Point(12, 90);
            this.ProgLog.Name = "ProgLog";
            this.ProgLog.Size = new System.Drawing.Size(505, 313);
            this.ProgLog.TabIndex = 1;
            this.ProgLog.Text = "";
            // 
            // ModulePathBox
            // 
            this.ModulePathBox.Location = new System.Drawing.Point(12, 12);
            this.ModulePathBox.Name = "ModulePathBox";
            this.ModulePathBox.Size = new System.Drawing.Size(551, 20);
            this.ModulePathBox.TabIndex = 2;
            // 
            // SelectModuleBtn
            // 
            this.SelectModuleBtn.Location = new System.Drawing.Point(569, 10);
            this.SelectModuleBtn.Name = "SelectModuleBtn";
            this.SelectModuleBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectModuleBtn.TabIndex = 3;
            this.SelectModuleBtn.Text = "Модуль";
            this.SelectModuleBtn.UseVisualStyleBackColor = true;
            this.SelectModuleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RecordPathBox
            // 
            this.RecordPathBox.Location = new System.Drawing.Point(12, 38);
            this.RecordPathBox.Name = "RecordPathBox";
            this.RecordPathBox.Size = new System.Drawing.Size(551, 20);
            this.RecordPathBox.TabIndex = 4;
            // 
            // SelectRecordBtn
            // 
            this.SelectRecordBtn.Location = new System.Drawing.Point(569, 36);
            this.SelectRecordBtn.Name = "SelectRecordBtn";
            this.SelectRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectRecordBtn.TabIndex = 5;
            this.SelectRecordBtn.Text = "Запись";
            this.SelectRecordBtn.UseVisualStyleBackColor = true;
            this.SelectRecordBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Record|*.wav";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // StartLiveBtn
            // 
            this.StartLiveBtn.Location = new System.Drawing.Point(523, 120);
            this.StartLiveBtn.Name = "StartLiveBtn";
            this.StartLiveBtn.Size = new System.Drawing.Size(119, 42);
            this.StartLiveBtn.TabIndex = 6;
            this.StartLiveBtn.Text = "Запись с микрофона";
            this.StartLiveBtn.UseVisualStyleBackColor = true;
            this.StartLiveBtn.Click += new System.EventHandler(this.StartLiveBtn_Click);
            // 
            // ProgPath
            // 
            this.ProgPath.Location = new System.Drawing.Point(12, 64);
            this.ProgPath.Name = "ProgPath";
            this.ProgPath.Size = new System.Drawing.Size(551, 20);
            this.ProgPath.TabIndex = 7;
            // 
            // GetProgBtn
            // 
            this.GetProgBtn.Location = new System.Drawing.Point(569, 62);
            this.GetProgBtn.Name = "GetProgBtn";
            this.GetProgBtn.Size = new System.Drawing.Size(75, 23);
            this.GetProgBtn.TabIndex = 8;
            this.GetProgBtn.Text = "Прога";
            this.GetProgBtn.UseVisualStyleBackColor = true;
            this.GetProgBtn.Click += new System.EventHandler(this.GetProgBtn_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "pocketsphinx_continuous|*.exe";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 412);
            this.Controls.Add(this.GetProgBtn);
            this.Controls.Add(this.ProgPath);
            this.Controls.Add(this.StartLiveBtn);
            this.Controls.Add(this.SelectRecordBtn);
            this.Controls.Add(this.RecordPathBox);
            this.Controls.Add(this.SelectModuleBtn);
            this.Controls.Add(this.ModulePathBox);
            this.Controls.Add(this.ProgLog);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pocketsphinx GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RichTextBox ProgLog;
        private System.Windows.Forms.TextBox ModulePathBox;
        private System.Windows.Forms.Button SelectModuleBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox RecordPathBox;
        private System.Windows.Forms.Button SelectRecordBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button StartLiveBtn;
        private System.Windows.Forms.TextBox ProgPath;
        private System.Windows.Forms.Button GetProgBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

