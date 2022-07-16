
namespace AdoNetGirisv2
{
    partial class Connection
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
            this.listBoxRehber = new System.Windows.Forms.ListBox();
            this.buttonKayitGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRehber
            // 
            this.listBoxRehber.FormattingEnabled = true;
            this.listBoxRehber.ItemHeight = 20;
            this.listBoxRehber.Location = new System.Drawing.Point(32, 12);
            this.listBoxRehber.Name = "listBoxRehber";
            this.listBoxRehber.Size = new System.Drawing.Size(184, 404);
            this.listBoxRehber.TabIndex = 0;
            // 
            // buttonKayitGetir
            // 
            this.buttonKayitGetir.Location = new System.Drawing.Point(32, 440);
            this.buttonKayitGetir.Name = "buttonKayitGetir";
            this.buttonKayitGetir.Size = new System.Drawing.Size(184, 41);
            this.buttonKayitGetir.TabIndex = 1;
            this.buttonKayitGetir.Text = "Kayitlari Getir";
            this.buttonKayitGetir.UseVisualStyleBackColor = true;
            this.buttonKayitGetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTelefonNumarasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIsim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(222, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 469);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "q";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(22, 326);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(301, 55);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(198, 266);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email Adress";
            // 
            // textBoxTelefonNumarasi
            // 
            this.textBoxTelefonNumarasi.Location = new System.Drawing.Point(198, 174);
            this.textBoxTelefonNumarasi.Name = "textBoxTelefonNumarasi";
            this.textBoxTelefonNumarasi.Size = new System.Drawing.Size(125, 27);
            this.textBoxTelefonNumarasi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon numarasi ";
            // 
            // textBoxSoyisim
            // 
            this.textBoxSoyisim.Location = new System.Drawing.Point(198, 95);
            this.textBoxSoyisim.Name = "textBoxSoyisim";
            this.textBoxSoyisim.Size = new System.Drawing.Size(125, 27);
            this.textBoxSoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Location = new System.Drawing.Point(198, 32);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(125, 27);
            this.textBoxIsim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonKayitGetir);
            this.Controls.Add(this.listBoxRehber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRehber;
        private System.Windows.Forms.Button buttonKayitGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefonNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKaydet;
    }
}

