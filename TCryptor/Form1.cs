using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace TCryptor
{
    public partial class Form1 : Form
    {
        private static byte[] ENCRYPTION_KEY = new UnicodeEncoding().GetBytes("h3y_gUyZ");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = new FileStream(outputTextBox.Text + '\\' + inputTextBox.Text.Split('\\')[inputTextBox.Text.Split('\\').Length - 1] + ".dcy", FileMode.Create))
                {
                    byte[] data = Decrypt(File.ReadAllBytes(inputTextBox.Text));
                    fileStream.Write(data, 0, data.Length);
                }
            }
            catch (Exception exc)
            {
                Console.Write(exc);
            }
        }

        private void inputFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            inputTextBox.Text = openFileDialog1.FileName;
        }

        private void outputFileBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            outputTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private byte[] PerformCryptography(ICryptoTransform cryptoTransform, byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return memoryStream.ToArray();
                }
            }
        }

        public byte[] Encrypt(byte[] data)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Padding = PaddingMode.None;
            using (var encryptor = rijndaelManaged.CreateEncryptor(ENCRYPTION_KEY, ENCRYPTION_KEY))
            {
                return PerformCryptography(encryptor, data);
            }
        }

        public byte[] Decrypt(byte[] data)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Padding = PaddingMode.None;
            using (var decryptor = rijndaelManaged.CreateDecryptor(ENCRYPTION_KEY, ENCRYPTION_KEY))
            {
                return PerformCryptography(decryptor, data);
            }
        }

        private void eActivateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = new FileStream(outputTextBox.Text + '\\' + inputTextBox.Text.Split('\\')[inputTextBox.Text.Split('\\').Length - 1].Split('.')[0] + '.' + inputTextBox.Text.Split('\\')[inputTextBox.Text.Split('\\').Length - 1].Split('.')[1], FileMode.Create))
                {
                    byte[] data = Encrypt(File.ReadAllBytes(inputTextBox.Text));
                    fileStream.Write(data, 0, data.Length);
                }
            }
            catch (Exception exc)
            {
                Console.Write(exc);
            }
        }
    }
}
