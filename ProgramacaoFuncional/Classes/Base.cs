using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Base : Pessoa
    {
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public  Base()
        {

        }

        public string Nome;
        public string Telefone;
        public string Cpf;
        private string Sobrenome = "Santos";

        //sealed n deixa sobrescrever
        public virtual void Gravar() //virtual deixa sobrescrever o metodo em outras classes
        {
            var dados = new Base().Ler();
            dados.Add(this);
            if (File.Exists(diretorioComArquivo()))
            {
                StreamWriter r = new StreamWriter(diretorioComArquivo());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public List<Base> Ler()
        {
            var dados = new List<Base>();

            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var cliente = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);
                        //var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], Cpf = clienteArquivo[2] }; mesmo codigo mas construtor diferente

                        dados.Add(cliente);
                    }
                }
            }
            return dados;
        }

        private string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }

        public virtual void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim!");
        }                      

        protected int CalcularUmMaisDois() //cliente e herenca
        {
            return 1 + 2;
        }
        private int CalcularUmMaisDois2() //somente clientes
        {
            return 1 + 2;
        }

        public int CalcularUmMaisDois3() // tds
        {
            return 1 + 2;
        }

        internal int CalcularUmMaisDois4() //instancia,herenca,interno da classe,mas n em outro projeto
        {
            return 1 + 2;
        }
    }
}
