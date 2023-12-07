namespace TI1
{
    partial class Form1
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
            this.FirstFile = new System.Windows.Forms.Button();
            this.FileSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.StartEnc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.KeyFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxKey = new System.Windows.Forms.RichTextBox();
            this.TextBoxFirstText = new System.Windows.Forms.RichTextBox();
            this.TextBoxNewText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstFile
            // 
            this.FirstFile.Location = new System.Drawing.Point(25, 47);
            this.FirstFile.Name = "FirstFile";
            this.FirstFile.Size = new System.Drawing.Size(121, 29);
            this.FirstFile.TabIndex = 1;
            this.FirstFile.Text = "Choose File";
            this.FirstFile.UseVisualStyleBackColor = true;
            this.FirstFile.Click += new System.EventHandler(this.FirstFile_Click);
            // 
            // FileSave
            // 
            this.FileSave.Location = new System.Drawing.Point(152, 47);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(121, 29);
            this.FileSave.TabIndex = 2;
            this.FileSave.Text = "Save into File";
            this.FileSave.UseVisualStyleBackColor = true;
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // StartEnc
            // 
            this.StartEnc.Location = new System.Drawing.Point(25, 402);
            this.StartEnc.Name = "StartEnc";
            this.StartEnc.Size = new System.Drawing.Size(121, 29);
            this.StartEnc.TabIndex = 5;
            this.StartEnc.Text = "Start";
            this.StartEnc.UseVisualStyleBackColor = true;
            this.StartEnc.Click += new System.EventHandler(this.StartEnc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key:";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog1";
            // 
            // KeyFile
            // 
            this.KeyFile.Location = new System.Drawing.Point(265, 33);
            this.KeyFile.Name = "KeyFile";
            this.KeyFile.Size = new System.Drawing.Size(121, 29);
            this.KeyFile.TabIndex = 10;
            this.KeyFile.Text = "Key File";
            this.KeyFile.UseVisualStyleBackColor = true;
            this.KeyFile.Click += new System.EventHandler(this.KeyFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "File for Encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(154, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "File fot save:";
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Location = new System.Drawing.Point(25, 134);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxKey.Size = new System.Drawing.Size(227, 262);
            this.TextBoxKey.TabIndex = 13;
            this.TextBoxKey.Text = "";
            // 
            // TextBoxFirstText
            // 
            this.TextBoxFirstText.Location = new System.Drawing.Point(267, 134);
            this.TextBoxFirstText.Name = "TextBoxFirstText";
            this.TextBoxFirstText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxFirstText.Size = new System.Drawing.Size(227, 262);
            this.TextBoxFirstText.TabIndex = 14;
            this.TextBoxFirstText.Text = "";
            // 
            // TextBoxNewText
            // 
            this.TextBoxNewText.Location = new System.Drawing.Point(511, 134);
            this.TextBoxNewText.Name = "TextBoxNewText";
            this.TextBoxNewText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxNewText.Size = new System.Drawing.Size(227, 262);
            this.TextBoxNewText.TabIndex = 15;
            this.TextBoxNewText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Text From File:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "New Text:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.KeyFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 84);
            this.panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxNewText);
            this.Controls.Add(this.TextBoxFirstText);
            this.Controls.Add(this.TextBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartEnc);
            this.Controls.Add(this.FileSave);
            this.Controls.Add(this.FirstFile);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Encryption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FirstFile;
        private System.Windows.Forms.Button FileSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button StartEnc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button KeyFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextBoxKey;
        private System.Windows.Forms.RichTextBox TextBoxFirstText;
        private System.Windows.Forms.RichTextBox TextBoxNewText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

