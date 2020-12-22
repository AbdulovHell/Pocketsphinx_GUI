using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocketsphinx_GUI
{
    public static class Searchers
    {
        public static string GetDic(this string path)
        {
            return System.IO.Directory.EnumerateFiles(path,"*.dic", System.IO.SearchOption.AllDirectories).FirstOrDefault();
        }

        public static string GetLM(this string path)
        {
            return System.IO.Directory.EnumerateFiles(path, "*.lm", System.IO.SearchOption.AllDirectories).FirstOrDefault();
        }

        public static string GetAC(this string path)
        {
            return System.IO.Directory.EnumerateDirectories(path, "*cont*", System.IO.SearchOption.AllDirectories).FirstOrDefault();
        }
    }
}
