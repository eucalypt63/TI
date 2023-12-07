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
            this.Key = new System.Windows.Forms.TextBox();
            this.FirstFile = new System.Windows.Forms.Button();
            this.FileSave = new System.Windows.Forms.Button();
            this.TypeEncrypt = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Action = new System.Windows.Forms.ComboBox();
            this.StartEnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IgNum = new System.Windows.Forms.CheckBox();
            this.IgSym = new System.Windows.Forms.CheckBox();
            this.IgLan = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(30, 284);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(139, 26);
            this.Key.TabIndex = 0;
            // 
            // FirstFile
            // 
            this.FirstFile.Location = new System.Drawing.Point(39, 331);
            this.FirstFile.Name = "FirstFile";
            this.FirstFile.Size = new System.Drawing.Size(121, 29);
            this.FirstFile.TabIndex = 1;
            this.FirstFile.Text = "Choose File";
            this.FirstFile.UseVisualStyleBackColor = true;
            this.FirstFile.Click += new System.EventHandler(this.FirstFile_Click);
            // 
            // FileSave
            // 
            this.FileSave.Location = new System.Drawing.Point(192, 331);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(121, 29);
            this.FileSave.TabIndex = 2;
            this.FileSave.Text = "Save into File";
            this.FileSave.UseVisualStyleBackColor = true;
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // TypeEncrypt
            // 
            this.TypeEncrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeEncrypt.FormattingEnabled = true;
            this.TypeEncrypt.Items.AddRange(new object[] {
            "Railway Fence",
            "Vigenere"});
            this.TypeEncrypt.Location = new System.Drawing.Point(30, 73);
            this.TypeEncrypt.Name = "TypeEncrypt";
            this.TypeEncrypt.Size = new System.Drawing.Size(177, 28);
            this.TypeEncrypt.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // Action
            // 
            this.Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Action.FormattingEnabled = true;
            this.Action.Items.AddRange(new object[] {
            "Encrypt",
            "Decipher"});
            this.Action.Location = new System.Drawing.Point(257, 73);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(109, 28);
            this.Action.TabIndex = 4;
            // 
            // StartEnc
            // 
            this.StartEnc.Location = new System.Drawing.Point(339, 331);
            this.StartEnc.Name = "StartEnc";
            this.StartEnc.Size = new System.Drawing.Size(108, 29);
            this.StartEnc.TabIndex = 5;
            this.StartEnc.Text = "Start";
            this.StartEnc.UseVisualStyleBackColor = true;
            this.StartEnc.Click += new System.EventHandler(this.StartEnc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Tipe of Encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Action:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ignor List:";
            // 
            // IgNum
            // 
            this.IgNum.AutoSize = true;
            this.IgNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IgNum.Location = new System.Drawing.Point(3, 3);
            this.IgNum.Name = "IgNum";
            this.IgNum.Size = new System.Drawing.Size(99, 24);
            this.IgNum.TabIndex = 11;
            this.IgNum.Text = "Numbers";
            this.IgNum.UseVisualStyleBackColor = true;
            // 
            // IgSym
            // 
            this.IgSym.AutoSize = true;
            this.IgSym.Location = new System.Drawing.Point(3, 33);
            this.IgSym.Name = "IgSym";
            this.IgSym.Size = new System.Drawing.Size(95, 24);
            this.IgSym.TabIndex = 12;
            this.IgSym.Text = "Symbols";
            this.IgSym.UseVisualStyleBackColor = true;
            // 
            // IgLan
            // 
            this.IgLan.AutoSize = true;
            this.IgLan.Location = new System.Drawing.Point(3, 63);
            this.IgLan.Name = "IgLan";
            this.IgLan.Size = new System.Drawing.Size(162, 24);
            this.IgLan.TabIndex = 13;
            this.IgLan.Text = "Another language";
            this.IgLan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.IgNum);
            this.panel1.Controls.Add(this.IgLan);
            this.panel1.Controls.Add(this.IgSym);
            this.panel1.Location = new System.Drawing.Point(413, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 94);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartEnc);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.TypeEncrypt);
            this.Controls.Add(this.FileSave);
            this.Controls.Add(this.FirstFile);
            this.Controls.Add(this.Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Encryption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Button FirstFile;
        private System.Windows.Forms.Button FileSave;
        private System.Windows.Forms.ComboBox TypeEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button StartEnc;
        private System.Windows.Forms.ComboBox Action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IgNum;
        private System.Windows.Forms.CheckBox IgSym;
        private System.Windows.Forms.CheckBox IgLan;
        private System.Windows.Forms.Panel panel1;
    }
}

