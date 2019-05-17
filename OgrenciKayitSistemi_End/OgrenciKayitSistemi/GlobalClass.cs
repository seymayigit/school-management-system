using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitSistemi
{
    static class GlobalClass
    {
        private static string _filePath = Application.StartupPath+@"\a.txt";
      
        public static string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private static string _tempfilePath = Application.StartupPath + @"\b.txt";
      
        public static string TempPath
        {
            get { return _tempfilePath; }
            set { _tempfilePath = value; }
        }
    }
}
