using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;

namespace cadastro_cliente
{
    public partial class Clientes : Form
    {
        List<Clientes> usuarios = new List<Clientes>();
        public Clientes()
        {
            InitializeComponent();
            Endereco_Cliente Neymar = new Endereco_Cliente();
            {
                string Logradouro = "Rua das Palmeiras";
                string N�mero = "345";
                string Complemento = "Apto 302";
                string Bairro = "Jardim das Flores";
;               string Munic�pio = "S�o Paulo";
                string Estado = "S�o Paulo";
                string CEP = "01234 - 567";
            }
            


        }

        


    }
}
