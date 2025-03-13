namespace calculadora
{
    partial class Form2
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
            textBoxP1 = new TextBox();
            textBoxP2 = new TextBox();
            textBoxP3 = new TextBox();
            textBoxP4 = new TextBox();
            LabelResultado = new Label();
            LabelInstrucao = new Label();
            labeli = new Label();
            labelText1 = new Label();
            labelText2 = new Label();
            labelText4 = new Label();
            labelText3 = new Label();
            calcular = new Button();
            area = new Button();
            perimetro = new Button();
            volume = new Button();
            SuspendLayout();
            // 
            // textBoxP1
            // 
            textBoxP1.Location = new Point(22, 107);
            textBoxP1.Name = "textBoxP1";
            textBoxP1.Size = new Size(100, 23);
            textBoxP1.TabIndex = 3;
            textBoxP1.Visible = false;
            // 
            // textBoxP2
            // 
            textBoxP2.Location = new Point(128, 107);
            textBoxP2.Name = "textBoxP2";
            textBoxP2.Size = new Size(100, 23);
            textBoxP2.TabIndex = 4;
            textBoxP2.Visible = false;
            // 
            // textBoxP3
            // 
            textBoxP3.Location = new Point(234, 107);
            textBoxP3.Name = "textBoxP3";
            textBoxP3.Size = new Size(100, 23);
            textBoxP3.TabIndex = 5;
            textBoxP3.Visible = false;
            // 
            // textBoxP4
            // 
            textBoxP4.Location = new Point(340, 107);
            textBoxP4.Name = "textBoxP4";
            textBoxP4.Size = new Size(100, 23);
            textBoxP4.TabIndex = 6;
            textBoxP4.Visible = false;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(22, 334);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(0, 15);
            LabelResultado.TabIndex = 7;
            // 
            // LabelInstrucao
            // 
            LabelInstrucao.AutoSize = true;
            LabelInstrucao.Location = new Point(22, 28);
            LabelInstrucao.Name = "LabelInstrucao";
            LabelInstrucao.Size = new Size(0, 15);
            LabelInstrucao.TabIndex = 8;
            // 
            // labeli
            // 
            labeli.AutoSize = true;
            labeli.Location = new Point(22, 58);
            labeli.Name = "labeli";
            labeli.Size = new Size(0, 15);
            labeli.TabIndex = 9;
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Location = new Point(49, 89);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(0, 15);
            labelText1.TabIndex = 10;
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Location = new Point(155, 89);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(0, 15);
            labelText2.TabIndex = 11;
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Location = new Point(375, 89);
            labelText4.Name = "labelText4";
            labelText4.Size = new Size(0, 15);
            labelText4.TabIndex = 12;
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Location = new Point(263, 89);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(0, 15);
            labelText3.TabIndex = 13;
            // 
            // calcular
            // 
            calcular.Location = new Point(22, 308);
            calcular.Name = "calcular";
            calcular.Size = new Size(75, 23);
            calcular.TabIndex = 14;
            calcular.Text = "calcular";
            calcular.UseVisualStyleBackColor = true;
            // 
            // area
            // 
            area.Location = new Point(22, 198);
            area.Name = "area";
            area.Size = new Size(75, 23);
            area.TabIndex = 15;
            area.Text = "Area";
            area.UseVisualStyleBackColor = true;
            area.Click += area_Click;
            // 
            // perimetro
            // 
            perimetro.Location = new Point(22, 227);
            perimetro.Name = "perimetro";
            perimetro.Size = new Size(75, 23);
            perimetro.TabIndex = 16;
            perimetro.Text = "Perimetro";
            perimetro.UseVisualStyleBackColor = true;
            perimetro.Click += perimetro_Click;
            // 
            // volume
            // 
            volume.Location = new Point(22, 256);
            volume.Name = "volume";
            volume.Size = new Size(75, 23);
            volume.TabIndex = 17;
            volume.Text = "Volume";
            volume.UseVisualStyleBackColor = true;
            volume.Click += volume_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volume);
            Controls.Add(perimetro);
            Controls.Add(area);
            Controls.Add(calcular);
            Controls.Add(labelText3);
            Controls.Add(labelText4);
            Controls.Add(labelText2);
            Controls.Add(labelText1);
            Controls.Add(labeli);
            Controls.Add(LabelInstrucao);
            Controls.Add(LabelResultado);
            Controls.Add(textBoxP4);
            Controls.Add(textBoxP3);
            Controls.Add(textBoxP2);
            Controls.Add(textBoxP1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxP1;
        private TextBox textBoxP2;
        private TextBox textBoxP3;
        private TextBox textBoxP4;
        private Label LabelResultado;
        private Label LabelInstrucao;
        private Label labeli;
        private Label labelText1;
        private Label labelText2;
        private Label labelText4;
        private Label labelText3;
        private Button calcular;
        private Button area;
        private Button perimetro;
        private Button volume;
    }
}