using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Base : Pessoa
    {
        public string Nome;
        public string Telefone;
        public string Cpf;

        //sealed n deixa sobrescrever
        public virtual void Gravar() //virtual deixa sobrescrever o metodo em outras classes
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(diretorio()))
            {
                StreamWriter r = new StreamWriter(diretorio());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        private static string diretorio()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
    }
}
