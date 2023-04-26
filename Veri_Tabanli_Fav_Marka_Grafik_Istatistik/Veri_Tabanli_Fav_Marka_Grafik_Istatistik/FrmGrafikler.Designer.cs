namespace Veri_Tabanli_Fav_Marka_Grafik_Istatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGmc = new System.Windows.Forms.Label();
            this.lblFiat = new System.Windows.Forms.Label();
            this.lblFord = new System.Windows.Forms.Label();
            this.lblHonda = new System.Windows.Forms.Label();
            this.lblBmw = new System.Windows.Forms.Label();
            this.lblAudi = new System.Windows.Forms.Label();
            this.lblMer = new System.Windows.Forms.Label();
            this.progBarGmc = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progBarFiat = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.progBarFord = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.progBarHon = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progBarBmw = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progBarAudi = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progBarMer = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxUlkeSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(85, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Araç Markaları";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(874, 240);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGmc);
            this.groupBox2.Controls.Add(this.lblFiat);
            this.groupBox2.Controls.Add(this.lblFord);
            this.groupBox2.Controls.Add(this.lblHonda);
            this.groupBox2.Controls.Add(this.lblBmw);
            this.groupBox2.Controls.Add(this.lblAudi);
            this.groupBox2.Controls.Add(this.lblMer);
            this.groupBox2.Controls.Add(this.progBarGmc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progBarFiat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.progBarFord);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.progBarHon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progBarBmw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progBarAudi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progBarMer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBoxUlkeSec);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(88, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ülke Verileri";
            // 
            // lblGmc
            // 
            this.lblGmc.AutoSize = true;
            this.lblGmc.Location = new System.Drawing.Point(813, 235);
            this.lblGmc.Name = "lblGmc";
            this.lblGmc.Size = new System.Drawing.Size(21, 21);
            this.lblGmc.TabIndex = 22;
            this.lblGmc.Text = "0";
            // 
            // lblFiat
            // 
            this.lblFiat.AutoSize = true;
            this.lblFiat.Location = new System.Drawing.Point(813, 200);
            this.lblFiat.Name = "lblFiat";
            this.lblFiat.Size = new System.Drawing.Size(21, 21);
            this.lblFiat.TabIndex = 21;
            this.lblFiat.Text = "0";
            // 
            // lblFord
            // 
            this.lblFord.AutoSize = true;
            this.lblFord.Location = new System.Drawing.Point(813, 165);
            this.lblFord.Name = "lblFord";
            this.lblFord.Size = new System.Drawing.Size(21, 21);
            this.lblFord.TabIndex = 20;
            this.lblFord.Text = "0";
            // 
            // lblHonda
            // 
            this.lblHonda.AutoSize = true;
            this.lblHonda.Location = new System.Drawing.Point(813, 132);
            this.lblHonda.Name = "lblHonda";
            this.lblHonda.Size = new System.Drawing.Size(21, 21);
            this.lblHonda.TabIndex = 19;
            this.lblHonda.Text = "0";
            // 
            // lblBmw
            // 
            this.lblBmw.AutoSize = true;
            this.lblBmw.Location = new System.Drawing.Point(813, 97);
            this.lblBmw.Name = "lblBmw";
            this.lblBmw.Size = new System.Drawing.Size(21, 21);
            this.lblBmw.TabIndex = 18;
            this.lblBmw.Text = "0";
            // 
            // lblAudi
            // 
            this.lblAudi.AutoSize = true;
            this.lblAudi.Location = new System.Drawing.Point(813, 62);
            this.lblAudi.Name = "lblAudi";
            this.lblAudi.Size = new System.Drawing.Size(21, 21);
            this.lblAudi.TabIndex = 17;
            this.lblAudi.Text = "0";
            // 
            // lblMer
            // 
            this.lblMer.AutoSize = true;
            this.lblMer.Location = new System.Drawing.Point(813, 27);
            this.lblMer.Name = "lblMer";
            this.lblMer.Size = new System.Drawing.Size(21, 21);
            this.lblMer.TabIndex = 16;
            this.lblMer.Text = "0";
            // 
            // progBarGmc
            // 
            this.progBarGmc.Location = new System.Drawing.Point(562, 227);
            this.progBarGmc.Maximum = 500;
            this.progBarGmc.Name = "progBarGmc";
            this.progBarGmc.Size = new System.Drawing.Size(239, 29);
            this.progBarGmc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gmc:";
            // 
            // progBarFiat
            // 
            this.progBarFiat.Location = new System.Drawing.Point(562, 192);
            this.progBarFiat.Maximum = 500;
            this.progBarFiat.Name = "progBarFiat";
            this.progBarFiat.Size = new System.Drawing.Size(239, 29);
            this.progBarFiat.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fiat:";
            // 
            // progBarFord
            // 
            this.progBarFord.Location = new System.Drawing.Point(562, 157);
            this.progBarFord.Maximum = 500;
            this.progBarFord.Name = "progBarFord";
            this.progBarFord.Size = new System.Drawing.Size(239, 29);
            this.progBarFord.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ford:";
            // 
            // progBarHon
            // 
            this.progBarHon.Location = new System.Drawing.Point(562, 124);
            this.progBarHon.Maximum = 500;
            this.progBarHon.Name = "progBarHon";
            this.progBarHon.Size = new System.Drawing.Size(239, 29);
            this.progBarHon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Honda:";
            // 
            // progBarBmw
            // 
            this.progBarBmw.Location = new System.Drawing.Point(562, 89);
            this.progBarBmw.Maximum = 500;
            this.progBarBmw.Name = "progBarBmw";
            this.progBarBmw.Size = new System.Drawing.Size(239, 29);
            this.progBarBmw.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bmw:";
            // 
            // progBarAudi
            // 
            this.progBarAudi.Location = new System.Drawing.Point(562, 54);
            this.progBarAudi.Maximum = 500;
            this.progBarAudi.Name = "progBarAudi";
            this.progBarAudi.Size = new System.Drawing.Size(239, 29);
            this.progBarAudi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Audi:";
            // 
            // progBarMer
            // 
            this.progBarMer.BackColor = System.Drawing.Color.Green;
            this.progBarMer.Location = new System.Drawing.Point(562, 19);
            this.progBarMer.Maximum = 500;
            this.progBarMer.Name = "progBarMer";
            this.progBarMer.Size = new System.Drawing.Size(239, 29);
            this.progBarMer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mercedes:";
            // 
            // cmbBoxUlkeSec
            // 
            this.cmbBoxUlkeSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUlkeSec.FormattingEnabled = true;
            this.cmbBoxUlkeSec.Location = new System.Drawing.Point(145, 124);
            this.cmbBoxUlkeSec.Name = "cmbBoxUlkeSec";
            this.cmbBoxUlkeSec.Size = new System.Drawing.Size(239, 29);
            this.cmbBoxUlkeSec.TabIndex = 1;
            this.cmbBoxUlkeSec.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUlkeSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ülke Seçin:";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1100, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ülkelere Göre Favori Araba Markası";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGmc;
        private System.Windows.Forms.Label lblFiat;
        private System.Windows.Forms.Label lblFord;
        private System.Windows.Forms.Label lblHonda;
        private System.Windows.Forms.Label lblBmw;
        private System.Windows.Forms.Label lblAudi;
        private System.Windows.Forms.Label lblMer;
        private System.Windows.Forms.ProgressBar progBarGmc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progBarFiat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progBarFord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progBarHon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progBarBmw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progBarAudi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progBarMer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxUlkeSec;
        private System.Windows.Forms.Label label1;
    }
}