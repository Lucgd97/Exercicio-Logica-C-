using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Cliente
    {
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public Usuario() { }

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }

        public override void Gravar() //override esta sobre escrevendo o codigo de cliente
        {           
                var usuario = Usuario.LerUsuarios();
                usuario.Add(this);
                if (File.Exists(caminhoBase()))
                {
                    StreamWriter r = new StreamWriter(caminhoBase());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Usuario c in usuario)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                        r.WriteLine(linha);
                    }
                    r.Close();
                }            
        }

        public override void Olhar()
        {
            int resultado = this.CalcularUmMaisDois();

            Console.WriteLine("O usuario " + this.Nome + " não rwm sobrenome, pois é atributo privado de cliente(Classe Pai)");
            base.Olhar();
        }

        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();

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
                        var usuarioArquivo = linha.Split(';');

                        var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);

                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

    }
}
