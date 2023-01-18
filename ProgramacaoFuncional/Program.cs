
int SAIDA_PROGRAMA = 0;
int LER_ARQUIVOS = 1;
int TABUADA = 2;
int CALCULO_MEDIA = 3;

while (true)
{
    string mensagem = "Olá uusário, bem vindo ao programa, utilizando programação funcional" +
        "\nDigite uma das opções abaixo:" +
        "\n0 - Sair do programa" +
        "\n1 - Para ler arquivos" +
        "\n2 - Para executar tabuada" +
        "\n3 - Calcular média de alunos";
    Console.WriteLine(mensagem);

    Console.WriteLine($"Digite {SAIDA_PROGRAMA} para sair do programa");
    int valor = int.Parse( Console.ReadLine() );

    if (SAIDA_PROGRAMA == valor)
    {
        break;
    }
}
