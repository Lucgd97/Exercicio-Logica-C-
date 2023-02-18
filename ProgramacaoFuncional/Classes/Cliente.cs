﻿using System;
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

        public Cliente()
        {

        }                  

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }


        public virtual void Olhar()
        {
            int resultado = this.CalcularUmMaisDois();

            Console.WriteLine("O usuario " + this.Nome + " não rwm sobrenome, pois é atributo privado de cliente(Classe Pai)");
            base.Olhar();
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
