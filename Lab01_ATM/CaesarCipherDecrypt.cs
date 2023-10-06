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
    public partial class CaesarCipherDecrypt : Form
    {
        public CaesarCipherDecrypt()
        {
            InitializeComponent();
        }

        private string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string Lowercase = "abcdefghijklmnopqrstuvwxyz";

        private string CaesarCipherDecrypt1(string ciphertext, int shift)
        {
            string decryptedText = "";

            foreach (char character in ciphertext)
            {
                if (char.IsUpper(character))
                {
                    int index = (Uppercase.IndexOf(character) - shift + 26) % 26;
                    decryptedText += Uppercase[index];
                }
                else if (char.IsLower(character))
                {
                    int index = (Lowercase.IndexOf(character) - shift + 26) % 26;
                    decryptedText += Lowercase[index];
                }
                else
                {
                    decryptedText += character;
                }
            }

            return decryptedText;
        }

        private void CaesarCipherDecrypt_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = textBox1.Text;

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Please fill ciphertext.");
                return;
            }

            int shift = int.Parse(textBox2.Text);
            string decryptedText = CaesarCipherDecrypt1(ciphertext, shift);
            richTextBox1.Text = decryptedText;

        }
    }
}
