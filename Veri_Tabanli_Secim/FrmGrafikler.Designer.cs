﻿namespace Veri_Tabanli_Secim
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.LblE = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.LblD = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.LblC = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.LblB = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.LblA = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.chart1);
			this.GroupBox1.Location = new System.Drawing.Point(13, 13);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(835, 352);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Grafikler";
			// 
			// chart1
			// 
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.chart1.Legends.Add(legend3);
			this.chart1.Location = new System.Drawing.Point(3, 22);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Partiler";
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(829, 327);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.progressBar5);
			this.groupBox2.Controls.Add(this.LblE);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.progressBar4);
			this.groupBox2.Controls.Add(this.LblD);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.progressBar3);
			this.groupBox2.Controls.Add(this.LblC);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.progressBar2);
			this.groupBox2.Controls.Add(this.LblB);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.progressBar1);
			this.groupBox2.Controls.Add(this.LblA);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(13, 372);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(832, 250);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "İlçe Değerleri";
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(102, 191);
			this.progressBar5.Maximum = 200;
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(410, 23);
			this.progressBar5.TabIndex = 3;
			// 
			// LblE
			// 
			this.LblE.AutoSize = true;
			this.LblE.Location = new System.Drawing.Point(518, 191);
			this.LblE.Name = "LblE";
			this.LblE.Size = new System.Drawing.Size(18, 18);
			this.LblE.TabIndex = 2;
			this.LblE.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 18);
			this.label6.TabIndex = 2;
			this.label6.Text = "E Parti:";
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(102, 162);
			this.progressBar4.Maximum = 200;
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(410, 23);
			this.progressBar4.TabIndex = 3;
			// 
			// LblD
			// 
			this.LblD.AutoSize = true;
			this.LblD.Location = new System.Drawing.Point(518, 162);
			this.LblD.Name = "LblD";
			this.LblD.Size = new System.Drawing.Size(18, 18);
			this.LblD.TabIndex = 2;
			this.LblD.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "D Parti:";
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(102, 133);
			this.progressBar3.Maximum = 200;
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(410, 23);
			this.progressBar3.TabIndex = 3;
			// 
			// LblC
			// 
			this.LblC.AutoSize = true;
			this.LblC.Location = new System.Drawing.Point(518, 133);
			this.LblC.Name = "LblC";
			this.LblC.Size = new System.Drawing.Size(18, 18);
			this.LblC.TabIndex = 2;
			this.LblC.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "C Parti:";
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(102, 104);
			this.progressBar2.Maximum = 200;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(410, 23);
			this.progressBar2.TabIndex = 3;
			// 
			// LblB
			// 
			this.LblB.AutoSize = true;
			this.LblB.Location = new System.Drawing.Point(518, 104);
			this.LblB.Name = "LblB";
			this.LblB.Size = new System.Drawing.Size(18, 18);
			this.LblB.TabIndex = 2;
			this.LblB.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "B Parti:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(102, 75);
			this.progressBar1.Maximum = 200;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(410, 23);
			this.progressBar1.TabIndex = 3;
			// 
			// LblA
			// 
			this.LblA.AutoSize = true;
			this.LblA.Location = new System.Drawing.Point(518, 75);
			this.LblA.Name = "LblA";
			this.LblA.Size = new System.Drawing.Size(18, 18);
			this.LblA.TabIndex = 2;
			this.LblA.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "A Parti:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(102, 23);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(239, 26);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "İlçe Seçimi:";
			// 
			// FrmGrafikler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(864, 638);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmGrafikler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İstatistik";
			this.Load += new System.EventHandler(this.FrmGrafikler_Load);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.Label LblE;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.Label LblD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.Label LblC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.Label LblB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblA;
	}
}