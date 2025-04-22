namespace Odev2
{
    partial class Form1
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
            this.cmbOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblOdemeYontemi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            this.cmbOdemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdemeYontemi.FormattingEnabled = true;
            this.cmbOdemeYontemi.Location = new System.Drawing.Point(470, 152);
            this.cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            this.cmbOdemeYontemi.Size = new System.Drawing.Size(340, 41);
            this.cmbOdemeYontemi.TabIndex = 0;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutar.Location = new System.Drawing.Point(470, 208);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(340, 40);
            this.txtTutar.TabIndex = 1;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslat.Location = new System.Drawing.Point(350, 300);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(268, 55);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Baslat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblOdemeYontemi
            // 
            this.lblOdemeYontemi.AutoSize = true;
            this.lblOdemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdemeYontemi.Location = new System.Drawing.Point(200, 160);
            this.lblOdemeYontemi.Name = "lblOdemeYontemi";
            this.lblOdemeYontemi.Size = new System.Drawing.Size(235, 33);
            this.lblOdemeYontemi.TabIndex = 3;
            this.lblOdemeYontemi.Text = "Odeme Yontemi:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(344, 215);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(91, 33);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(344, 403);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(105, 33);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuc:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 606);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblOdemeYontemi);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cmbOdemeYontemi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdemeYontemi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblOdemeYontemi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblSonuc;
    }
}

