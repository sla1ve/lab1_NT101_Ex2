namespace Lab01_ATM
{
    partial class CaeserCipher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CaesarCipherEncrypt = new Button();
            CaesarCipherDecrypt = new Button();
            caesarCipherBruceForce = new Button();
            SuspendLayout();
            // 
            // CaesarCipherEncrypt
            // 
            CaesarCipherEncrypt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CaesarCipherEncrypt.Location = new Point(58, 57);
            CaesarCipherEncrypt.Name = "CaesarCipherEncrypt";
            CaesarCipherEncrypt.Size = new Size(316, 122);
            CaesarCipherEncrypt.TabIndex = 0;
            CaesarCipherEncrypt.Text = "Caesar Cipher Encrypt";
            CaesarCipherEncrypt.UseVisualStyleBackColor = true;
            CaesarCipherEncrypt.Click += CaesarCipherEncrypt_Click;
            // 
            // CaesarCipherDecrypt
            // 
            CaesarCipherDecrypt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CaesarCipherDecrypt.Location = new Point(443, 61);
            CaesarCipherDecrypt.Name = "CaesarCipherDecrypt";
            CaesarCipherDecrypt.Size = new Size(316, 118);
            CaesarCipherDecrypt.TabIndex = 1;
            CaesarCipherDecrypt.Text = "Caesar Cipher Decrypt";
            CaesarCipherDecrypt.UseVisualStyleBackColor = true;
            CaesarCipherDecrypt.Click += CaesarCipherDecrypt_Click;
            // 
            // caesarCipherBruceForce
            // 
            caesarCipherBruceForce.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            caesarCipherBruceForce.Location = new Point(253, 257);
            caesarCipherBruceForce.Name = "caesarCipherBruceForce";
            caesarCipherBruceForce.Size = new Size(316, 123);
            caesarCipherBruceForce.TabIndex = 2;
            caesarCipherBruceForce.Text = "Caesar Cipher Bruce Force";
            caesarCipherBruceForce.UseVisualStyleBackColor = true;
            caesarCipherBruceForce.Click += caesarCipherBruceForce_Click;
            // 
            // CaeserCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caesarCipherBruceForce);
            Controls.Add(CaesarCipherDecrypt);
            Controls.Add(CaesarCipherEncrypt);
            Name = "CaeserCipher";
            Text = "CaeserCipher";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CaesarCipherEncrypt;
        private Button CaesarCipherDecrypt;
        private Button caesarCipherBruceForce;
    }
}