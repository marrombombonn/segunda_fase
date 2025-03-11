namespace calculadora
{
    partial class Form1
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
            subtracao = new Button();
            adicao = new Button();
            multiplicacao = new Button();
            divisao = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelResultado = new Label();
            novaJanela = new Button();
            SuspendLayout();
            // 
            // subtracao
            // 
            subtracao.Location = new Point(386, 103);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(114, 23);
            subtracao.TabIndex = 1;
            subtracao.Text = "subtração";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += subtracao_Click;
            // 
            // adicao
            // 
            adicao.Location = new Point(386, 74);
            adicao.Name = "adicao";
            adicao.Size = new Size(114, 23);
            adicao.TabIndex = 2;
            adicao.Text = "adição";
            adicao.UseVisualStyleBackColor = true;
            adicao.Click += button1_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(506, 74);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(114, 23);
            multiplicacao.TabIndex = 3;
            multiplicacao.Text = "multiplicação";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(506, 103);
            divisao.Name = "divisao";
            divisao.Size = new Size(114, 23);
            divisao.TabIndex = 4;
            divisao.Text = "divisão";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 7;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(82, 255);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "label1";
            // 
            // novaJanela
            // 
            novaJanela.Location = new Point(628, 367);
            novaJanela.Name = "novaJanela";
            novaJanela.Size = new Size(114, 23);
            novaJanela.TabIndex = 9;
            novaJanela.Text = "Nova Janela";
            novaJanela.UseVisualStyleBackColor = true;
            novaJanela.Click += novaJanela_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(novaJanela);
            Controls.Add(labelResultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(divisao);
            Controls.Add(multiplicacao);
            Controls.Add(adicao);
            Controls.Add(subtracao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button subtracao;
        private Button adicao;
        private Button multiplicacao;
        private Button divisao;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelResultado;
        private Button novaJanela;
    }
}
