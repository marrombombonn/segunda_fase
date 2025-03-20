using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;

namespace cadastro_cliente
{
    public partial class Clientes : Form
    {
        private readonly List<Cliente> ListaCliente = [];

        private bool ValidarCampo (string Texto, string nomeCampo)
        {
          if (string.IsNullOrEmpty (Texto))
            {
                labelRetorno.Text = "O campo não pode estar vazio e nem ter apenas espaços em branco";
                return false;
            }
          return true;
        }
        private bool ValidarsSemNumeros(string Texto, string nomeCampo)
        {
            if(Texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo" + nomeCampo + " não pode conter números";
                return false;
            }
            return true;
        }
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if(!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "o campo" + nomeCampo + " deve conter apenas números";
                return false;
            }
            return true;
        }
        private bool ValidarEmail(string email)
        {
            if(!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O email deve estar em um formato válido (Ex.: exemplo@gmail.com) ";
                return false;
            }
            return true;
            
        }



          
        public Clientes()
        {
            InitializeComponent();
            Endereco_Cliente EnderecoNeymar = new Endereco_Cliente() { Logradouro = "Endereço do Neymar", Numero = "11", Complemento = "do lado do vizinho dele", CEP = "11101-01", Bairro = "jogador do Brasil", Estado = "São Paulo", Municipio = "Craque de bola" };
            Cliente Neymar = new Cliente() { Id = 1, Nome = "Neymar Junior", DataNascimento = "05/02/1992", Etnia = EtniaCliente.Pardos, Tipo = Tipo_Cliente.PJ, Endereco = EnderecoNeymar };
            ListaCliente.Add(Neymar);

            Endereco_Cliente EnderecoCristiano = new Endereco_Cliente() { Logradouro = "Endereço do Cristiano", Numero = "07", Complemento = "A baixo do de cima", CEP = "07707000", Bairro = "jogador do portugal", Estado = "São Paulo", Municipio = "Eu sou o melhor" };
            Cliente Cristiano = new Cliente() { Id = 2, Nome = "Cristiano Ronaldo", DataNascimento = "05/02/1985", Etnia = EtniaCliente.Branco, Tipo = Tipo_Cliente.PF, Endereco = EnderecoCristiano };
            ListaCliente.Add(Cristiano);

            Endereco_Cliente EnderecoMessi = new Endereco_Cliente() { Logradouro = "Endereço do Messi", Numero = "10", Complemento = "Perto de quem mora perto", CEP = "010101-10", Bairro = "jogador da Argentina", Estado = "São Paulo", Municipio = "Querido da fifa" };
            Cliente Messi = new Cliente() { Id = 4, Nome = "Lionel Messi", DataNascimento = "24/06/1987", Etnia = EtniaCliente.Indigena, Tipo = Tipo_Cliente.PJ, Endereco = EnderecoMessi };
            ListaCliente.Add(Messi);

        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if(!ValidarCampo(textBoxNome.Text, "Nome do cliente") || !ValidarsSemNumeros(textBoxNome.Text, " Nome do cliente"))
            {
                textBoxNome.Focus();
                return;
            }
        }
    }
}
