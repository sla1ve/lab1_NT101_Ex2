namespace Lab01_ATM
{
    partial class CaesarCipherDecrypt
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
            input = new Label();
            output = new Label();
            decrypt = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            Shift = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.AutoSize = true;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(153, 26);
            input.Name = "input";
            input.Size = new Size(58, 28);
            input.TabIndex = 0;
            input.Text = "Input";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(597, 9);
            output.Name = "output";
            output.Size = new Size(75, 28);
            output.TabIndex = 1;
            output.Text = "Output";
            // 
            // decrypt
            // 
            decrypt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            decrypt.Location = new Point(346, 245);
            decrypt.Name = "decrypt";
            decrypt.Size = new Size(113, 58);
            decrypt.TabIndex = 2;
            decrypt.Text = "Decrypt";
            decrypt.UseVisualStyleBackColor = true;
            decrypt.Click += decrypt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 66);
            textBox1.Multiline = true;
            textBox1.AutoSize = false;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 372);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(465, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(323, 387);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 27);
            textBox2.TabIndex = 5;
            // 
            // Shift
            // 
            Shift.AutoSize = true;
            Shift.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Shift.Location = new Point(373, 125);
            Shift.Name = "Shift";
            Shift.Size = new Size(52, 28);
            Shift.TabIndex = 6;
            Shift.Text = "Shift";
            // 
            // CaesarCipherDecrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Shift);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(decrypt);
            Controls.Add(output);
            Controls.Add(input);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CaesarCipherDecrypt";
            Text = "CaesarCipherDecrypt";
            Load += CaesarCipherDecrypt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label input;
        private Label output;
        private Button decrypt;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label Shift;
    }
}