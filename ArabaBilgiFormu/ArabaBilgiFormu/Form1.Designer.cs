namespace ArabaBilgiFormu
{
    partial class ArabaBilgiFormu
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
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            lblYaktigiYakitMiktari = new Label();
            btnBilgileriGoster = new Button();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtYaktigiYakitMiktari = new TextBox();
            txtKapiSayisi = new TextBox();
            txtRenk = new TextBox();
            txtPencereSayisi = new TextBox();
            listBoxSonuc = new ListBox();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(348, 38);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(73, 28);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(346, 108);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(75, 28);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(358, 178);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(63, 28);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "Renk:";
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(309, 248);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(112, 28);
            lblKapiSayisi.TabIndex = 3;
            lblKapiSayisi.Text = "Kapi Sayisi:";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(276, 318);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(145, 28);
            lblPencereSayisi.TabIndex = 4;
            lblPencereSayisi.Text = "Pencere Sayisi:";
            // 
            // lblYaktigiYakitMiktari
            // 
            lblYaktigiYakitMiktari.AutoSize = true;
            lblYaktigiYakitMiktari.Location = new Point(196, 388);
            lblYaktigiYakitMiktari.Name = "lblYaktigiYakitMiktari";
            lblYaktigiYakitMiktari.Size = new Size(225, 28);
            lblYaktigiYakitMiktari.TabIndex = 5;
            lblYaktigiYakitMiktari.Text = "100 km'de Yaktigi Yakit:";
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Location = new Point(432, 446);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(209, 49);
            btnBilgileriGoster.TabIndex = 6;
            btnBilgileriGoster.Text = "Bilgileri Goster";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(432, 32);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(209, 34);
            txtMarka.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(432, 101);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(209, 34);
            txtModel.TabIndex = 8;
            // 
            // txtYaktigiYakitMiktari
            // 
            txtYaktigiYakitMiktari.Location = new Point(432, 377);
            txtYaktigiYakitMiktari.Name = "txtYaktigiYakitMiktari";
            txtYaktigiYakitMiktari.Size = new Size(209, 34);
            txtYaktigiYakitMiktari.TabIndex = 13;
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(432, 239);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(209, 34);
            txtKapiSayisi.TabIndex = 14;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(432, 170);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(209, 34);
            txtRenk.TabIndex = 15;
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(432, 308);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(209, 34);
            txtPencereSayisi.TabIndex = 16;
            // 
            // listBoxSonuc
            // 
            listBoxSonuc.FormattingEnabled = true;
            listBoxSonuc.HorizontalScrollbar = true;
            listBoxSonuc.ItemHeight = 28;
            listBoxSonuc.Location = new Point(29, 542);
            listBoxSonuc.Name = "listBoxSonuc";
            listBoxSonuc.Size = new Size(931, 116);
            listBoxSonuc.TabIndex = 17;
            // 
            // ArabaBilgiFormu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(984, 683);
            Controls.Add(listBoxSonuc);
            Controls.Add(txtPencereSayisi);
            Controls.Add(txtRenk);
            Controls.Add(txtKapiSayisi);
            Controls.Add(txtYaktigiYakitMiktari);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(lblYaktigiYakitMiktari);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ArabaBilgiFormu";
            Text = "Araba Bilgi Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private Label lblYaktigiYakitMiktari;
        private Button btnBilgileriGoster;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtYaktigiYakitMiktari;
        private TextBox txtKapiSayisi;
        private TextBox txtRenk;
        private TextBox txtPencereSayisi;
        private ListBox listBoxSonuc;
    }
}
