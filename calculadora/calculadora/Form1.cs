namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)


        {
            labelOperacao.Text = "+";


            if (textBox1.Text.All(char.IsNumber) && textBox2.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBox1.Text);
                int numero2 = int.Parse(textBox2.Text);
                int resultado = numero1 + numero2;
                labelResultado.Text = resultado.ToString();
            }
            else
            {
                labelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "-";
            if (textBox1.Text.All(char.IsNumber) && textBox2.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBox1.Text);
                int numero2 = int.Parse(textBox2.Text);
                int resultado = numero1 - numero2;
                labelResultado.Text = resultado.ToString();
            }
            else
            {
                labelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "*";
            if (textBox1.Text.All(char.IsNumber) && textBox2.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBox1.Text);
                int numero2 = int.Parse(textBox2.Text);
                int resultado = numero1 * numero2;
                labelResultado.Text = resultado.ToString();
            }
            else
            {
                labelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "/";
            if (textBox1.Text.All(char.IsNumber) && textBox2.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBox1.Text);
                int numero2 = int.Parse(textBox2.Text);
                int resultado = numero1 / numero2;
                labelResultado.Text = resultado.ToString();
            }
            else
            {
                labelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }

        }

        private void NovaJanela(object sender, EventArgs e)
        {

        }

        private void novaJanela_Click(object sender, EventArgs e)
        {
            Form2 novaJanela = new Form2();
            novaJanela.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



