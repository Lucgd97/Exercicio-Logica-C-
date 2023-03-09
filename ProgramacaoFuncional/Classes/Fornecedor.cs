using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string Cnpj;
        public Fornecedor(string nome, string telefone, string cpf, string cnpj)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Cnpj = cnpj;
        }
        public Fornecedor() { }



    }
}
