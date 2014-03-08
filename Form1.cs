using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Md5stringEncode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encryptedText.Text = Encryptor.MD5Hash(stringText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(encryptedText.Text);
            string text = copyButton.Text;
            Color color = copyButton.BackColor;
            copyButton.Enabled = false;
            copyButton.Text = "Copied";
            copyButton.BackColor = Color.LightGreen;
            Timer timer = new Timer();
            timer.Tick += delegate
            {
                timer.Stop();
                copyButton.Enabled = true;
                copyButton.Text = text;
                copyButton.BackColor = color;
            };
            timer.Interval = 200;
            timer.Start();
        }

        private void stringText_TextChanged(object sender, EventArgs e)
        {
            stringRadio.Checked = true;
            encryptionString();
        }

        private void encryptionString()
        {
            encryptedText.Text = Encryptor.MD5Hash(stringText.Text);
            compare();
        }
        private void encryptionFile()
        {
            try
            {
                encryptedText.Text = Encryptor.GetMD5HashFromFile(fileText.Text);
            }
            catch { }
            compare();
        }
        private void compare()
        {
            bool equa = encryptedText.Text == compareText.Text;
            compResLabel.Text = equa ? "Equal" : "Unequal";
            compResLabel.ForeColor = equa ? Color.Green : Color.Firebrick;
        }

        private void compareText_TextChanged(object sender, EventArgs e)
        {
            compare();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            chooseFile();
        }
        private void chooseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose file";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileText.Text = dialog.FileName;
            }
        }

        private void fileText_TextChanged(object sender, EventArgs e)
        {
            fileRadio.Checked = true;
            encryptionFile();
        }

        private void stringRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (stringRadio.Checked)
            {
                encryptionString();
            }
        }

        private void fileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fileRadio.Checked)
            {
                encryptionFile();
            }
        }
    }
}
