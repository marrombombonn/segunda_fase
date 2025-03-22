using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cliente
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public  EtniaCliente Etnia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco_Cliente Endereco{ get; set; }
        public string NomeSocial { get; set; }
        public bool Estrangeiro { get; set; }
        public  Tipo_Cliente Tipo { get; set; }
        public  GeneroCliente Genero { get; set; }



    }
}
