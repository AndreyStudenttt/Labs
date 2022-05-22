namespace lab9
{
    partial class TBWater
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
            this.TBInfo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButWMM = new System.Windows.Forms.Button();
            this.ButPicWater = new System.Windows.Forms.Button();
            this.ButPathAutoPic = new System.Windows.Forms.Button();
            this.ButPathPic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPathPic = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBPathWater = new System.Windows.Forms.TextBox();
            this.ButAutoPathWater = new System.Windows.Forms.Button();
            this.ButPathWater = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButSave = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBPath
            // 
            this.TBPath.Location = new System.Drawing.Point(97, 6);
            this.TBPath.Name = "TBPath";
            this.TBPath.ReadOnly = true;
            this.TBPath.Size = new System.Drawing.Size(391, 20);
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
            this.ButPath.Location = new System.Drawing.Point(494, 4);
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
            this.ButDelDub.Location = new System.Drawing.Point(262, 39);
            this.ButDelDub.Name = "ButDelDub";
            this.ButDelDub.Size = new System.Drawing.Size(128, 23);
            this.ButDelDub.TabIndex = 3;
            this.ButDelDub.Text = "Удаление дубликатов";
            this.ButDelDub.UseVisualStyleBackColor = true;
            this.ButDelDub.Click += new System.EventHandler(this.ButDelDub_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(697, 550);
            this.listBox1.TabIndex = 4;
            // 
            // AutoButPath
            // 
            this.AutoButPath.AutoSize = true;
            this.AutoButPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoButPath.Location = new System.Drawing.Point(526, 4);
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
            this.ButSortDay.Location = new System.Drawing.Point(482, 39);
            this.ButSortDay.Name = "ButSortDay";
            this.ButSortDay.Size = new System.Drawing.Size(77, 23);
            this.ButSortDay.TabIndex = 6;
            this.ButSortDay.Text = "Сортировка";
            this.ButSortDay.UseVisualStyleBackColor = true;
            this.ButSortDay.Click += new System.EventHandler(this.ButSortDay_Click);
            // 
            // TBInfo
            // 
            this.TBInfo.Location = new System.Drawing.Point(558, 4);
            this.TBInfo.Multiline = true;
            this.TBInfo.Name = "TBInfo";
            this.TBInfo.Size = new System.Drawing.Size(154, 29);
            this.TBInfo.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // ButWMM
            // 
            this.ButWMM.AutoSize = true;
            this.ButWMM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButWMM.Location = new System.Drawing.Point(563, 39);
            this.ButWMM.Name = "ButWMM";
            this.ButWMM.Size = new System.Drawing.Size(149, 23);
            this.ButWMM.TabIndex = 9;
            this.ButWMM.Text = "Создание водяного знака";
            this.ButWMM.UseVisualStyleBackColor = true;
            this.ButWMM.Click += new System.EventHandler(this.ButWMM_Click);
            // 
            // ButPicWater
            // 
            this.ButPicWater.AutoSize = true;
            this.ButPicWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButPicWater.Location = new System.Drawing.Point(8, 83);
            this.ButPicWater.Name = "ButPicWater";
            this.ButPicWater.Size = new System.Drawing.Size(203, 23);
            this.ButPicWater.TabIndex = 10;
            this.ButPicWater.Text = "Сохранить Итог в папку с картинкой";
            this.ButPicWater.UseVisualStyleBackColor = true;
            this.ButPicWater.Click += new System.EventHandler(this.ButPicWater_Click);
            // 
            // ButPathAutoPic
            // 
            this.ButPathAutoPic.AutoSize = true;
            this.ButPathAutoPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButPathAutoPic.Location = new System.Drawing.Point(462, 11);
            this.ButPathAutoPic.Name = "ButPathAutoPic";
            this.ButPathAutoPic.Size = new System.Drawing.Size(26, 23);
            this.ButPathAutoPic.TabIndex = 14;
            this.ButPathAutoPic.Text = "...";
            this.ButPathAutoPic.UseVisualStyleBackColor = true;
            this.ButPathAutoPic.Click += new System.EventHandler(this.ButPathAutoPic_Click);
            // 
            // ButPathPic
            // 
            this.ButPathPic.AutoSize = true;
            this.ButPathPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButPathPic.Location = new System.Drawing.Point(430, 12);
            this.ButPathPic.Name = "ButPathPic";
            this.ButPathPic.Size = new System.Drawing.Size(26, 23);
            this.ButPathPic.TabIndex = 13;
            this.ButPathPic.Text = "...";
            this.ButPathPic.UseVisualStyleBackColor = true;
            this.ButPathPic.Click += new System.EventHandler(this.ButPathPic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Путь до картинки";
            // 
            // TBPathPic
            // 
            this.TBPathPic.Location = new System.Drawing.Point(112, 15);
            this.TBPathPic.Name = "TBPathPic";
            this.TBPathPic.ReadOnly = true;
            this.TBPathPic.Size = new System.Drawing.Size(312, 20);
            this.TBPathPic.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButSave);
            this.panel1.Controls.Add(this.TBPathWater);
            this.panel1.Controls.Add(this.ButAutoPathWater);
            this.panel1.Controls.Add(this.ButPathWater);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBPathPic);
            this.panel1.Controls.Add(this.ButPathAutoPic);
            this.panel1.Controls.Add(this.ButPicWater);
            this.panel1.Controls.Add(this.ButPathPic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(718, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 612);
            this.panel1.TabIndex = 15;
            // 
            // TBPathWater
            // 
            this.TBPathWater.Location = new System.Drawing.Point(112, 44);
            this.TBPathWater.Name = "TBPathWater";
            this.TBPathWater.ReadOnly = true;
            this.TBPathWater.Size = new System.Drawing.Size(312, 20);
            this.TBPathWater.TabIndex = 15;
            // 
            // ButAutoPathWater
            // 
            this.ButAutoPathWater.AutoSize = true;
            this.ButAutoPathWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButAutoPathWater.Location = new System.Drawing.Point(462, 40);
            this.ButAutoPathWater.Name = "ButAutoPathWater";
            this.ButAutoPathWater.Size = new System.Drawing.Size(26, 23);
            this.ButAutoPathWater.TabIndex = 18;
            this.ButAutoPathWater.Text = "...";
            this.ButAutoPathWater.UseVisualStyleBackColor = true;
            this.ButAutoPathWater.Click += new System.EventHandler(this.ButAutoPathWater_Click);
            // 
            // ButPathWater
            // 
            this.ButPathWater.AutoSize = true;
            this.ButPathWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButPathWater.Location = new System.Drawing.Point(430, 41);
            this.ButPathWater.Name = "ButPathWater";
            this.ButPathWater.Size = new System.Drawing.Size(26, 23);
            this.ButPathWater.TabIndex = 17;
            this.ButPathWater.Text = "...";
            this.ButPathWater.UseVisualStyleBackColor = true;
            this.ButPathWater.Click += new System.EventHandler(this.ButPathWater_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Путь до Wotermark";
            // 
            // ButSave
            // 
            this.ButSave.AutoSize = true;
            this.ButSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSave.Location = new System.Drawing.Point(217, 83);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(174, 23);
            this.ButSave.TabIndex = 19;
            this.ButSave.Text = "Сохранить итог в другую папку";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // TBWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 633);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButWMM);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TBInfo);
            this.Controls.Add(this.ButSortDay);
            this.Controls.Add(this.AutoButPath);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButDelDub);
            this.Controls.Add(this.ButPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TBWater";
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox TBInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButWMM;
        private System.Windows.Forms.Button ButPicWater;
        private System.Windows.Forms.Button ButPathAutoPic;
        private System.Windows.Forms.Button ButPathPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPathPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBPathWater;
        private System.Windows.Forms.Button ButAutoPathWater;
        private System.Windows.Forms.Button ButPathWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

