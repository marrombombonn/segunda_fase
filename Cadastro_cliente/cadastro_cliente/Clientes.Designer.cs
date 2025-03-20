namespace cadastro_cliente
{
    partial class Clientes
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
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNomeSocial = new TextBox();
            textBoxEstado = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxNumero = new TextBox();
            comboBoxGenero = new ComboBox();
            comboBoxEtnia = new ComboBox();
            maskedTextBoxDataDeNascimento = new MaskedTextBox();
            maskedTextBoxCep = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            checkBoxSim = new CheckBox();
            checkBoxNão = new CheckBox();
            textBoxMunicipio = new TextBox();
            textBoxBairro = new TextBox();
            textBoxLogradouro = new TextBox();
            labelNome = new Label();
            labelEmail = new Label();
            labelNomeSocial = new Label();
            labelLogradouro = new Label();
            labelMunicipio = new Label();
            labelBairro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            labelEstado = new Label();
            labelGenero = new Label();
            labelEtnia = new Label();
            labelCep = new Label();
            labelDataDeNascimento = new Label();
            labelTelefone = new Label();
            labelEstrangerio = new Label();
            buttonCadastrar = new Button();
            labelRetorno = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 24);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(284, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 67);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(284, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(12, 114);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(284, 23);
            textBoxNomeSocial.TabIndex = 2;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(665, 114);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(100, 23);
            textBoxEstado.TabIndex = 8;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(665, 67);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(100, 23);
            textBoxComplemento.TabIndex = 7;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(665, 24);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 6;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(12, 200);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(284, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(12, 253);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(284, 23);
            comboBoxEtnia.TabIndex = 11;
            // 
            // maskedTextBoxDataDeNascimento
            // 
            maskedTextBoxDataDeNascimento.Location = new Point(377, 253);
            maskedTextBoxDataDeNascimento.Mask = "00/00/0000";
            maskedTextBoxDataDeNascimento.Name = "maskedTextBoxDataDeNascimento";
            maskedTextBoxDataDeNascimento.Size = new Size(114, 23);
            maskedTextBoxDataDeNascimento.TabIndex = 12;
            maskedTextBoxDataDeNascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(377, 200);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(100, 23);
            maskedTextBoxCep.TabIndex = 13;
            maskedTextBoxCep.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(529, 253);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 14;
            maskedTextBoxTelefone.ValidatingType = typeof(DateTime);
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Location = new Point(692, 255);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(46, 19);
            checkBoxSim.TabIndex = 15;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            // 
            // checkBoxNão
            // 
            checkBoxNão.AutoSize = true;
            checkBoxNão.Location = new Point(781, 255);
            checkBoxNão.Name = "checkBoxNão";
            checkBoxNão.Size = new Size(48, 19);
            checkBoxNão.TabIndex = 16;
            checkBoxNão.Text = "Não";
            checkBoxNão.UseVisualStyleBackColor = true;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(329, 114);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(284, 23);
            textBoxMunicipio.TabIndex = 19;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(329, 67);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(284, 23);
            textBoxBairro.TabIndex = 18;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(329, 24);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(284, 23);
            textBoxLogradouro.TabIndex = 17;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 20;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 50);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 21;
            labelEmail.Text = "E-mail";
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.Location = new Point(12, 96);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(74, 15);
            labelNomeSocial.TabIndex = 22;
            labelNomeSocial.Text = "Nome Social";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(329, 6);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 23;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(329, 96);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(61, 15);
            labelMunicipio.TabIndex = 24;
            labelMunicipio.Text = "Municipio";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(329, 50);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 25;
            labelBairro.Text = "Bairro";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(665, 9);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 26;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(665, 50);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 27;
            labelComplemento.Text = "Complemento";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(665, 96);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 28;
            labelEstado.Text = "Estado";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(12, 182);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 29;
            labelGenero.Text = "Genero";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Location = new Point(12, 235);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(33, 15);
            labelEtnia.TabIndex = 30;
            labelEtnia.Text = "Etnia";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(377, 182);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 31;
            labelCep.Text = "CEP";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Location = new Point(377, 235);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(114, 15);
            labelDataDeNascimento.TabIndex = 32;
            labelDataDeNascimento.Text = "Data de Nascimento";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(529, 235);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 33;
            labelTelefone.Text = "Telefone";
            // 
            // labelEstrangerio
            // 
            labelEstrangerio.AutoSize = true;
            labelEstrangerio.Location = new Point(692, 235);
            labelEstrangerio.Name = "labelEstrangerio";
            labelEstrangerio.Size = new Size(71, 15);
            labelEstrangerio.TabIndex = 34;
            labelEstrangerio.Text = "Estrangeiro?";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(329, 371);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(224, 42);
            buttonCadastrar.TabIndex = 35;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.Location = new Point(36, 341);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(0, 15);
            labelRetorno.TabIndex = 36;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(labelRetorno);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelEstrangerio);
            Controls.Add(labelTelefone);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelCep);
            Controls.Add(labelEtnia);
            Controls.Add(labelGenero);
            Controls.Add(labelEstado);
            Controls.Add(labelComplemento);
            Controls.Add(labelNumero);
            Controls.Add(labelBairro);
            Controls.Add(labelMunicipio);
            Controls.Add(labelLogradouro);
            Controls.Add(labelNomeSocial);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(checkBoxNão);
            Controls.Add(checkBoxSim);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(maskedTextBoxDataDeNascimento);
            Controls.Add(comboBoxEtnia);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Name = "Clientes";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private TextBox textBoxNomeSocial;
        private TextBox textBoxEstado;
        private TextBox textBoxComplemento;
        private TextBox textBoxNumero;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEtnia;
        private MaskedTextBox maskedTextBoxDataDeNascimento;
        private MaskedTextBox maskedTextBoxCep;
        private MaskedTextBox maskedTextBoxTelefone;
        private CheckBox checkBoxSim;
        private CheckBox checkBoxNão;
        private TextBox textBoxMunicipio;
        private TextBox textBoxBairro;
        private TextBox textBoxLogradouro;
        private Label labelNome;
        private Label labelEmail;
        private Label labelNomeSocial;
        private Label labelLogradouro;
        private Label labelMunicipio;
        private Label labelBairro;
        private Label labelNumero;
        private Label labelComplemento;
        private Label labelEstado;
        private Label labelGenero;
        private Label labelEtnia;
        private Label labelCep;
        private Label labelDataDeNascimento;
        private Label labelTelefone;
        private Label labelEstrangerio;
        private Button buttonCadastrar;
        private Label labelRetorno;
    }
}
