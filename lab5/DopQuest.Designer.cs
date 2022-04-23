namespace lab5
{
    partial class DopQuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDopQ1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDopQ2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadOtherBut = new System.Windows.Forms.Button();
            this.buttonDopQ2End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в наш магазин, вот наши цены: 1 кг. яблоки - 90 руб., 2 кг. апел" +
    "ьсины - 130 руб. \r\nТакже в ассортименте орехи в следующей фасовке: 0.5 кг. минда" +
    "ль - 500 руб.";
            // 
            // buttonDopQ1
            // 
            this.buttonDopQ1.Location = new System.Drawing.Point(16, 63);
            this.buttonDopQ1.Name = "buttonDopQ1";
            this.buttonDopQ1.Size = new System.Drawing.Size(185, 100);
            this.buttonDopQ1.TabIndex = 1;
            this.buttonDopQ1.Text = "1ДопЗадание";
            this.buttonDopQ1.UseVisualStyleBackColor = true;
            this.buttonDopQ1.Click += new System.EventHandler(this.buttonDopQ1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 420);
            this.listBox1.TabIndex = 2;
            // 
            // buttonDopQ2
            // 
            this.buttonDopQ2.Location = new System.Drawing.Point(663, 63);
            this.buttonDopQ2.Name = "buttonDopQ2";
            this.buttonDopQ2.Size = new System.Drawing.Size(155, 40);
            this.buttonDopQ2.TabIndex = 3;
            this.buttonDopQ2.Text = "2ДопЗадание\r\n(Выгрузить в другое место)\r\n";
            this.buttonDopQ2.UseVisualStyleBackColor = true;
            this.buttonDopQ2.Click += new System.EventHandler(this.buttonDopQ2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(251, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(560, 384);
            this.textBox1.TabIndex = 4;
            // 
            // LoadBut
            // 
            this.LoadBut.Location = new System.Drawing.Point(498, 108);
            this.LoadBut.Name = "LoadBut";
            this.LoadBut.Size = new System.Drawing.Size(159, 28);
            this.LoadBut.TabIndex = 5;
            this.LoadBut.Text = "Загрузить из 2DopQ.txt";
            this.LoadBut.UseVisualStyleBackColor = true;
            this.LoadBut.Click += new System.EventHandler(this.LoadBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(475, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текст из файла";
            // 
            // LoadOtherBut
            // 
            this.LoadOtherBut.Location = new System.Drawing.Point(498, 63);
            this.LoadOtherBut.Name = "LoadOtherBut";
            this.LoadOtherBut.Size = new System.Drawing.Size(159, 28);
            this.LoadOtherBut.TabIndex = 9;
            this.LoadOtherBut.Text = "Загрузить из другого файла";
            this.LoadOtherBut.UseVisualStyleBackColor = true;
            this.LoadOtherBut.Click += new System.EventHandler(this.LoadOtherBut_Click);
            // 
            // buttonDopQ2End
            // 
            this.buttonDopQ2End.Location = new System.Drawing.Point(663, 108);
            this.buttonDopQ2End.Name = "buttonDopQ2End";
            this.buttonDopQ2End.Size = new System.Drawing.Size(155, 40);
            this.buttonDopQ2End.TabIndex = 10;
            this.buttonDopQ2End.Text = "2ДопЗадание\r\n(Выгрузить в 2DopQEnd)";
            this.buttonDopQ2End.UseVisualStyleBackColor = true;
            this.buttonDopQ2End.Click += new System.EventHandler(this.buttonDopQ2End_Click);
            // 
            // DopQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 610);
            this.Controls.Add(this.buttonDopQ2End);
            this.Controls.Add(this.LoadOtherBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadBut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDopQ2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDopQ1);
            this.Controls.Add(this.label1);
            this.Name = "DopQuest";
            this.Text = "DopQuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDopQ1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDopQ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadOtherBut;
        private System.Windows.Forms.Button buttonDopQ2End;
    }
}