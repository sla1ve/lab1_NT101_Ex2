namespace Lab01_ATM
{
    partial class CaeserCipherBruteForce
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
            listBox1 = new ListBox();
            input = new Label();
            output = new Label();
            textBox1 = new TextBox();
            bruteForceDecrypt = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(716, 59);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(554, 564);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // input
            // 
            input.AutoSize = true;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(216, 9);
            input.Name = "input";
            input.Size = new Size(58, 28);
            input.TabIndex = 1;
            input.Text = "Input";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(979, 9);
            output.Name = "output";
            output.Size = new Size(75, 28);
            output.TabIndex = 2;
            output.Text = "Output";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 59);
            textBox1.Multiline = true;
            textBox1.AutoSize = false;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(519, 564);
            textBox1.TabIndex = 3;
            // 
            // bruteForceDecrypt
            // 
            bruteForceDecrypt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            bruteForceDecrypt.Location = new Point(537, 292);
            bruteForceDecrypt.Name = "bruteForceDecrypt";
            bruteForceDecrypt.Size = new Size(173, 78);
            bruteForceDecrypt.TabIndex = 4;
            bruteForceDecrypt.Text = "Brute Force Decrypt";
            bruteForceDecrypt.UseVisualStyleBackColor = true;
            bruteForceDecrypt.Click += bruteForceDecrypt_Click;
            // 
            // CaeserCipherBruteForce
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(bruteForceDecrypt);
            Controls.Add(textBox1);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(listBox1);
            Name = "CaeserCipherBruteForce";
            Text = "CaeserCipherBruteForce";
            Load += CaeserCipherBruteForce_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label input;
        private Label output;
        private TextBox textBox1;
        private Button bruteForceDecrypt;
    }
}