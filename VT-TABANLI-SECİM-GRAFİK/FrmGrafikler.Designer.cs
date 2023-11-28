namespace VT_TABANLI_SECİM_GRAFİK
{
    partial class VTGS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafikler = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.pBE = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pBD = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pBC = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pBA = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pBB = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grafikler
            // 
            this.Grafikler.Controls.Add(this.chart1);
            this.Grafikler.Location = new System.Drawing.Point(12, 12);
            this.Grafikler.Name = "Grafikler";
            this.Grafikler.Size = new System.Drawing.Size(1160, 333);
            this.Grafikler.TabIndex = 0;
            this.Grafikler.TabStop = false;
            this.Grafikler.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Partiler";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1154, 306);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblE);
            this.groupBox1.Controls.Add(this.lblD);
            this.groupBox1.Controls.Add(this.lblC);
            this.groupBox1.Controls.Add(this.lblB);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.pBE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pBD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pBC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pBA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pBB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlçe Değerleri";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblE.Location = new System.Drawing.Point(1052, 331);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(26, 29);
            this.lblE.TabIndex = 4;
            this.lblE.Text = "0";
            this.lblE.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblD.Location = new System.Drawing.Point(1052, 261);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(26, 29);
            this.lblD.TabIndex = 4;
            this.lblD.Text = "0";
            this.lblD.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC.Location = new System.Drawing.Point(1052, 194);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 29);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "0";
            this.lblC.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblB.Location = new System.Drawing.Point(1052, 124);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 29);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "0";
            this.lblB.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.Location = new System.Drawing.Point(1052, 61);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 29);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "0";
            // 
            // pBE
            // 
            this.pBE.Location = new System.Drawing.Point(512, 322);
            this.pBE.Maximum = 200;
            this.pBE.Name = "pBE";
            this.pBE.Size = new System.Drawing.Size(501, 41);
            this.pBE.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(418, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "E Parti:";
            // 
            // pBD
            // 
            this.pBD.Location = new System.Drawing.Point(512, 252);
            this.pBD.Maximum = 200;
            this.pBD.Name = "pBD";
            this.pBD.Size = new System.Drawing.Size(501, 41);
            this.pBD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(418, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "D Parti:";
            // 
            // pBC
            // 
            this.pBC.Location = new System.Drawing.Point(512, 182);
            this.pBC.Maximum = 200;
            this.pBC.Name = "pBC";
            this.pBC.Size = new System.Drawing.Size(501, 41);
            this.pBC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(418, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "C Parti:";
            // 
            // pBA
            // 
            this.pBA.Location = new System.Drawing.Point(512, 52);
            this.pBA.Maximum = 200;
            this.pBA.Name = "pBA";
            this.pBA.Size = new System.Drawing.Size(501, 41);
            this.pBA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(418, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "A Parti:";
            // 
            // pBB
            // 
            this.pBB.Location = new System.Drawing.Point(512, 115);
            this.pBB.Maximum = 200;
            this.pBB.Name = "pBB";
            this.pBB.Size = new System.Drawing.Size(501, 41);
            this.pBB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(418, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "B Parti:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // VTGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1184, 799);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grafikler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VTGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.Grafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ProgressBar pBE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pBB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
    }
}