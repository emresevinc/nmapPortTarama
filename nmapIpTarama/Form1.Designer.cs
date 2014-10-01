namespace nmapIpTarama
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
            this.tara_btn = new System.Windows.Forms.Button();
            this.ipAdress_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genelSonuc_txt = new System.Windows.Forms.TextBox();
            this.eskiListe = new System.Windows.Forms.ListBox();
            this.yeniListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tara_btn
            // 
            this.tara_btn.AutoEllipsis = true;
            this.tara_btn.Location = new System.Drawing.Point(152, 104);
            this.tara_btn.Name = "tara_btn";
            this.tara_btn.Size = new System.Drawing.Size(75, 23);
            this.tara_btn.TabIndex = 0;
            this.tara_btn.Text = "TARA";
            this.tara_btn.UseVisualStyleBackColor = true;
            this.tara_btn.Click += new System.EventHandler(this.tara_btn_Click);
            // 
            // ipAdress_txt
            // 
            this.ipAdress_txt.Location = new System.Drawing.Point(216, 62);
            this.ipAdress_txt.Name = "ipAdress_txt";
            this.ipAdress_txt.Size = new System.Drawing.Size(100, 20);
            this.ipAdress_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taranacak IP Adresi  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlk Durum Açık Portlar  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Son Durum Açık Portlar  :";
            // 
            // genelSonuc_txt
            // 
            this.genelSonuc_txt.Location = new System.Drawing.Point(15, 269);
            this.genelSonuc_txt.Multiline = true;
            this.genelSonuc_txt.Name = "genelSonuc_txt";
            this.genelSonuc_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.genelSonuc_txt.Size = new System.Drawing.Size(361, 88);
            this.genelSonuc_txt.TabIndex = 7;
            // 
            // eskiListe
            // 
            this.eskiListe.FormattingEnabled = true;
            this.eskiListe.Location = new System.Drawing.Point(15, 168);
            this.eskiListe.Name = "eskiListe";
            this.eskiListe.Size = new System.Drawing.Size(160, 95);
            this.eskiListe.TabIndex = 8;
            // 
            // yeniListe
            // 
            this.yeniListe.FormattingEnabled = true;
            this.yeniListe.Location = new System.Drawing.Point(206, 168);
            this.yeniListe.Name = "yeniListe";
            this.yeniListe.Size = new System.Drawing.Size(170, 95);
            this.yeniListe.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.yeniListe);
            this.Controls.Add(this.eskiListe);
            this.Controls.Add(this.genelSonuc_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAdress_txt);
            this.Controls.Add(this.tara_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tara_btn;
        private System.Windows.Forms.TextBox ipAdress_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox genelSonuc_txt;
        private System.Windows.Forms.ListBox eskiListe;
        private System.Windows.Forms.ListBox yeniListe;
    }
}

