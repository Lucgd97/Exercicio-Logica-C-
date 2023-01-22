using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorios
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\lucas\OneDrive\Área de Trabalho\Alura\C# Danilo\ProgramacaoFuncional\arq" + numeroArquivo + ".txt";
            Console.WriteLine("====== Lendo Arquivo ======\n" + arquivoComCaminho + "\n====================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivosComCaminho2 = @"C:\Users\lucas\OneDrive\Área de Trabalho\Alura\C# Danilo\ProgramacaoFuncional\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivosComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
