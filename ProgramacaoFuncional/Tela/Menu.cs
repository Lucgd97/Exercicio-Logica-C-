﻿using Calculo;
using Diretorios;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela

{    
    class Menu
    {
        public static void Crar()
        {
            int SAIDA_PROGRAMA = 0;
            int LER_ARQUIVOS = 1;
            int TABUADA = 2;
            int CALCULO_MEDIA = 3;
            int CADASTRAR_CLIENTES = 4;
            int CADASTRAR_USUARIO = 5; 
            int CADASTRAR_FORNECEDOR = 6; 


            while (true)
            {
                string mensagem = "Olá usário, bem vindo ao programa\n" +
                    "\n ==== Aplicação Console Final ====" +
                    "\n  Digite uma das opções abaixo:" +
                    "\n  0 - Sair do programa" +
                    "\n  1 - Para ler arquivos" +
                    "\n  2 - Para executar tabuada" +
                    "\n  3 - Calcular média de alunos" +
                    "\n  4 - Cadastrar Clientes" +
                    "\n  5 - Cadastrar Usuario" +
                    "\n  6 - Cadastrar Fornecedor";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine(" ===== Ler Arquivos =====");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n========================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine(" ======== Tabuada ========");
                    Console.WriteLine("Digite o numero que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n========================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("====== Media de Notas ======");
                    Media.Aluno();
                    Console.WriteLine("\n========================\n");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("\n========================\n");
                }
                else if (valor == CADASTRAR_USUARIO)
                {
                    TelaUsuario.Chamar();
                    Console.WriteLine("\n========================\n");
                }
                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    TelaFornecedor.Chamar();
                    Console.WriteLine("\n========================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente!");
                }
            }
        }
    }
}
