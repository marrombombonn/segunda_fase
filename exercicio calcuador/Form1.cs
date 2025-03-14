namespace exercicio_calcuador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBoxOpcao.SelectedItem == null)
            {
                labelInstrucao.Text = "Selecione um op��o";
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Perimetro")
            {
                labelInstrucao.Text = "O per�metro de um c�rculo � calculado multiplicando o n�mero pi pelo di�metro.";
                groupBoxArea.Visible = false;
                groupBoxPerimetro.Visible = true;
                groupBoxVolume.Visible = false;
                groupBoxDiametro.Visible = false;

                groupBoxArea.SendToBack();
                groupBoxPerimetro.BringToFront();
                groupBoxVolume.SendToBack();
                groupBoxDiametro.SendToBack();
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Area")
            {
                labelInstrucao.Text = "A �rea de um c�rculo � calculada multiplicando o n�mero pi pelo raio elevado ao quadrado.";
                groupBoxArea.Visible = true;
                groupBoxPerimetro.Visible = false;
                groupBoxVolume.Visible = false;
                groupBoxDiametro.Visible = false;

                groupBoxArea.BringToFront();
                groupBoxPerimetro.SendToBack();
                groupBoxVolume.SendToBack();
                groupBoxDiametro.SendToBack();
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Volume")
            {
                labelInstrucao.Text = "O volume de uma esfera � calculado multiplicando quatro ter�os pelo n�mero pi e pelo raio elevado ao cubo.";
                groupBoxArea.Visible = false;
                groupBoxPerimetro.Visible = false;
                groupBoxVolume.Visible = true;
                groupBoxDiametro.Visible = false;

                groupBoxVolume.BringToFront();
                groupBoxPerimetro.SendToBack();
                groupBoxArea.SendToBack();
                groupBoxDiametro.SendToBack();
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Diametro")
            {
                labelInstrucao.Text = "Para calcular o di�metro de um c�rculo, basta multiplicar o raio por dois.";
                groupBoxArea.Visible = false;
                groupBoxPerimetro.Visible = false;
                groupBoxVolume.Visible = false;
                groupBoxDiametro.Visible = true;

                groupBoxDiametro.BringToFront();
                groupBoxPerimetro.SendToBack();
                groupBoxArea.SendToBack();
                groupBoxVolume.SendToBack();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxArea.Text, out int numeroArea))
            {
                double resultado = numeroArea * 3.14 * 2;
                labelInstrucao.Text = resultado.ToString();
            }
            else
            {
                labelInstrucao.Text = "Digite um n�mero v�lido!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPerimetro.Text, out int numeroperimero))
            {
                double resultado = 2 * 3.14 * numeroperimero;
                labelInstrucao.Text = resultado.ToString();
            }
            else
            {
                labelInstrucao.Text = "Digite um n�mero v�lido!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxVolumeRaio.Text, out int numeroRaio) && (int.TryParse(textBoxVolumeAltura.Text, out int numeroaltura)))
            {
                double resultado = 3.14 * numeroRaio * 2 * numeroaltura;

                labelInstrucao.Text = resultado.ToString();

            }
            else
            {
                labelInstrucao.Text = "Digite um numero valido";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDiametro.Text, out int numeroDiametro))
            {
                double resultado = numeroDiametro * 2;

                labelInstrucao.Text = resultado.ToString();

            }
            else
            {
                labelInstrucao.Text = "Digite um numero valido";
            }
        }
    }
}
