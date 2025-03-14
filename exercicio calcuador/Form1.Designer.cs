namespace exercicio_calcuador
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
            groupBoxArea = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            textBoxArea = new TextBox();
            groupBoxPerimetro = new GroupBox();
            button2 = new Button();
            label2 = new Label();
            textBoxPerimetro = new TextBox();
            groupBoxVolume = new GroupBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxVolumeAltura = new TextBox();
            textBoxVolumeRaio = new TextBox();
            groupBoxDiametro = new GroupBox();
            button4 = new Button();
            label5 = new Label();
            textBoxDiametro = new TextBox();
            labelArea = new Label();
            labelPerimetro = new Label();
            labelVolume = new Label();
            labelDiametro = new Label();
            comboBoxOpcao = new ComboBox();
            labelInstrucao = new Label();
            groupBoxArea.SuspendLayout();
            groupBoxPerimetro.SuspendLayout();
            groupBoxVolume.SuspendLayout();
            groupBoxDiametro.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxArea
            // 
            groupBoxArea.Controls.Add(button1);
            groupBoxArea.Controls.Add(label1);
            groupBoxArea.Controls.Add(textBoxArea);
            groupBoxArea.Location = new Point(11, 121);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Size = new Size(132, 139);
            groupBoxArea.TabIndex = 0;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Area";
            // 
            // button1
            // 
            button1.Location = new Point(6, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 52);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Raio";
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(6, 49);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(71, 23);
            textBoxArea.TabIndex = 0;
            // 
            // groupBoxPerimetro
            // 
            groupBoxPerimetro.Controls.Add(button2);
            groupBoxPerimetro.Controls.Add(label2);
            groupBoxPerimetro.Controls.Add(textBoxPerimetro);
            groupBoxPerimetro.Location = new Point(149, 121);
            groupBoxPerimetro.Name = "groupBoxPerimetro";
            groupBoxPerimetro.Size = new Size(132, 139);
            groupBoxPerimetro.TabIndex = 1;
            groupBoxPerimetro.TabStop = false;
            groupBoxPerimetro.Text = "Perimetro";
            // 
            // button2
            // 
            button2.Location = new Point(6, 107);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 52);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Raio";
            // 
            // textBoxPerimetro
            // 
            textBoxPerimetro.Location = new Point(6, 49);
            textBoxPerimetro.Name = "textBoxPerimetro";
            textBoxPerimetro.Size = new Size(71, 23);
            textBoxPerimetro.TabIndex = 1;
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(button3);
            groupBoxVolume.Controls.Add(label3);
            groupBoxVolume.Controls.Add(label4);
            groupBoxVolume.Controls.Add(textBoxVolumeAltura);
            groupBoxVolume.Controls.Add(textBoxVolumeRaio);
            groupBoxVolume.Location = new Point(287, 121);
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.Size = new Size(132, 139);
            groupBoxVolume.TabIndex = 1;
            groupBoxVolume.TabStop = false;
            groupBoxVolume.Text = "Volume";
            // 
            // button3
            // 
            button3.Location = new Point(6, 107);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 52);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Raio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 81);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Altura";
            // 
            // textBoxVolumeAltura
            // 
            textBoxVolumeAltura.Location = new Point(6, 78);
            textBoxVolumeAltura.Name = "textBoxVolumeAltura";
            textBoxVolumeAltura.Size = new Size(71, 23);
            textBoxVolumeAltura.TabIndex = 4;
            // 
            // textBoxVolumeRaio
            // 
            textBoxVolumeRaio.Location = new Point(6, 49);
            textBoxVolumeRaio.Name = "textBoxVolumeRaio";
            textBoxVolumeRaio.Size = new Size(71, 23);
            textBoxVolumeRaio.TabIndex = 2;
            // 
            // groupBoxDiametro
            // 
            groupBoxDiametro.Controls.Add(button4);
            groupBoxDiametro.Controls.Add(label5);
            groupBoxDiametro.Controls.Add(textBoxDiametro);
            groupBoxDiametro.Location = new Point(425, 121);
            groupBoxDiametro.Name = "groupBoxDiametro";
            groupBoxDiametro.Size = new Size(132, 139);
            groupBoxDiametro.TabIndex = 1;
            groupBoxDiametro.TabStop = false;
            groupBoxDiametro.Text = "Diametro";
            // 
            // button4
            // 
            button4.Location = new Point(6, 107);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 52);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 6;
            label5.Text = "Raio";
            // 
            // textBoxDiametro
            // 
            textBoxDiametro.Location = new Point(6, 49);
            textBoxDiametro.Name = "textBoxDiametro";
            textBoxDiametro.Size = new Size(71, 23);
            textBoxDiametro.TabIndex = 3;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(11, 103);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(0, 15);
            labelArea.TabIndex = 2;
            // 
            // labelPerimetro
            // 
            labelPerimetro.AutoSize = true;
            labelPerimetro.Location = new Point(149, 103);
            labelPerimetro.Name = "labelPerimetro";
            labelPerimetro.Size = new Size(0, 15);
            labelPerimetro.TabIndex = 3;
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(287, 103);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(0, 15);
            labelVolume.TabIndex = 4;
            // 
            // labelDiametro
            // 
            labelDiametro.AutoSize = true;
            labelDiametro.Location = new Point(425, 103);
            labelDiametro.Name = "labelDiametro";
            labelDiametro.Size = new Size(0, 15);
            labelDiametro.TabIndex = 5;
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Area", "Perimetro", "Volume", "Diametro" });
            comboBoxOpcao.Location = new Point(12, 28);
            comboBoxOpcao.Name = "comboBoxOpcao";
            comboBoxOpcao.Size = new Size(121, 23);
            comboBoxOpcao.TabIndex = 6;
            comboBoxOpcao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelInstrucao
            // 
            labelInstrucao.AutoSize = true;
            labelInstrucao.Location = new Point(17, 68);
            labelInstrucao.Name = "labelInstrucao";
            labelInstrucao.Size = new Size(0, 15);
            labelInstrucao.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 315);
            Controls.Add(labelInstrucao);
            Controls.Add(comboBoxOpcao);
            Controls.Add(labelDiametro);
            Controls.Add(labelVolume);
            Controls.Add(labelPerimetro);
            Controls.Add(labelArea);
            Controls.Add(groupBoxDiametro);
            Controls.Add(groupBoxVolume);
            Controls.Add(groupBoxPerimetro);
            Controls.Add(groupBoxArea);
            Name = "Form1";
            Text = "Form1";
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            groupBoxPerimetro.ResumeLayout(false);
            groupBoxPerimetro.PerformLayout();
            groupBoxVolume.ResumeLayout(false);
            groupBoxVolume.PerformLayout();
            groupBoxDiametro.ResumeLayout(false);
            groupBoxDiametro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxArea;
        private GroupBox groupBoxPerimetro;
        private GroupBox groupBoxVolume;
        private GroupBox groupBoxDiametro;
        private Label labelArea;
        private Label labelPerimetro;
        private Label labelVolume;
        private Label labelDiametro;
        private ComboBox comboBoxOpcao;
        private Label labelInstrucao;
        private Label label1;
        private TextBox textBoxArea;
        private Label label2;
        private TextBox textBoxPerimetro;
        private Label label3;
        private Label label4;
        private TextBox textBoxVolumeAltura;
        private TextBox textBoxVolumeRaio;
        private Label label5;
        private TextBox textBoxDiametro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
