using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_ATM
{
    public partial class CaesarCipherEncrypt : Form
    {
        public CaesarCipherEncrypt()
        {
            InitializeComponent();
        }

        private string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string Lowercase = "abcdefghijklmnopqrstuvwxyz";

        private string CaesarCipherEncrypt1(string plaintext, int shift)
        {
            string encryptedText = "";

            foreach (char character in plaintext)
            {
                if (char.IsUpper(character))
                {
                    int index = (Uppercase.IndexOf(character) + shift) % 26;
                    encryptedText += Uppercase[index];
                }
                else if (char.IsLower(character))
                {
                    int index = (Lowercase.IndexOf(character) + shift) % 26;
                    encryptedText += Lowercase[index];
                }
                else
                {
                    encryptedText += character;
                }
            }

            return encryptedText;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string plaintext = textBox1.Text;

            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Please fill plaintext.");
                return;
            }

            int shift = int.Parse(textBox2.Text);
            string encryptedText = CaesarCipherEncrypt1(plaintext, shift);
            richTextBox1.Text = encryptedText;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
