using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitSistemi
{
    public class GlobalMethods
    {
        public object Page { get; private set; }

        public List<Ogrenci> OgrenciListesi()
        {
            List<Ogrenci> tmpOgrenci = new List<Ogrenci>();
            string dosya_yolu = GlobalClass.FilePath;
            string[] file = File.ReadAllLines(dosya_yolu, Encoding.GetEncoding(1254));
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string satirDegeri = sw.ReadLine();
            while (!string.IsNullOrEmpty(satirDegeri))
            {
                Ogrenci tmp = new Ogrenci();
                tmp.Id = Convert.ToInt32(satirDegeri.Split('~')[0]);
                tmp.name = satirDegeri.Split('~')[1];
                tmp.surName = satirDegeri.Split('~')[2];
                tmp.silindi = Convert.ToInt32(satirDegeri.Split('~')[3]);
                tmpOgrenci.Add(tmp);
                satirDegeri = sw.ReadLine();
            }

            sw.Close();
            fs.Close();

            return tmpOgrenci;
        }
    }
}


