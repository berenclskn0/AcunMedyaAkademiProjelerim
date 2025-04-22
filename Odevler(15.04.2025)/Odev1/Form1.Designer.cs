namespace Odev1
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
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.lstSiniflar = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(273, 428);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(283, 67);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Klasor Sec";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // lstSiniflar
            // 
            this.lstSiniflar.FormattingEnabled = true;
            this.lstSiniflar.ItemHeight = 33;
            this.lstSiniflar.Location = new System.Drawing.Point(83, 37);
            this.lstSiniflar.Name = "lstSiniflar";
            this.lstSiniflar.Size = new System.Drawing.Size(662, 334);
            this.lstSiniflar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 558);
            this.Controls.Add(this.lstSiniflar);
            this.Controls.Add(this.btnKlasorSec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.ListBox lstSiniflar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

