namespace OgrenciKayitSistemi
{
    partial class RecordList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.Kaydet = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.AraOgrNo = new System.Windows.Forms.TextBox();
            this.AraAd = new System.Windows.Forms.TextBox();
            this.AraSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.Soyadlabel4 = new System.Windows.Forms.Label();
            this.Adlabel5 = new System.Windows.Forms.Label();
            this.ÖğrNolabel6 = new System.Windows.Forms.Label();
            this.Soyad_textBox4 = new System.Windows.Forms.TextBox();
            this.ÖğrNo_textBox5 = new System.Windows.Forms.TextBox();
            this.Ad_textBox6 = new System.Windows.Forms.TextBox();
            this.NewRecordbutton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(12, 179);
            this.dtGrid.MultiSelect = false;
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid.Size = new System.Drawing.Size(512, 124);
            this.dtGrid.TabIndex = 0;
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(384, 309);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 2;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(282, 309);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 3;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // AraOgrNo
            // 
            this.AraOgrNo.Location = new System.Drawing.Point(160, 28);
            this.AraOgrNo.Name = "AraOgrNo";
            this.AraOgrNo.Size = new System.Drawing.Size(100, 20);
            this.AraOgrNo.TabIndex = 4;
            this.AraOgrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraOgrNo_KeyPress);
            // 
            // AraAd
            // 
            this.AraAd.Location = new System.Drawing.Point(160, 56);
            this.AraAd.Name = "AraAd";
            this.AraAd.Size = new System.Drawing.Size(100, 20);
            this.AraAd.TabIndex = 5;
            this.AraAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraAd_KeyPress);
            // 
            // AraSoyad
            // 
            this.AraSoyad.Location = new System.Drawing.Point(160, 92);
            this.AraSoyad.Name = "AraSoyad";
            this.AraSoyad.Size = new System.Drawing.Size(100, 20);
            this.AraSoyad.TabIndex = 6;
            this.AraSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraAd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(449, 90);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Soyadlabel4
            // 
            this.Soyadlabel4.AutoSize = true;
            this.Soyadlabel4.Location = new System.Drawing.Point(35, 381);
            this.Soyadlabel4.Name = "Soyadlabel4";
            this.Soyadlabel4.Size = new System.Drawing.Size(37, 13);
            this.Soyadlabel4.TabIndex = 11;
            this.Soyadlabel4.Text = "Soyad";
            // 
            // Adlabel5
            // 
            this.Adlabel5.AutoSize = true;
            this.Adlabel5.Location = new System.Drawing.Point(35, 355);
            this.Adlabel5.Name = "Adlabel5";
            this.Adlabel5.Size = new System.Drawing.Size(20, 13);
            this.Adlabel5.TabIndex = 12;
            this.Adlabel5.Text = "Ad";
            // 
            // ÖğrNolabel6
            // 
            this.ÖğrNolabel6.AutoSize = true;
            this.ÖğrNolabel6.Location = new System.Drawing.Point(35, 325);
            this.ÖğrNolabel6.Name = "ÖğrNolabel6";
            this.ÖğrNolabel6.Size = new System.Drawing.Size(44, 13);
            this.ÖğrNolabel6.TabIndex = 13;
            this.ÖğrNolabel6.Text = "Öğr. No";
            // 
            // Soyad_textBox4
            // 
            this.Soyad_textBox4.Location = new System.Drawing.Point(104, 374);
            this.Soyad_textBox4.Name = "Soyad_textBox4";
            this.Soyad_textBox4.Size = new System.Drawing.Size(100, 20);
            this.Soyad_textBox4.TabIndex = 14;
            this.Soyad_textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraAd_KeyPress);
            // 
            // ÖğrNo_textBox5
            // 
            this.ÖğrNo_textBox5.Location = new System.Drawing.Point(104, 322);
            this.ÖğrNo_textBox5.Name = "ÖğrNo_textBox5";
            this.ÖğrNo_textBox5.Size = new System.Drawing.Size(100, 20);
            this.ÖğrNo_textBox5.TabIndex = 15;
            this.ÖğrNo_textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraOgrNo_KeyPress);
            // 
            // Ad_textBox6
            // 
            this.Ad_textBox6.Location = new System.Drawing.Point(104, 348);
            this.Ad_textBox6.Name = "Ad_textBox6";
            this.Ad_textBox6.Size = new System.Drawing.Size(100, 20);
            this.Ad_textBox6.TabIndex = 16;
            this.Ad_textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraAd_KeyPress);
            // 
            // NewRecordbutton3
            // 
            this.NewRecordbutton3.Location = new System.Drawing.Point(384, 363);
            this.NewRecordbutton3.Name = "NewRecordbutton3";
            this.NewRecordbutton3.Size = new System.Drawing.Size(75, 23);
            this.NewRecordbutton3.TabIndex = 17;
            this.NewRecordbutton3.Text = "Yeni Kayıt";
            this.NewRecordbutton3.UseVisualStyleBackColor = true;
            this.NewRecordbutton3.Click += new System.EventHandler(this.NewRecordbutton3_Click);
            // 
            // RecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.NewRecordbutton3);
            this.Controls.Add(this.Ad_textBox6);
            this.Controls.Add(this.ÖğrNo_textBox5);
            this.Controls.Add(this.Soyad_textBox4);
            this.Controls.Add(this.ÖğrNolabel6);
            this.Controls.Add(this.Adlabel5);
            this.Controls.Add(this.Soyadlabel4);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AraSoyad);
            this.Controls.Add(this.AraAd);
            this.Controls.Add(this.AraOgrNo);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dtGrid);
            this.Name = "RecordList";
            this.Text = "Kayıt Lisstesi";
            this.Load += new System.EventHandler(this.RecordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox AraOgrNo;
        private System.Windows.Forms.TextBox AraAd;
        private System.Windows.Forms.TextBox AraSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label Soyadlabel4;
        private System.Windows.Forms.Label Adlabel5;
        private System.Windows.Forms.Label ÖğrNolabel6;
        private System.Windows.Forms.TextBox Soyad_textBox4;
        private System.Windows.Forms.TextBox ÖğrNo_textBox5;
        private System.Windows.Forms.TextBox Ad_textBox6;
        private System.Windows.Forms.Button NewRecordbutton3;
    }
}