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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();

           
        }

     

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            toolStrip.Items["txtDosyaYolu"].Text = GlobalClass.FilePath;//FileName;
        /*    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                GlobalClass.FilePath = FileName;

                toolStrip.Items["txtDosyaYolu"].Text = FileName;
            }
         */   RecordList frm = new RecordList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
  
      
        private void MDIParent_Load(object sender, EventArgs e)
        {
            if(!File.Exists(GlobalClass.FilePath))
            { 
               FileStream fr = File.Create(GlobalClass.FilePath); // bir metin dosyası oluşturur.
                fr.Close();
            }
          
        }

       
    }
}
