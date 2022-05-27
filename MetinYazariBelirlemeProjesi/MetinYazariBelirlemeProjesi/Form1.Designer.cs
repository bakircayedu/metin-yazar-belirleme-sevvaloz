namespace MetinYazariBelirlemeProjesi
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
            this.buttonDosyaOku = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStackYap = new System.Windows.Forms.Button();
            this.buttonTreeYap = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDosyaOku
            // 
            this.buttonDosyaOku.Location = new System.Drawing.Point(271, 30);
            this.buttonDosyaOku.Name = "buttonDosyaOku";
            this.buttonDosyaOku.Size = new System.Drawing.Size(182, 54);
            this.buttonDosyaOku.TabIndex = 0;
            this.buttonDosyaOku.Text = "DOSYA SEÇ";
            this.buttonDosyaOku.UseVisualStyleBackColor = true;
            this.buttonDosyaOku.Click += new System.EventHandler(this.buttonDosyaOku_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(161, 105);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(467, 22);
            this.text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya Yolu:";
            // 
            // buttonStackYap
            // 
            this.buttonStackYap.Location = new System.Drawing.Point(78, 166);
            this.buttonStackYap.Name = "buttonStackYap";
            this.buttonStackYap.Size = new System.Drawing.Size(271, 51);
            this.buttonStackYap.TabIndex = 3;
            this.buttonStackYap.Text = "Metin Belgesini Cümlelere Ayır";
            this.buttonStackYap.UseVisualStyleBackColor = true;
            this.buttonStackYap.Click += new System.EventHandler(this.buttonStackYap_Click);
            // 
            // buttonTreeYap
            // 
            this.buttonTreeYap.Location = new System.Drawing.Point(355, 166);
            this.buttonTreeYap.Name = "buttonTreeYap";
            this.buttonTreeYap.Size = new System.Drawing.Size(271, 51);
            this.buttonTreeYap.TabIndex = 4;
            this.buttonTreeYap.Text = "Cümleleri Kelimelere Ayır";
            this.buttonTreeYap.UseVisualStyleBackColor = true;
            this.buttonTreeYap.Click += new System.EventHandler(this.buttonTreeYap_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 351);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(697, 98);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonGoster
            // 
            this.buttonGoster.Location = new System.Drawing.Point(217, 294);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(271, 51);
            this.buttonGoster.TabIndex = 6;
            this.buttonGoster.Text = "Kelime Bilgilerini Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 461);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonTreeYap);
            this.Controls.Add(this.buttonStackYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.buttonDosyaOku);
            this.Name = "Form1";
            this.Text = "Metin Yazarı Belirleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDosyaOku;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStackYap;
        private System.Windows.Forms.Button buttonTreeYap;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonGoster;
    }
}

