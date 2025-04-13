namespace JsonKullanimi
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
            btnUrunleriGoster = new Button();
            lstUrunler = new ListBox();
            SuspendLayout();
            // 
            // btnUrunleriGoster
            // 
            btnUrunleriGoster.Location = new Point(262, 340);
            btnUrunleriGoster.Name = "btnUrunleriGoster";
            btnUrunleriGoster.Size = new Size(202, 53);
            btnUrunleriGoster.TabIndex = 5;
            btnUrunleriGoster.Text = "Urunleri Goster";
            btnUrunleriGoster.UseVisualStyleBackColor = true;
            btnUrunleriGoster.Click += btnUrunleriGoster_Click;
            // 
            // lstUrunler
            // 
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 25;
            lstUrunler.Location = new Point(115, 46);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(496, 254);
            lstUrunler.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 453);
            Controls.Add(lstUrunler);
            Controls.Add(btnUrunleriGoster);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUrunAdi;
        private Label lblFiyat;
        private TextBox txtUrunAdi;
        private TextBox txtFiyat;
        private Button btnSerialize;
        private Button btnUrunleriGoster;
        private ListBox lstUrunler;
    }
}
