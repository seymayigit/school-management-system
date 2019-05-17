using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitSistemi
{
    public partial class RecordList : Form
    {
        private Boolean control = false;
        public RecordList()
        {
            InitializeComponent();
            dosyadanOku();
        }
        public static string Id1;
        public static string name1;
        public static string surname1;
        public static string Silindi1;
        public static int id;

        public void dosyadanOku()
        {   //öğrenci kayıtlarını listeliyor...
            GlobalMethods objMethods = new GlobalMethods();
            List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
            OgrenciListesi = objMethods.OgrenciListesi();


            dtGrid.DataSource = OgrenciListesi.Where(x => x.silindi == 1).OrderBy(x => x.name).ToList();
            dtGrid.Refresh();

        }



        public void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // burada dtGrid secilen degerleri alıyor ..

            int rowIndex = dtGrid.CurrentRow.Index;
            id = Convert.ToInt32(dtGrid.Rows[rowIndex].Cells["Id"].Value.ToString());
            Id1 = dtGrid.Rows[rowIndex].Cells["Id"].Value.ToString();
            name1 = dtGrid.Rows[rowIndex].Cells["name"].Value.ToString();
            surname1 = dtGrid.Rows[rowIndex].Cells["surname"].Value.ToString();
            Silindi1 = dtGrid.Rows[rowIndex].Cells["silindi"].Value.ToString();

            control = true;

            Kaydet.Text = "Güncelle";
            String[] array = dosyadan_bul(Id1);

            ÖğrNo_textBox5.Text = array[0];
            Ad_textBox6.Text = array[1];
            Soyad_textBox4.Text = array[2];

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (ÖğrNo_textBox5.Text == ""  || newString(Ad_textBox6.Text) == "" || newString(Soyad_textBox4.Text) == "")
            {
                MessageBox.Show("Lütfen gecerlı bır kayıt gırınız..");
            }
            else
            {
                GlobalMethods objMethods = new GlobalMethods();
                List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
                OgrenciListesi = objMethods.OgrenciListesi();

                if (Kaydet.Text == "Güncelle")
                {
                    if (!control)
                    {
                        MessageBox.Show("listede olmayan bir kişiyi güncellemeye çalışıyorsunuz ,lütfen listeden güncellemek istediğiniz bir kişi seçiniz..");
                        textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);
                        control = false;
                    }
                   
                    else
                    {
                        Ogrenci _ogrenci = OgrenciListesi.Where(x => (x.Id == Convert.ToInt32(Id1)) && x.silindi == 1).FirstOrDefault();
                        string dosya_yolu = GlobalClass.FilePath;

                        if (_ogrenci != null && (Convert.ToInt32(ÖğrNo_textBox5.Text) == id || !dosyadan_bulD(ÖğrNo_textBox5.Text)))
                        {

                            _ogrenci.Id = Convert.ToInt32(ÖğrNo_textBox5.Text);
                            _ogrenci.name = Ad_textBox6.Text;
                            _ogrenci.surName = Soyad_textBox4.Text;

                            string yazdirilacakText = "";
                            for (int i = 0; i < OgrenciListesi.Count; i++)
                            {
                                yazdirilacakText += OgrenciListesi[i].Id.ToString().Trim() + "~" + newString(OgrenciListesi[i].name).Trim().ToTitleCase() + "~" + newString(OgrenciListesi[i].surName).Trim().ToTitleCase() + "~" + OgrenciListesi[i].silindi.ToString().Trim() + "\r";
                            }
                            File.WriteAllText(dosya_yolu, yazdirilacakText);
                            dosyadanOku();
                            DialogResult xxx = MessageBox.Show("Kişi Güncellenmiştir..");
                            textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);
                            if (xxx == DialogResult.OK)
                            {  //RecordList fromundaki dataGridViev deki kayıtların yenlenmesini sağlıyor..
                                RecordList f1 = (RecordList)Application.OpenForms["RecordList"];
                                f1.dosyadanOku();

                            }
                            Kaydet.Text = "Kaydet";
                        }


                        else
                        {
                            MessageBox.Show("The same Id can not be used twice..");
                            ÖğrNo_textBox5.Text = id.ToString();

                        }
                        //control = false;
                    }

                }

                else//kaydet alanı buradan başlıyor..
                {
                        string yazdırılacakText = " ";
                        if (dosyadan_bul(ÖğrNo_textBox5.Text) == null)
                        {
                            string kayitSatiri = ÖğrNo_textBox5.Text.Trim() + "~" + newString(Ad_textBox6.Text).Trim().ToTitleCase() + "~" + newString(Soyad_textBox4.Text).Trim().ToTitleCase() + "~" + 1;

                            Boolean flag = false;
                            FileStream fs = File.Create(GlobalClass.TempPath); // bir metin dosyası oluşturur.
                            StreamWriter yaz = new StreamWriter(fs);
                            StreamReader oku = new StreamReader(GlobalClass.FilePath);
                            string _text = oku.ReadLine();

                            if (_text != null)//alfabetik sıraya göre sıralama yapılıyor..
                            {
                                while (_text != null)
                                {
                                    if (flag == false)
                                    {
                                        if (string.Compare((kayitSatiri.Split('~')[1] + kayitSatiri.Split('~')[2]), (_text.Split('~')[1] + _text.Split('~')[2])) <= 0)
                                        {
                                            yaz.WriteLine(kayitSatiri);
                                            flag = true;
                                        }
                                        yaz.WriteLine(_text);
                                    }


                                    else
                                    {
                                        yaz.WriteLine(_text);
                                    }

                                    _text = oku.ReadLine();

                                }
                                if (flag == false)
                                {
                                    yaz.WriteLine(kayitSatiri);
                                }
                            }
                            else
                            {
                                yaz.WriteLine(kayitSatiri);
                            }
                            yaz.Close();


                            oku.Close();

                            File.Delete(GlobalClass.FilePath);
                            FileInfo fi = new FileInfo(GlobalClass.TempPath);
                            fi.MoveTo(GlobalClass.FilePath);//dosya isimlerini değiştiriyoruz..
                            fs.Close();
                            MessageBox.Show("Record successful");
                            dosyadanOku();
                            textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);
                        }
                        else
                        {
                            MessageBox.Show("The same Id can not be used twice..");
                            ÖğrNo_textBox5.Clear();

                        }
                    }


                }

            



        }


        private void btnAra_Click(object sender, EventArgs e)
        {

            GlobalMethods objMethods = new GlobalMethods();
            List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
            OgrenciListesi = objMethods.OgrenciListesi();
            List<Ogrenci> OgrenciListesi1 = new List<Ogrenci>();

            string[] arr = new string[OgrenciListesi.Count];

            if (AraOgrNo.Text == "" && AraSoyad.Text == "" && AraAd.Text == "")
            {
                dosyadanOku();
            }



            else
            {

                for (int i = 0; i < OgrenciListesi.Count; i++)
                {
                    if (OgrenciListesi[i].silindi == 1)
                    {
                        if (String.IsNullOrEmpty(AraOgrNo.Text))
                        {

                            arr[i] = OgrenciListesi[i].Id.ToString().Trim() + "~" + OgrenciListesi[i].name.Trim().ToLower() + "~" + OgrenciListesi[i].surName.Trim().ToLower() + "~" + OgrenciListesi[i].silindi;

                            string[] text = arr[i].Split('~');
                            if ((text[1].Contains(AraAd.Text.ToLower().Trim()) == true) && (text[2].Contains(AraSoyad.Text.ToLower().Trim()) == true))
                            {
                                OgrenciListesi1.Add(new Ogrenci { Id = Convert.ToInt32(text[0].Trim()), name = text[1].ToTitleCase().Trim(), surName = text[2].ToTitleCase().Trim(), silindi = Convert.ToInt32(text[3].Trim()) });

                            }
                           
                        }
                        else
                        {
                            arr[i] = OgrenciListesi[i].Id.ToString().Trim() + "~" + OgrenciListesi[i].name.Trim().ToLower() + "~" + OgrenciListesi[i].surName.Trim().ToLower() + "~" + OgrenciListesi[i].silindi;

                            string[] text = arr[i].Split('~');
                            if (text[0] == AraOgrNo.Text && (text[1].Contains(AraAd.Text.ToLower().Trim()) == true) && (text[2].Contains(AraSoyad.Text.ToLower().Trim()) == true))
                            {
                                OgrenciListesi1.Add(new Ogrenci { Id = Convert.ToInt32(text[0].Trim()), name = text[1].ToTitleCase().Trim(), surName = text[2].ToTitleCase().Trim(), silindi = Convert.ToInt32(text[3].Trim()) });

                            }
                          
                        }



                    }


                }

                dtGrid.DataSource = OgrenciListesi1;
                dtGrid.Refresh();
            }

        }

        private void RecordList_Load(object sender, EventArgs e)
        {

        }



        private void NewRecordbutton3_Click(object sender, EventArgs e)
        {
            textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);

            Kaydet.Text = "Kaydet";

        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (control)
            {
                string dosya_yolu = GlobalClass.FilePath;
                GlobalMethods objMethods = new GlobalMethods();
                List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
                OgrenciListesi = objMethods.OgrenciListesi();


                for (int i = 0; i < OgrenciListesi.Count; i++)
                {
                    if (OgrenciListesi[i].silindi == 1)
                    {

                        if (OgrenciListesi[i].Id == Convert.ToInt32(Id1))
                        {
                            OgrenciListesi[i].silindi = 0;
                            break;
                        }
                    }
                }

                string yazdirilacakText = "";
                for (int i = 0; i < OgrenciListesi.Count; i++)
                {
                    yazdirilacakText += OgrenciListesi[i].Id.ToString() + "~" + OgrenciListesi[i].name + "~" + OgrenciListesi[i].surName + "~" + OgrenciListesi[i].silindi.ToString() + Environment.NewLine;
                }
                File.WriteAllText(dosya_yolu, yazdirilacakText);
                dosyadanOku();
                textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);


            }
            else
            {
                MessageBox.Show("lütfen kişi seçiniz..");
                textboxClear(ÖğrNo_textBox5, Ad_textBox6, Soyad_textBox4);

            }
        }


        public String[] dosyadan_bul(string id)
        {

            using (StreamReader oku = new StreamReader(GlobalClass.FilePath))// kullanılan dosya kapatılıyor..
            {
                string text = oku.ReadLine();
                while (text != null)
                {
                    String[] array = text.Split('~');

                    if (array[3] == "1")
                    {
                        if (array[0] == id)
                        {
                            return array;
                        }
                    }
                    text = oku.ReadLine();
                }
                return null;
            }
        }
 
        public Boolean dosyadan_bul()
        {
            using (StreamReader oku = new StreamReader(GlobalClass.FilePath))// kullanılan dosya kapatılıyor..
            {
                string text = oku.ReadLine();
                while (text != null)
                {
                    String[] array = text.Split('~');
                    if (array[3] == "1")
                    {
                        return true;
                        break;
                    }
                    text = oku.ReadLine();

                }
                return false;
            }
        }
        public Boolean dosyadan_bulD(string id)
        {

            using (StreamReader oku = new StreamReader(GlobalClass.FilePath))// kullanılan dosya kapatılıyor..
            {
                string text = oku.ReadLine();
                while (text != null)
                {
                    String[] array = text.Split('~');

                    if (array[3] == "1")
                    {
                        if (array[0] == id)
                        {
                            return true;
                        }
                    }
                    text = oku.ReadLine();
                }
                return false;
            }
        }

        public string newString(string y)
        {
            string[] Kelimeler = y.Split(' ');
            string newString = "";

            //Kelimeleri bosluklari aldiktan sonra birlestirelim ve araya 1 bosluk koyalim
            for (int x = 0; x < Kelimeler.Length; x++)
            {
                newString += !String.IsNullOrEmpty(Kelimeler[x]) ? Kelimeler[x].Replace(" ", "") + " " : "";

            }
            return newString;
        }

        private void textboxClear(TextBox x, TextBox y, TextBox z)
        {
            x.Clear();
            y.Clear();
            z.Clear();
        }


        private void AraAd_KeyPress(object sender, KeyPressEventArgs e)//textBox’a sadece harf girişi için:
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
   
     
        private void AraOgrNo_KeyPress(object sender, KeyPressEventArgs e)//textBox’a sadece rakam girişi için..
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

     
   

    }
    public static class ExtensionManager
    {
        public static string ToTitleCase(this string Text)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);
        }
    }

}
