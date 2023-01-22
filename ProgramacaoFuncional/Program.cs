
static void LerArquivos(int numeroArquivo)
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
    if(File.Exists(arquivosComCaminho2))
    {
        LerArquivos(numeroArquivo + 1);
    }
}


    static void Tabuada(int numero)
    {
        Console.WriteLine($" ===== Tabuada do numero {numero}! =====");
        for(int i = 1; i<=10; i++)
        {
            Console.WriteLine(numero + " X " + i + " = " + (numero*i));
        }
    }

 void CalcularMediaAluno() 
{
    Console.WriteLine("Digite o nome do aluno");
    string nome = Console.ReadLine();
    int qtdNotas = 3;
    Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

    List<int> notas = new List<int>();
    int totalNotas = 0;
    for (int i=1; i<= qtdNotas; i++)
    {
        Console.WriteLine("Digite a nota numero " + i);
        int nota = int.Parse(Console.ReadLine());
        totalNotas += nota;
        notas.Add(nota);
    }

    int media = totalNotas / notas.Count;
    Console.WriteLine("A média d o aluno " + nome + " é: " + media);
    Console.WriteLine("Suas notas são:\n");
    foreach(int nota in notas)
    {
        Console.WriteLine("Nota: " + nota + "\n");
    }
}


int SAIDA_PROGRAMA = 0;
int LER_ARQUIVOS = 1;
int TABUADA = 2;
int CALCULO_MEDIA = 3;

while (true)
{
    string mensagem = "Olá uusário, bem vindo ao programa\n" +
        "\n ==== Programação funcional ====" +
        "\n  Digite uma das opções abaixo:" +
        "\n  0 - Sair do programa" +
        "\n  1 - Para ler arquivos" +
        "\n  2 - Para executar tabuada" +
        "\n  3 - Calcular média de alunos";
    Console.WriteLine(mensagem);

    int valor = int.Parse(Console.ReadLine());

    if (valor == SAIDA_PROGRAMA)
    {
        break;
    }
    else if (valor == LER_ARQUIVOS)
    {
        Console.WriteLine(" ===== Ler Arquivos =====");
        LerArquivos(1);
        Console.WriteLine("\n========================\n");
    }
    else if (valor == TABUADA)
    {
        Console.WriteLine(" ======== Tabuada ========");
        Console.WriteLine("Digite o numero que deseja na tabuada");
        int numero = int.Parse(Console.ReadLine());
        Tabuada(numero);
        Console.WriteLine("\n========================\n");
    }
    else if (valor == CALCULO_MEDIA)
    {
        CalcularMediaAluno();
        Console.WriteLine("\n========================\n");
    }
    else
    {
        Console.WriteLine("Opção inválida, digite novamente!");
    }
}
