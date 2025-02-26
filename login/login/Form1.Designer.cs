namespace login
{
    partial class FormLogin
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
            TextBoxUsuario = new TextBox();
            TextBoxSenha = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            LabelResultado = new Label();
            SuspendLayout();
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(102, 50);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(140, 23);
            TextBoxUsuario.TabIndex = 0;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(102, 93);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(140, 23);
            TextBoxSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(31, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Login\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkRed;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(31, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(65, 16);
            textBox4.TabIndex = 4;
            textBox4.Text = "Usuario";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkRed;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(31, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(65, 16);
            textBox5.TabIndex = 5;
            textBox5.Text = "Senha";
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.BackColor = SystemColors.ButtonHighlight;
            LabelResultado.Location = new Point(351, 93);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(0, 15);
            LabelResultado.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 319);
            Controls.Add(LabelResultado);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(TextBoxSenha);
            Controls.Add(TextBoxUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxUsuario;
        private TextBox TextBoxSenha;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label LabelResultado;
    }
}
