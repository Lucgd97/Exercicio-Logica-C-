using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Base
    {
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome= nome;
            this.Telefone= telefone;
            this.Cpf= cpf;
        }
        public Usuario() { }

    }
}
