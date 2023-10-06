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
    public partial class CaeserCipherBruteForce : Form
    {
        public CaeserCipherBruteForce()
        {
            InitializeComponent();
        }

        private string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string Lowercase = "abcdefghijklmnopqrstuvwxyz";

        private string CaesarCipherDecrypt(string ciphertext, int shift)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bruteForceDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = textBox1.Text;

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Please fill ciphertext.");
                return;
            }

            for (int shift = 0; shift < 26; shift++)
            {
                string decryptedText = CaesarCipherDecrypt(ciphertext, shift);
                listBox1.Items.Add($"Shift {shift}: {decryptedText}");
            }
        }

        private void CaeserCipherBruteForce_Load(object sender, EventArgs e)
        {

        }
    }
}
