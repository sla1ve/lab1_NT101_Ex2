namespace Lab01_ATM
{
    partial class CaesarCipherEncrypt
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            Encrypt = new Button();
            input = new Label();
            output = new Label();
            bindingSource1 = new BindingSource(components);
            shift = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Multiline = true;
            textBox1.AutoSize = false;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 394);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(461, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 394);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Encrypt
            // 
            Encrypt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Encrypt.Location = new Point(361, 274);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(94, 58);
            Encrypt.TabIndex = 2;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            Encrypt.Click += Encrypt_Click;
            // 
            // input
            // 
            input.AutoSize = true;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(155, 9);
            input.Name = "input";
            input.Size = new Size(58, 28);
            input.TabIndex = 3;
            input.Text = "Input";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(591, 9);
            output.Name = "output";
            output.Size = new Size(75, 28);
            output.TabIndex = 4;
            output.Text = "Output";
            // 
            // shift
            // 
            shift.AutoSize = true;
            shift.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            shift.Location = new Point(381, 116);
            shift.Name = "shift";
            shift.Size = new Size(52, 28);
            shift.TabIndex = 5;
            shift.Text = "Shift";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(361, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // CaesarCipherEncrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(shift);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(Encrypt);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Name = "CaesarCipherEncrypt";
            Text = "CaesarCipherEncrypt";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button Encrypt;
        private Label input;
        private Label output;
        private BindingSource bindingSource1;
        private Label shift;
        private TextBox textBox2;
    }
}