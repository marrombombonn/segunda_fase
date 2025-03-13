namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelText1 = new System.Windows.Forms.Label();
            labelText2 = new System.Windows.Forms.Label();
            labelText3 = new System.Windows.Forms.Label();
            labelText4 = new System.Windows.Forms.Label();
        }


        private void perimetro_Click(object sender, EventArgs e)
        {
            //Aqui deixa as textbox apenas que forem ser ultilizadas
            textBoxP1.Visible = true;
            textBoxP2.Visible = true;
            textBoxP3.Visible = true;
            textBoxP4.Visible = true;

            labeli.Text = "O perímetro é a soma de todos os seus lados";
            labelText1.Text = "Lado esquerdo";
            labelText2.Text = "Lado direito";
            labelText3.Text = "Base";
            labelText1.Text = "Parte superior";
            


            if (string.IsNullOrEmpty(textBoxP1.Text) || string.IsNullOrEmpty(textBoxP2.Text) || string.IsNullOrEmpty(textBoxP3.Text) || string.IsNullOrEmpty(textBoxP4.Text))
            {
                return;
            }

            if (textBoxP1.Text.All(char.IsNumber) && textBoxP2.Text.All(char.IsNumber) && textBoxP3.Text.All(char.IsNumber) && textBoxP4.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBoxP1.Text);
                int numero2 = int.Parse(textBoxP2.Text);
                int numero3 = int.Parse(textBoxP3.Text);
                int numero4 = int.Parse(textBoxP4.Text);
                int resultado = numero1 + numero2 + numero3 + numero4;
                LabelResultado.Text = resultado.ToString();
                
            }
            else
            {
                LabelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }

        }

        private void area_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxP1.Text) || string.IsNullOrEmpty(textBoxP2.Text) || string.IsNullOrEmpty(textBoxP3.Text) || string.IsNullOrEmpty(textBoxP4.Text))
            {
                return;
            }

            //Aqui deixa as textbox apenas que forem ser ultilizadas
            textBoxP1.Visible = true;
            textBoxP2.Visible = true;
            textBoxP3.Visible = false;
            textBoxP4.Visible = false;


            labeli.Text = "A área é a multiblicação de base por altura ";
            labelText1.Text = "Base";
            labelText2.Text = "Altura";
            

            if (textBoxP1.Text.All(char.IsNumber) && textBoxP2.Text.All(char.IsNumber))
            {
                int numero1 = int.Parse(textBoxP1.Text);
                int numero2 = int.Parse(textBoxP2.Text);

                int resultado = numero1 * numero2;
                LabelResultado.Text = resultado.ToString();
                
            }
            else
            {
                LabelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }
        }

        private void volume_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxP1.Text) || string.IsNullOrEmpty(textBoxP2.Text) || string.IsNullOrEmpty(textBoxP3.Text) || string.IsNullOrEmpty(textBoxP4.Text))
            {
                return;
            }

            //Aqui deixa as textbox apenas que forem ser ultilizadas
            textBoxP1.Visible = true;
            textBoxP2.Visible = true;
            textBoxP3.Visible = true;
            textBoxP4.Visible = false;

            labeli.Text = "O volume é a multiblicação da altura (h) pela largura (L) e pelo comprimento (C).";
            labelText1.Text = "Altura";
            labelText2.Text = "Largura";
            labelText3.Text = "Comprimento";

            

            if (textBoxP1.Text.All(char.IsNumber) && textBoxP2.Text.All(char.IsNumber))
            {
                if (string.IsNullOrEmpty(textBoxP1.Text) || string.IsNullOrEmpty(textBoxP2.Text) || string.IsNullOrEmpty(textBoxP3.Text) || string.IsNullOrEmpty(textBoxP4.Text))
                {
                    return;
                }
                int numero1 = int.Parse(textBoxP1.Text);
                int numero2 = int.Parse(textBoxP2.Text);
                int numero3 = int.Parse(textBoxP3.Text);
                int resultado = numero1 * numero2 * numero3;
                LabelResultado.Text = resultado.ToString();
                
            }
            else
            {
                LabelResultado.Text = "Insira apenas numeros ( verifique seu há espaços em brancos, caracteres especiais ou letras)";
            }
        }

       
}
}
