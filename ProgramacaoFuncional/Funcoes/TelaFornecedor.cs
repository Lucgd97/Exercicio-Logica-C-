using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("=========== Cadastrar Fornecedor ===========");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n     0 - Sair do cadastro" +
                    "\n     1 - Para cadastrar fornecedor" +
                    "\n     2 - Para listar fornecedor";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor(); //metodo de instancia

                    Console.WriteLine("Digite o nome do Cnpj");
                    fornecedor.Cnpj = Console.ReadLine();

                    Console.WriteLine("Digite o nome do fornecedor");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone:");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o Cpf do Gerente:");
                    fornecedor.Cpf = Console.ReadLine();

                    fornecedor.Gravar();
                }
                else
                {
                    var fornecedores = new Fornecedor().Ler(); //classe
                    foreach (Fornecedor f in fornecedores)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Cnpj: " + f.Cnpj);
                        Console.WriteLine("Nome: " + f.Nome);
                        Console.WriteLine("Telefone: " + f.Telefone);
                        Console.WriteLine("Cpf do Gerente: " + f.Cpf);
                        Console.WriteLine("=========================");
                    }
                }
            }
        }
    }
}
