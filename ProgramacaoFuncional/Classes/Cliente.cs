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

        public Cliente()
        {

        }

        public string Nome;
        public string Telefone;
        public string Cpf;

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        //sealed n deixa sobrescrever
        public virtual void Gravar() //virtual deixa sobrescrever o metodo em outras classes
        {
             var clientes = Cliente.LerClientes();
                clientes.Add(this);
                if (File.Exists(caminhoBase()))
                {
                    StreamWriter r = new StreamWriter(caminhoBase());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Cliente c in clientes)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                        r.WriteLine(linha);
                    }
                    r.Close();
                }                                  
        }
                               
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) 
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                        //var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], Cpf = clienteArquivo[2] }; mesmo codigo mas construtor diferente
                        
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
                
    }
}
