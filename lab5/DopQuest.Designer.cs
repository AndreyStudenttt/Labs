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
            this.buttonDopQ1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDopQ2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadOtherBut = new System.Windows.Forms.Button();
            this.buttonDopQ2End = new System.Windows.Forms.Button();
            this.textBoxDopQ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDopQ1
            // 
            this.buttonDopQ1.Location = new System.Drawing.Point(12, 63);
            this.buttonDopQ1.Name = "buttonDopQ1";
            this.buttonDopQ1.Size = new System.Drawing.Size(145, 28);
            this.buttonDopQ1.TabIndex = 1;
            this.buttonDopQ1.Text = "1ДопЗадание";
            this.buttonDopQ1.UseVisualStyleBackColor = true;
            this.buttonDopQ1.Click += new System.EventHandler(this.buttonDopQ1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
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
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
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
            this.label2.Location = new System.Drawing.Point(273, 178);
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
            // textBoxDopQ
            // 
            this.textBoxDopQ.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxDopQ.Location = new System.Drawing.Point(13, 3);
            this.textBoxDopQ.Multiline = true;
            this.textBoxDopQ.Name = "textBoxDopQ";
            this.textBoxDopQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDopQ.Size = new System.Drawing.Size(798, 54);
            this.textBoxDopQ.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Заполнить текстбокс текстом\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(467, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Все .txt файлы (DopQ, 2DopQ, 2DopQEnd) лежать в lab5\\bin\\Debug\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Итог выполнения 1 доп. задания";
            // 
            // DopQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDopQ);
            this.Controls.Add(this.buttonDopQ2End);
            this.Controls.Add(this.LoadOtherBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadBut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDopQ2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDopQ1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DopQuest";
            this.Text = "DopQuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDopQ1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDopQ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadOtherBut;
        private System.Windows.Forms.Button buttonDopQ2End;
        private System.Windows.Forms.TextBox textBoxDopQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}