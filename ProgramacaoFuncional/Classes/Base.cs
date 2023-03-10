using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Base : IPessoa
    {
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public  Base() { }

        public string Nome;
        public string Telefone;
        public string Cpf;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCpf(string cpf) { this.Cpf = cpf; }

        private string Sobrenome = "Santos";


        //sealed n deixa sobrescrever
        public virtual void Gravar() //virtual deixa sobrescrever o metodo em outras classes
        {
            var dados = this.Ler();
            dados.Add(this);
            
            StreamWriter r = new StreamWriter(diretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;");
            foreach (Base b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";";
                r.WriteLine(linha);
            }
            r.Close();
            
        }

        public virtual List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();

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

                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        // utilizando Interface
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCpf(baseArquivo[2]);

                        //var b = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]); antigo
                        //var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], Cpf = clienteArquivo[2] }; mesmo codigo mas construtor diferente

                        dados.Add(b);
                    }
                }
            }
            return dados;
        }

        internal string diretorioComArquivo()
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
