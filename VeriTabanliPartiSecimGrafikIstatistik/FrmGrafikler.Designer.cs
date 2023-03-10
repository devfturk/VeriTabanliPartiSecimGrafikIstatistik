
namespace VeriTabanliPartiSecimGrafikIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lble);
            this.groupBox2.Controls.Add(this.lbld);
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(878, 237);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(106, 72);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(106, 100);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(361, 24);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Parti:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(106, 127);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(361, 24);
            this.progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "C Parti:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(106, 154);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(361, 24);
            this.progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "D Parti:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(106, 182);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(361, 24);
            this.progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(486, 80);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(17, 16);
            this.lbla.TabIndex = 12;
            this.lbla.Text = "0";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(486, 135);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(17, 16);
            this.lblc.TabIndex = 13;
            this.lblc.Text = "0";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(486, 108);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(17, 16);
            this.lblb.TabIndex = 14;
            this.lblb.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(486, 162);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(17, 16);
            this.lbld.TabIndex = 15;
            this.lbld.Text = "0";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(486, 190);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(17, 16);
            this.lble.TabIndex = 16;
            this.lble.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(898, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafikler";
            this.Text = "VTGS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}