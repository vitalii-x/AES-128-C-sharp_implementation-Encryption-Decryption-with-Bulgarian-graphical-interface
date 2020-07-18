namespace AES_forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryptb = new System.Windows.Forms.Button();
            this.decryptb = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.operationStatus = new System.Windows.Forms.Label();
            this.modeFb = new System.Windows.Forms.Button();
            this.modePb = new System.Windows.Forms.Button();
            this.decryptedLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.decryptTo = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyBoxf = new System.Windows.Forms.TextBox();
            this.labelKf = new System.Windows.Forms.Label();
            this.encryptbf = new System.Windows.Forms.Button();
            this.fileKeyCount = new System.Windows.Forms.TextBox();
            this.textKeyCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptb
            // 
            this.encryptb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.encryptb.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.encryptb.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.encryptb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.encryptb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptb.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.encryptb.ForeColor = System.Drawing.Color.White;
            this.encryptb.Location = new System.Drawing.Point(583, 142);
            this.encryptb.Name = "encryptb";
            this.encryptb.Size = new System.Drawing.Size(176, 48);
            this.encryptb.TabIndex = 0;
            this.encryptb.Text = "Криптиране";
            this.encryptb.UseVisualStyleBackColor = false;
            this.encryptb.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decryptb
            // 
            this.decryptb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.decryptb.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.decryptb.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.decryptb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.decryptb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptb.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.decryptb.ForeColor = System.Drawing.Color.White;
            this.decryptb.Location = new System.Drawing.Point(583, 237);
            this.decryptb.Name = "decryptb";
            this.decryptb.Size = new System.Drawing.Size(176, 48);
            this.decryptb.TabIndex = 1;
            this.decryptb.Text = "Декриптиране";
            this.decryptb.UseVisualStyleBackColor = false;
            this.decryptb.Click += new System.EventHandler(this.decryptb_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.buttonE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonE.FlatAppearance.BorderSize = 0;
            this.buttonE.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.buttonE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonE.ForeColor = System.Drawing.Color.White;
            this.buttonE.Location = new System.Drawing.Point(26, 133);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(256, 40);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "Изберете файл";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.White;
            this.fileLabel.Location = new System.Drawing.Point(46, 194);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(212, 23);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "Път към текущия файл:";
            this.fileLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Italic);
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(85, 224);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(135, 19);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "файла не е избран";
            // 
            // operationStatus
            // 
            this.operationStatus.AutoSize = true;
            this.operationStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.operationStatus.ForeColor = System.Drawing.Color.White;
            this.operationStatus.Location = new System.Drawing.Point(22, 411);
            this.operationStatus.Name = "operationStatus";
            this.operationStatus.Size = new System.Drawing.Size(69, 21);
            this.operationStatus.TabIndex = 8;
            this.operationStatus.Text = "Статус";
            this.operationStatus.Click += new System.EventHandler(this.operationStatus_Click);
            // 
            // modeFb
            // 
            this.modeFb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.modeFb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(16)))));
            this.modeFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeFb.Font = new System.Drawing.Font("Consolas", 18F);
            this.modeFb.ForeColor = System.Drawing.Color.Gainsboro;
            this.modeFb.Location = new System.Drawing.Point(26, 28);
            this.modeFb.Name = "modeFb";
            this.modeFb.Size = new System.Drawing.Size(204, 40);
            this.modeFb.TabIndex = 9;
            this.modeFb.Text = "Работа с файл";
            this.modeFb.UseVisualStyleBackColor = false;
            this.modeFb.Click += new System.EventHandler(this.modeFb_Click);
            // 
            // modePb
            // 
            this.modePb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.modePb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(16)))));
            this.modePb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modePb.Font = new System.Drawing.Font("Consolas", 18F);
            this.modePb.ForeColor = System.Drawing.Color.Gainsboro;
            this.modePb.Location = new System.Drawing.Point(257, 28);
            this.modePb.Name = "modePb";
            this.modePb.Size = new System.Drawing.Size(204, 40);
            this.modePb.TabIndex = 10;
            this.modePb.Text = "Работа с текст";
            this.modePb.UseVisualStyleBackColor = false;
            this.modePb.Click += new System.EventHandler(this.modePb_Click);
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.AutoSize = true;
            this.decryptedLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.decryptedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.decryptedLabel.Location = new System.Drawing.Point(21, 359);
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.Size = new System.Drawing.Size(177, 25);
            this.decryptedLabel.TabIndex = 16;
            this.decryptedLabel.Text = "Декриптиран текст";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(26, 397);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 27);
            this.textBox3.TabIndex = 15;
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cipherLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cipherLabel.Location = new System.Drawing.Point(21, 260);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(375, 25);
            this.cipherLabel.TabIndex = 14;
            this.cipherLabel.Text = "Криптиран текст (значения на байтовете)";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.inputLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inputLabel.Location = new System.Drawing.Point(21, 118);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(262, 25);
            this.inputLabel.TabIndex = 13;
            this.inputLabel.Text = "Въведете текст в тази област";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(26, 295);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 61);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(26, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decryptTo
            // 
            this.decryptTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.decryptTo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.decryptTo.FlatAppearance.BorderSize = 0;
            this.decryptTo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.decryptTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.decryptTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptTo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.decryptTo.ForeColor = System.Drawing.Color.White;
            this.decryptTo.Location = new System.Drawing.Point(583, 237);
            this.decryptTo.Name = "decryptTo";
            this.decryptTo.Size = new System.Drawing.Size(176, 78);
            this.decryptTo.TabIndex = 18;
            this.decryptTo.Text = "Декриптирай във файл";
            this.decryptTo.UseVisualStyleBackColor = false;
            this.decryptTo.Click += new System.EventHandler(this.decryptTo_Click);
            // 
            // keyBox
            // 
            this.keyBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.keyBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.keyBox.Location = new System.Drawing.Point(27, 220);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(256, 27);
            this.keyBox.TabIndex = 19;
            this.keyBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(22, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Въведете ключа в тази област";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // keyBoxf
            // 
            this.keyBoxf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBoxf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyBoxf.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.keyBoxf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.keyBoxf.Location = new System.Drawing.Point(27, 295);
            this.keyBoxf.Name = "keyBoxf";
            this.keyBoxf.Size = new System.Drawing.Size(256, 27);
            this.keyBoxf.TabIndex = 21;
            this.keyBoxf.TextChanged += new System.EventHandler(this.keyBoxf_TextChanged);
            // 
            // labelKf
            // 
            this.labelKf.AutoSize = true;
            this.labelKf.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelKf.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelKf.Location = new System.Drawing.Point(22, 267);
            this.labelKf.Name = "labelKf";
            this.labelKf.Size = new System.Drawing.Size(273, 25);
            this.labelKf.TabIndex = 22;
            this.labelKf.Text = "Въведете ключа в тази област";
            // 
            // encryptbf
            // 
            this.encryptbf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.encryptbf.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.encryptbf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.encryptbf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.encryptbf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptbf.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.encryptbf.ForeColor = System.Drawing.Color.White;
            this.encryptbf.Location = new System.Drawing.Point(583, 142);
            this.encryptbf.Name = "encryptbf";
            this.encryptbf.Size = new System.Drawing.Size(176, 75);
            this.encryptbf.TabIndex = 23;
            this.encryptbf.Text = "Криптиране във файл";
            this.encryptbf.UseVisualStyleBackColor = false;
            this.encryptbf.Click += new System.EventHandler(this.encryptbf_Click);
            // 
            // fileKeyCount
            // 
            this.fileKeyCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fileKeyCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileKeyCount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileKeyCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fileKeyCount.Location = new System.Drawing.Point(289, 295);
            this.fileKeyCount.Name = "fileKeyCount";
            this.fileKeyCount.Size = new System.Drawing.Size(31, 27);
            this.fileKeyCount.TabIndex = 24;
            this.fileKeyCount.AcceptsTabChanged += new System.EventHandler(this.keyBoxf_TextChanged);
            // 
            // textKeyCount
            // 
            this.textKeyCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textKeyCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKeyCount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textKeyCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textKeyCount.Location = new System.Drawing.Point(289, 220);
            this.textKeyCount.Name = "textKeyCount";
            this.textKeyCount.Size = new System.Drawing.Size(31, 27);
            this.textKeyCount.TabIndex = 25;
            this.textKeyCount.AcceptsTabChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textKeyCount);
            this.Controls.Add(this.fileKeyCount);
            this.Controls.Add(this.encryptbf);
            this.Controls.Add(this.labelKf);
            this.Controls.Add(this.keyBoxf);
            this.Controls.Add(this.modePb);
            this.Controls.Add(this.modeFb);
            this.Controls.Add(this.decryptb);
            this.Controls.Add(this.encryptb);
            this.Controls.Add(this.operationStatus);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.decryptTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AES-128 Encryption and Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptb;
        private System.Windows.Forms.Button decryptb;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label operationStatus;
        private System.Windows.Forms.Button modeFb;
        private System.Windows.Forms.Button modePb;
        private System.Windows.Forms.Label decryptedLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button decryptTo;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyBoxf;
        private System.Windows.Forms.Label labelKf;
        private System.Windows.Forms.Button encryptbf;
        private System.Windows.Forms.TextBox fileKeyCount;
        private System.Windows.Forms.TextBox textKeyCount;
    }
}

