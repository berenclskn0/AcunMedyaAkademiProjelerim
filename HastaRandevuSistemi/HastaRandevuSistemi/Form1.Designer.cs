namespace HastaRandevuSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBrans = new Label();
            lblDoktor = new Label();
            lblTarih = new Label();
            lblSaat = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            cmbBranslar = new ComboBox();
            cmbDoktorlar = new ComboBox();
            dtpTarih = new DateTimePicker();
            cmbSaat = new ComboBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(390, 92);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(133, 40);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Branslar:";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(373, 190);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(150, 40);
            lblDoktor.TabIndex = 1;
            lblDoktor.Text = "Doktorlar:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(435, 303);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(88, 40);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih:";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(443, 412);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(80, 40);
            lblSaat.TabIndex = 3;
            lblSaat.Text = "Saat:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(373, 510);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(150, 40);
            lblAd.TabIndex = 4;
            lblAd.Text = "Hasta Adi:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(329, 604);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(194, 40);
            lblSoyad.TabIndex = 5;
            lblSoyad.Text = "Hasta Soyadi:";
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(620, 84);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(484, 48);
            cmbBranslar.TabIndex = 6;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(620, 182);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(484, 48);
            cmbDoktorlar.TabIndex = 7;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(620, 297);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(484, 46);
            dtpTarih.TabIndex = 8;
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(620, 404);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(484, 48);
            cmbSaat.TabIndex = 9;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(622, 504);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(482, 46);
            txtAd.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(622, 598);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(482, 46);
            txtSoyad.TabIndex = 11;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(687, 709);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(350, 83);
            btnRandevuOlustur.TabIndex = 12;
            btnRandevuOlustur.Text = "Randevu Olustur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 903);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(cmbSaat);
            Controls.Add(dtpTarih);
            Controls.Add(cmbDoktorlar);
            Controls.Add(cmbBranslar);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(lblSaat);
            Controls.Add(lblTarih);
            Controls.Add(lblDoktor);
            Controls.Add(lblBrans);
            Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private Label lblDoktor;
        private Label lblTarih;
        private Label lblSaat;
        private Label lblAd;
        private Label lblSoyad;
        private ComboBox cmbBranslar;
        private ComboBox cmbDoktorlar;
        private DateTimePicker dtpTarih;
        private ComboBox cmbSaat;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnRandevuOlustur;
    }
}
