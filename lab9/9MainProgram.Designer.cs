namespace lab9
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
            this.TBPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButPath = new System.Windows.Forms.Button();
            this.ButDelDub = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AutoButPath = new System.Windows.Forms.Button();
            this.ButSortDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPath
            // 
            this.TBPath.Location = new System.Drawing.Point(97, 6);
            this.TBPath.Name = "TBPath";
            this.TBPath.ReadOnly = true;
            this.TBPath.Size = new System.Drawing.Size(419, 20);
            this.TBPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь до папки";
            // 
            // ButPath
            // 
            this.ButPath.AutoSize = true;
            this.ButPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButPath.Location = new System.Drawing.Point(522, 4);
            this.ButPath.Name = "ButPath";
            this.ButPath.Size = new System.Drawing.Size(26, 23);
            this.ButPath.TabIndex = 2;
            this.ButPath.Text = "...";
            this.ButPath.UseVisualStyleBackColor = true;
            this.ButPath.Click += new System.EventHandler(this.ButPath_Click);
            // 
            // ButDelDub
            // 
            this.ButDelDub.AutoSize = true;
            this.ButDelDub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButDelDub.Location = new System.Drawing.Point(15, 39);
            this.ButDelDub.Name = "ButDelDub";
            this.ButDelDub.Size = new System.Drawing.Size(128, 23);
            this.ButDelDub.TabIndex = 3;
            this.ButDelDub.Text = "Удаление дубликатов";
            this.ButDelDub.UseVisualStyleBackColor = true;
            this.ButDelDub.Click += new System.EventHandler(this.ButDelDub_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(697, 485);
            this.listBox1.TabIndex = 4;
            // 
            // AutoButPath
            // 
            this.AutoButPath.AutoSize = true;
            this.AutoButPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoButPath.Location = new System.Drawing.Point(554, 3);
            this.AutoButPath.Name = "AutoButPath";
            this.AutoButPath.Size = new System.Drawing.Size(26, 23);
            this.AutoButPath.TabIndex = 5;
            this.AutoButPath.Text = "...";
            this.AutoButPath.UseVisualStyleBackColor = true;
            this.AutoButPath.Click += new System.EventHandler(this.AutoButPath_Click);
            // 
            // ButSortDay
            // 
            this.ButSortDay.AutoSize = true;
            this.ButSortDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSortDay.Location = new System.Drawing.Point(149, 39);
            this.ButSortDay.Name = "ButSortDay";
            this.ButSortDay.Size = new System.Drawing.Size(121, 23);
            this.ButSortDay.TabIndex = 6;
            this.ButSortDay.Text = "Сортировка по дням";
            this.ButSortDay.UseVisualStyleBackColor = true;
            this.ButSortDay.Click += new System.EventHandler(this.ButSortDay_Click);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 596);
            this.Controls.Add(this.ButSortDay);
            this.Controls.Add(this.AutoButPath);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButDelDub);
            this.Controls.Add(this.ButPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPath);
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButPath;
        private System.Windows.Forms.Button ButDelDub;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AutoButPath;
        private System.Windows.Forms.Button ButSortDay;
    }
}

