using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cadastro_cliente
{
    public partial class Clientes : Form
    {

        private readonly List<Cliente> ListaCliente = [];
        private readonly BindingSource BindingSource = [];
        


        private bool ValidarCampo(string Texto, string nomeCampo)
        {
            if (string.IsNullOrEmpty(Texto))
            {
                labelRetorno.Text = "O campo não pode estar vazio e nem ter apenas espaços em branco";
                return false;
            }
            return true;
        }


        private bool ValidarsSemNumeros(string Texto, string nomeCampo)
        {
            if (Texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " não pode conter números";
                return false;
            }
            return true;
        }


        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas números";
                return false;
            }
            return true;
        }


        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O email deve estar em um formato válido (Ex.: exemplo@gmail.com)";
                return false;
            }
            return true;
        }


        private bool ValidarNascimento(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataNascimento) || dataNascimento > DateTime.Now)
            {
                labelRetorno.Text = "Data inválida! Use o formato 00/00/0000 e verifique se não é futura.";
                return false;
            }
            return true;
        }


        private bool EmailJaExiste(string email)
        {
            return ListaCliente.Any(cliente => cliente.Email == email);
        }

        private bool TelefoneJaExiste(string telefone)
        {
            string numero = new string(telefone.Where(char.IsDigit).ToArray());
            return numero.Length == 10 || numero.Length == 11;
        }


        private int GerarNovoId()
        {
            return ListaCliente.Count == 0 ? 1 : ListaCliente.Max(cliente => cliente.Id) + 1;
        }


        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do cliente") || !ValidarsSemNumeros(textBoxNomeCliente.Text, "Nome do cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }

            if (!ValidarCampo(textBoxLogradouro.Text, "Logradouro"))
            {
                textBoxLogradouro.Focus();
                return;
            }

            if (!ValidarCampo(textBoxBairro.Text, "Bairro"))
            {
                textBoxBairro.Focus();
                return;
            }

            if (!ValidarCampo(textBoxMunicipio.Text, "Município"))
            {
                textBoxMunicipio.Focus();
                return;
            }

            if (!ValidarCampo(textBoxNumero.Text, "Número"))
            {
                textBoxNumero.Focus();
                return;
            }

            if (!ValidarCampo(textBoxEstado.Text, "Estado"))
            {
                textBoxEstado.Focus();
                return;
            }

            if (!ValidarApenasNumeros(maskedTextBoxCep.Text, "CEP"))
            {
                maskedTextBoxCep.Focus();
                return;
            }

            if (!ValidarCampo(textBoxEmail.Text, "Email") || !ValidarEmail(textBoxEmail.Text))
            {
                textBoxEmail.Focus();
                return;
            }


            string email = textBoxEmail.Text;
            if (EmailJaExiste(email))
            {
                labelRetorno.Text = "Erro: E-mail já cadastrado.";
                textBoxEmail.Focus();
                return;
            }


            string telefone = maskedTextBoxTelefone.Text;
            if (TelefoneJaExiste(telefone))
            {
                labelRetorno.Text = "Erro: Telefone já cadastrado.";
                maskedTextBoxTelefone.Focus();
                return;
            }


            int novoId = GerarNovoId();


            Cliente novoCliente = new Cliente()
            {
                Id = novoId,
                Nome = textBoxNomeCliente.Text,
                DataNascimento = maskedTextBoxDataDeNascimento.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
            };


            ListaCliente.Add(novoCliente);


            labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }


        public Clientes()
        {
            InitializeComponent();
            Endereco_Cliente EnderecoNeymar = new Endereco_Cliente()
            {
                Logradouro = "Endereço do Neymar",
                Numero = "11",
                Complemento = "do lado do vizinho dele",
                CEP = "11111111",
                Bairro = "jogador do Brasil",
                Estado = "São Paulo",
                Municipio = "Craque de bola"
            };
            Cliente Neymar = new Cliente()
            {
                Id = 1,
                Nome = "Neymar Junior",
                DataNascimento = "05/02/1992",
                Etnia = EtniaCliente.Pardos,
                Tipo = Tipo_Cliente.PJ,
                Endereco = EnderecoNeymar,
                Telefone = "11 91111-1111",
                Email = "neymarjunior@gmail.com",
                Genero = GeneroCliente.Cisgenero,
                Estrangeiro = false
            };
            ListaCliente.Add(Neymar);

            Endereco_Cliente EnderecoCristiano = new Endereco_Cliente()
            {
                Logradouro = "Endereço do Cristiano",
                Numero = "07",
                Complemento = "A baixo do de cima",
                CEP = "77777777",
                Bairro = "jogador do portugal",
                Estado = "São Paulo",
                Municipio = "Eu sou o melhor"
            };
            Cliente Cristiano = new Cliente()
            {
                Id = 2,
                Nome = "Cristiano Ronaldo",
                DataNascimento = "05/02/1985",
                Etnia = EtniaCliente.Branco,
                Tipo = Tipo_Cliente.PF,
                Endereco = EnderecoCristiano,
                Telefone = "77 97777-7777",
                Email = "cristianoronaldo@gmail.com",
                Genero = GeneroCliente.Cisgenero,
                Estrangeiro = true
            };
            ListaCliente.Add(Cristiano);

            Endereco_Cliente EnderecoMessi = new Endereco_Cliente()
            {
                Logradouro = "Endereço do Messi",
                Numero = "10",
                Complemento = "Perto de quem mora perto",
                CEP = "10101010",
                Bairro = "jogador da Argentina",
                Estado = "São Paulo",
                Municipio = "Querido da fifa",

            };
            Cliente Messi = new Cliente()
            {
                Id = 4,
                Nome = "Lionel Messi",
                DataNascimento = "24/06/1987",
                Etnia = EtniaCliente.Indigena,
                Tipo = Tipo_Cliente.PJ,
                Endereco = EnderecoMessi,
                Telefone = "11 91010-1010",
                Email = "lionelmessi@gmail.com",
                Genero = GeneroCliente.Cisgenero,
                Estrangeiro = true
            };
            ListaCliente.Add(Messi);
           
            BindingSource.DataSource = ListaCliente;
            dataGridView1.DataSource = BindingSource;

        }

        private void VerClientes_Click(object sender, EventArgs e)
        {
            

        }
    }

}
