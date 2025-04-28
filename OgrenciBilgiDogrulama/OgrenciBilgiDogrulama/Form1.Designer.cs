namespace OgrenciBilgiDogrulama
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
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            lblSonuc = new Label();
            btnDogrula = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(422, 125);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(60, 40);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(529, 122);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(300, 46);
            txtAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(378, 248);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(104, 40);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(372, 359);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(110, 40);
            lblBolum.TabIndex = 3;
            lblBolum.Text = "Bolum:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(529, 242);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(300, 46);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(529, 353);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(300, 46);
            txtBolum.TabIndex = 5;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(387, 604);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(105, 40);
            lblSonuc.TabIndex = 6;
            lblSonuc.Text = "Sonuc:";
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(555, 468);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(244, 71);
            btnDogrula.TabIndex = 7;
            btnDogrula.Text = "Dogrula";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 756);
            Controls.Add(btnDogrula);
            Controls.Add(lblSonuc);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private TextBox txtAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Label lblSonuc;
        private Button btnDogrula;
    }
}
