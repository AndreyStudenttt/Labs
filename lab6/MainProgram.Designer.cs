namespace lab6
{
    partial class MainProgram
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBEqua = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBc = new System.Windows.Forms.TextBox();
            this.DrawFunBut = new System.Windows.Forms.Button();
            this.TBb = new System.Windows.Forms.TextBox();
            this.TBa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBSumm = new System.Windows.Forms.TextBox();
            this.CBIntegr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TBN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CBIntegr);
            this.panel1.Controls.Add(this.TBSumm);
            this.panel1.Controls.Add(this.CBEqua);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBRight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBLeft);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBc);
            this.panel1.Controls.Add(this.DrawFunBut);
            this.panel1.Controls.Add(this.TBb);
            this.panel1.Controls.Add(this.TBa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 604);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CBEqua
            // 
            this.CBEqua.FormattingEnabled = true;
            this.CBEqua.Location = new System.Drawing.Point(3, 3);
            this.CBEqua.Name = "CBEqua";
            this.CBEqua.Size = new System.Drawing.Size(190, 21);
            this.CBEqua.TabIndex = 13;
            this.CBEqua.SelectedIndexChanged += new System.EventHandler(this.CBEqua_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "right";
            // 
            // TBRight
            // 
            this.TBRight.Location = new System.Drawing.Point(40, 133);
            this.TBRight.Name = "TBRight";
            this.TBRight.Size = new System.Drawing.Size(100, 20);
            this.TBRight.TabIndex = 11;
            this.TBRight.TextChanged += new System.EventHandler(this.TBa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "left";
            // 
            // TBLeft
            // 
            this.TBLeft.Location = new System.Drawing.Point(40, 107);
            this.TBLeft.Name = "TBLeft";
            this.TBLeft.Size = new System.Drawing.Size(100, 20);
            this.TBLeft.TabIndex = 9;
            this.TBLeft.TextChanged += new System.EventHandler(this.TBa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "c";
            // 
            // TBc
            // 
            this.TBc.Location = new System.Drawing.Point(40, 80);
            this.TBc.Name = "TBc";
            this.TBc.Size = new System.Drawing.Size(100, 20);
            this.TBc.TabIndex = 7;
            this.TBc.TextChanged += new System.EventHandler(this.TBa_TextChanged);
            // 
            // DrawFunBut
            // 
            this.DrawFunBut.Location = new System.Drawing.Point(14, 159);
            this.DrawFunBut.Name = "DrawFunBut";
            this.DrawFunBut.Size = new System.Drawing.Size(86, 23);
            this.DrawFunBut.TabIndex = 4;
            this.DrawFunBut.Text = "Нарисовать";
            this.DrawFunBut.UseVisualStyleBackColor = true;
            this.DrawFunBut.Click += new System.EventHandler(this.DrawFunBut_Click);
            // 
            // TBb
            // 
            this.TBb.Location = new System.Drawing.Point(40, 54);
            this.TBb.Name = "TBb";
            this.TBb.Size = new System.Drawing.Size(100, 20);
            this.TBb.TabIndex = 3;
            this.TBb.TextChanged += new System.EventHandler(this.TBa_TextChanged);
            // 
            // TBa
            // 
            this.TBa.Location = new System.Drawing.Point(40, 28);
            this.TBa.Name = "TBa";
            this.TBa.Size = new System.Drawing.Size(100, 20);
            this.TBa.TabIndex = 2;
            this.TBa.TextChanged += new System.EventHandler(this.TBa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(224, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 604);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.MinimumSize = new System.Drawing.Size(564, 587);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(910, 604);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // TBSumm
            // 
            this.TBSumm.Location = new System.Drawing.Point(71, 239);
            this.TBSumm.Name = "TBSumm";
            this.TBSumm.ReadOnly = true;
            this.TBSumm.Size = new System.Drawing.Size(119, 20);
            this.TBSumm.TabIndex = 14;
            // 
            // CBIntegr
            // 
            this.CBIntegr.FormattingEnabled = true;
            this.CBIntegr.Location = new System.Drawing.Point(0, 188);
            this.CBIntegr.Name = "CBIntegr";
            this.CBIntegr.Size = new System.Drawing.Size(206, 21);
            this.CBIntegr.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Площадь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Кол. Разбиения";
            // 
            // TBN
            // 
            this.TBN.Location = new System.Drawing.Point(104, 215);
            this.TBN.Name = "TBN";
            this.TBN.Size = new System.Drawing.Size(86, 20);
            this.TBN.TabIndex = 17;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(676, 623);
            this.Name = "MainProgram";
            this.Text = "Интегрирование";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TBb;
        private System.Windows.Forms.TextBox TBa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawFunBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBLeft;
        private System.Windows.Forms.ComboBox CBEqua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBIntegr;
        private System.Windows.Forms.TextBox TBSumm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBN;
    }
}

