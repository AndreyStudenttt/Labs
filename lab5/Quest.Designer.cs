namespace lab5
{
    partial class Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quest));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonZad1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonZad2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZad3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZad4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 602);
            this.listBox1.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(440, 22);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonZad1
            // 
            this.buttonZad1.Location = new System.Drawing.Point(440, 80);
            this.buttonZad1.Name = "buttonZad1";
            this.buttonZad1.Size = new System.Drawing.Size(75, 23);
            this.buttonZad1.TabIndex = 2;
            this.buttonZad1.Text = "1 Задание";
            this.buttonZad1.UseVisualStyleBackColor = true;
            this.buttonZad1.Click += new System.EventHandler(this.buttonZad1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Написать регулярное выражение, которые проверят строки \r\nна соответствие: «a», «a" +
    "aaaaa», «a aa a». \r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 598);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonZad2
            // 
            this.buttonZad2.Location = new System.Drawing.Point(440, 140);
            this.buttonZad2.Name = "buttonZad2";
            this.buttonZad2.Size = new System.Drawing.Size(75, 23);
            this.buttonZad2.TabIndex = 6;
            this.buttonZad2.Text = "2 Задание";
            this.buttonZad2.UseVisualStyleBackColor = true;
            this.buttonZad2.Click += new System.EventHandler(this.buttonZad2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Написать регулярное выражение, заставляющее вводить \r\nне менее 5 алфавитно-цифров" +
    "ых символов.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Написать регулярное выражение, которое проверят email\r\nпростого вида (например, t" +
    "est@test.test).";
            // 
            // buttonZad3
            // 
            this.buttonZad3.Location = new System.Drawing.Point(440, 195);
            this.buttonZad3.Name = "buttonZad3";
            this.buttonZad3.Size = new System.Drawing.Size(75, 23);
            this.buttonZad3.TabIndex = 8;
            this.buttonZad3.Text = "3 Задание";
            this.buttonZad3.UseVisualStyleBackColor = true;
            this.buttonZad3.Click += new System.EventHandler(this.buttonZad3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 65);
            this.label4.TabIndex = 11;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // buttonZad4
            // 
            this.buttonZad4.Location = new System.Drawing.Point(440, 250);
            this.buttonZad4.Name = "buttonZad4";
            this.buttonZad4.Size = new System.Drawing.Size(75, 23);
            this.buttonZad4.TabIndex = 10;
            this.buttonZad4.Text = "4 Задание";
            this.buttonZad4.UseVisualStyleBackColor = true;
            this.buttonZad4.Click += new System.EventHandler(this.buttonZad4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Доп задание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZad4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZad3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZad2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZad1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonZad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonZad2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZad3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZad4;
        private System.Windows.Forms.Button button2;
    }
}

