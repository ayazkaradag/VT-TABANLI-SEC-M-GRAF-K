namespace VT_TABANLI_SECİM_GRAFİK
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtilceAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtilceAd
            // 
            this.txtilceAd.Location = new System.Drawing.Point(233, 29);
            this.txtilceAd.Name = "txtilceAd";
            this.txtilceAd.Size = new System.Drawing.Size(191, 30);
            this.txtilceAd.TabIndex = 1;
            this.txtilceAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "A Parti:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(192, 92);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(266, 30);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(192, 146);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(266, 30);
            this.txtB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "B Parti:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(192, 204);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(266, 30);
            this.txtC.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "C Parti:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(192, 270);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(266, 30);
            this.txtD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "D Parti:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(95, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "E Parti:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(192, 336);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(266, 30);
            this.txtE.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(192, 386);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(266, 41);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Oy Girişi Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(192, 433);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(117, 37);
            this.btnGraf.TabIndex = 2;
            this.btnGraf.Text = "Grafikler";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(334, 433);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(124, 37);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(580, 495);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtilceAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilceAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnCikis;
    }
}

