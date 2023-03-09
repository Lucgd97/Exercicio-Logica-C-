using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("=========== Cadastrar Usuario ===========");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n     0 - Sair do cadastro" +
                    "\n     1 - Para cadastrar usuario" +
                    "\n     2 - Para listar usuario";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario(); //metodo de instancia

                    Console.WriteLine("Digite o nome do usuario");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone:");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o Cpf:");
                    usuario.Cpf = Console.ReadLine();

                    usuario.Gravar();
                }
                else
                {
                    var usuarios = new Usuario().Ler(); //classe
                    foreach (Usuario u in usuarios)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Nome: " + u.Nome);
                        Console.WriteLine("Telefone: " + u.Telefone);
                        Console.WriteLine("Cpf: " + u.Cpf);
                        Console.WriteLine("=========================");
                    }
                }
            }
        }
    }
}
