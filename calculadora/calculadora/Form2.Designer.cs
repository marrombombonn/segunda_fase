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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            LabelPerimetro = new RadioButton();
            LabelArea = new RadioButton();
            LabelVolume = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            LabelResultado = new Label();
            LabelOperacao1 = new Label();
            LabelOperacao2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelPerimetro
            // 
            LabelPerimetro.AutoSize = true;
            LabelPerimetro.Location = new Point(12, 141);
            LabelPerimetro.Name = "LabelPerimetro";
            LabelPerimetro.Size = new Size(77, 19);
            LabelPerimetro.TabIndex = 0;
            LabelPerimetro.TabStop = true;
            LabelPerimetro.Text = "Perimetro";
            LabelPerimetro.UseVisualStyleBackColor = true;
            // 
            // LabelArea
            // 
            LabelArea.AutoSize = true;
            LabelArea.Location = new Point(12, 166);
            LabelArea.Name = "LabelArea";
            LabelArea.Size = new Size(49, 19);
            LabelArea.TabIndex = 1;
            LabelArea.TabStop = true;
            LabelArea.Text = "Area";
            LabelArea.UseVisualStyleBackColor = true;
            // 
            // LabelVolume
            // 
            LabelVolume.AutoSize = true;
            LabelVolume.Location = new Point(12, 191);
            LabelVolume.Name = "LabelVolume";
            LabelVolume.Size = new Size(65, 19);
            LabelVolume.TabIndex = 2;
            LabelVolume.TabStop = true;
            LabelVolume.Text = "Volume";
            LabelVolume.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(371, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(502, 77);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(0, 15);
            LabelResultado.TabIndex = 6;
            // 
            // LabelOperacao1
            // 
            LabelOperacao1.AutoSize = true;
            LabelOperacao1.Location = new Point(236, 77);
            LabelOperacao1.Name = "LabelOperacao1";
            LabelOperacao1.Size = new Size(0, 15);
            LabelOperacao1.TabIndex = 7;
            // 
            // LabelOperacao2
            // 
            LabelOperacao2.AutoSize = true;
            LabelOperacao2.Location = new Point(357, 77);
            LabelOperacao2.Name = "LabelOperacao2";
            LabelOperacao2.Size = new Size(0, 15);
            LabelOperacao2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LabelOperacao2);
            Controls.Add(LabelOperacao1);
            Controls.Add(LabelResultado);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LabelVolume);
            Controls.Add(LabelArea);
            Controls.Add(LabelPerimetro);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton LabelPerimetro;
        private RadioButton LabelArea;
        private RadioButton LabelVolume;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label LabelResultado;
        private Label LabelOperacao1;
        private Label LabelOperacao2;
        private PictureBox pictureBox1;
    }
}