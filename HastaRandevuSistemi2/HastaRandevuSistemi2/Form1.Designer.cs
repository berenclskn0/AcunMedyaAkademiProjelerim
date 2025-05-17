namespace HastaRandevuSistemi2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbBranslar = new ComboBox();
            cmbDoktorlar = new ComboBox();
            cmbSaat = new ComboBox();
            mtbTc = new MaskedTextBox();
            dtpTarih = new DateTimePicker();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            dataGridView1 = new DataGridView();
            btnRandevuOlustur = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 80);
            label1.Name = "label1";
            label1.Size = new Size(133, 40);
            label1.TabIndex = 0;
            label1.Text = "Branslar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 206);
            label2.Name = "label2";
            label2.Size = new Size(150, 40);
            label2.TabIndex = 1;
            label2.Text = "Doktorlar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 344);
            label3.Name = "label3";
            label3.Size = new Size(88, 40);
            label3.TabIndex = 2;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 473);
            label4.Name = "label4";
            label4.Size = new Size(80, 40);
            label4.TabIndex = 3;
            label4.Text = "Saat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1167, 80);
            label5.Name = "label5";
            label5.Size = new Size(150, 40);
            label5.TabIndex = 4;
            label5.Text = "Hasta Adi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1123, 206);
            label6.Name = "label6";
            label6.Size = new Size(194, 40);
            label6.TabIndex = 5;
            label6.Text = "Hasta Soyadi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1022, 344);
            label7.Name = "label7";
            label7.Size = new Size(295, 40);
            label7.TabIndex = 6;
            label7.Text = "T.C. Kimlik Numarasi:";
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(391, 72);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(470, 48);
            cmbBranslar.TabIndex = 7;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(391, 198);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(470, 48);
            cmbDoktorlar.TabIndex = 8;
            cmbDoktorlar.SelectedIndexChanged += cmbDoktorlar_SelectedIndexChanged;
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" });
            cmbSaat.Location = new Point(391, 465);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(470, 48);
            cmbSaat.TabIndex = 9;
            cmbSaat.Text = "Saat Seciniz";
            // 
            // mtbTc
            // 
            mtbTc.Location = new Point(1338, 338);
            mtbTc.Mask = "00000000000";
            mtbTc.Name = "mtbTc";
            mtbTc.Size = new Size(470, 46);
            mtbTc.TabIndex = 10;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(395, 332);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(466, 46);
            dtpTarih.TabIndex = 11;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(1338, 74);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(470, 46);
            txtHastaAdi.TabIndex = 12;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(1338, 200);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(470, 46);
            txtHastaSoyadi.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 589);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1487, 447);
            dataGridView1.TabIndex = 14;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(1338, 441);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(470, 72);
            btnRandevuOlustur.TabIndex = 15;
            btnRandevuOlustur.Text = "Randevu Olustur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2043, 1134);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(dataGridView1);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(dtpTarih);
            Controls.Add(mtbTc);
            Controls.Add(cmbSaat);
            Controls.Add(cmbDoktorlar);
            Controls.Add(cmbBranslar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbBranslar;
        private ComboBox cmbDoktorlar;
        private ComboBox cmbSaat;
        private MaskedTextBox mtbTc;
        private DateTimePicker dtpTarih;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private DataGridView dataGridView1;
        private Button btnRandevuOlustur;
    }
}
