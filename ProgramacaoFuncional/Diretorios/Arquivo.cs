using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorios
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
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

            string arquivosComCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivosComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
