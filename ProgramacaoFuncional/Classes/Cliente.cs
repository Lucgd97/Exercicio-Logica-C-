using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">`Para preencher o nome do objeto</param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        /// <summary>
        /// Contrutor com o parametro telefone int
        /// </summary>
        /// <param name="telefone">Telefone Iinteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        public Cliente()
        {

        }

        public string Nome;
        public string Telefone;
        public string Cpf;

        public void Gravar()
        {
            //todo
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) 
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente();
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.Cpf = clienteArquivo[2];

                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        
    }
}
