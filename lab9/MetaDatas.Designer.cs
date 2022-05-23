namespace lab9
{
    partial class MetaDatas
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
            this.button1 = new System.Windows.Forms.Button();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MetaDataInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(12, 51);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(238, 641);
            this.ListFiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файлы";
            // 
            // MetaDataInfo
            // 
            this.MetaDataInfo.Location = new System.Drawing.Point(286, 51);
            this.MetaDataInfo.Multiline = true;
            this.MetaDataInfo.Name = "MetaDataInfo";
            this.MetaDataInfo.Size = new System.Drawing.Size(282, 126);
            this.MetaDataInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(377, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "МетаДанные";
            // 
            // MetaDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MetaDataInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListFiles);
            this.Controls.Add(this.button1);
            this.Name = "MetaDatas";
            this.Text = "Поиск по метаданным";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MetaDataInfo;
        private System.Windows.Forms.Label label2;
    }
}