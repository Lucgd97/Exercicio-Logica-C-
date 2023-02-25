using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente : Base
    {
        /// <summary>
        /// Construtor com 3 parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Contrutor com o parametro telefone int
        /// </summary>
        /// <param name="telefone">Telefone Iinteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        public Cliente() { }
        
        public static string Teste;
    }
}
