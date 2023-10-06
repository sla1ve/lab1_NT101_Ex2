namespace Lab01_ATM
{
    public partial class CaeserCipher : Form
    {
        public CaeserCipher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CaesarCipherEncrypt_Click(object sender, EventArgs e)
        {
            CaesarCipherEncrypt form2 = new CaesarCipherEncrypt();
            form2.Show();
        }

        private void CaesarCipherDecrypt_Click(object sender, EventArgs e)
        {
            CaesarCipherDecrypt form3 = new CaesarCipherDecrypt();
            form3.Show();
        }

        private void caesarCipherBruceForce_Click(object sender, EventArgs e)
        {
            CaeserCipherBruteForce form4 = new CaeserCipherBruteForce();
            form4.Show();
        }
    }
}