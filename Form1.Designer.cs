namespace Md5stringEncode
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
            this.copyButton = new System.Windows.Forms.Button();
            this.stringText = new System.Windows.Forms.TextBox();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compareText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compResLabel = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileRadio = new System.Windows.Forms.RadioButton();
            this.stringRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.copyButton.Location = new System.Drawing.Point(326, 61);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(64, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stringText
            // 
            this.stringText.Location = new System.Drawing.Point(72, 12);
            this.stringText.Name = "stringText";
            this.stringText.Size = new System.Drawing.Size(318, 20);
            this.stringText.TabIndex = 1;
            this.stringText.TextChanged += new System.EventHandler(this.stringText_TextChanged);
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(72, 64);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.ReadOnly = true;
            this.encryptedText.Size = new System.Drawing.Size(248, 20);
            this.encryptedText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash";
            // 
            // compareText
            // 
            this.compareText.Location = new System.Drawing.Point(72, 91);
            this.compareText.Name = "compareText";
            this.compareText.Size = new System.Drawing.Size(248, 20);
            this.compareText.TabIndex = 4;
            this.compareText.TextChanged += new System.EventHandler(this.compareText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compare";
            // 
            // compResLabel
            // 
            this.compResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.compResLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.compResLabel.Location = new System.Drawing.Point(322, 91);
            this.compResLabel.Name = "compResLabel";
            this.compResLabel.Size = new System.Drawing.Size(77, 23);
            this.compResLabel.TabIndex = 6;
            this.compResLabel.Text = "Unequal";
            this.compResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileText
            // 
            this.fileText.BackColor = System.Drawing.SystemColors.Window;
            this.fileText.Location = new System.Drawing.Point(72, 38);
            this.fileText.Name = "fileText";
            this.fileText.ReadOnly = true;
            this.fileText.Size = new System.Drawing.Size(280, 20);
            this.fileText.TabIndex = 1;
            this.fileText.TextChanged += new System.EventHandler(this.fileText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.browseButton.Location = new System.Drawing.Point(358, 38);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 20);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileRadio
            // 
            this.fileRadio.AutoSize = true;
            this.fileRadio.Location = new System.Drawing.Point(52, 41);
            this.fileRadio.Name = "fileRadio";
            this.fileRadio.Size = new System.Drawing.Size(14, 13);
            this.fileRadio.TabIndex = 8;
            this.fileRadio.UseVisualStyleBackColor = true;
            this.fileRadio.CheckedChanged += new System.EventHandler(this.fileRadio_CheckedChanged);
            // 
            // stringRadio
            // 
            this.stringRadio.AutoSize = true;
            this.stringRadio.Checked = true;
            this.stringRadio.Location = new System.Drawing.Point(52, 15);
            this.stringRadio.Name = "stringRadio";
            this.stringRadio.Size = new System.Drawing.Size(14, 13);
            this.stringRadio.TabIndex = 8;
            this.stringRadio.TabStop = true;
            this.stringRadio.UseVisualStyleBackColor = true;
            this.stringRadio.CheckedChanged += new System.EventHandler(this.stringRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 120);
            this.Controls.Add(this.stringRadio);
            this.Controls.Add(this.fileRadio);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.compResLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compareText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.stringText);
            this.Controls.Add(this.copyButton);
            this.Name = "Form1";
            this.Text = "MD5 Encode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox stringText;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox compareText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label compResLabel;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.RadioButton stringRadio;
    }
}

