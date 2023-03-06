
using Diretorios;
using Calculo;
using Funcoes;
using Tela;
using Classes;
using Componentes;

/*
 * Aula Perminssoes e agrupamentos
class Animal // sealed - restringe n pode fazer heranca 
{
    public string teste;
    public virtual string teste2() //sealed test // virtual faz tirar o new e warning mas obriga o override
    {
        return "";
    }
}
class Macaco : Animal
{
    public override string teste2() //new - para tirar warning do cod // overrride pq agr é virtual
    {
        return "sss";
    }
}*/
/*
 * aula permissoes e agrupamento
partial class Animal // partial permite classes com mesmo nomes e faz merge uma com outra e eles se complementam // n pode ter 2 classes no mesmo namespace
{
    public string teste; // atributo
    partial void tt(); // metodo partial - tem q ser private 
}
partial class Animal
{
    public string teste2;
    partial void tt()
    {
        Console.WriteLine("teste");
    }
}*/

/*
var c = new Cachorro();
c.Idade = 1; // set
Console.WriteLine(c.Idade); // get

c.Idade2 = 1;
Console.WriteLine(c.Idade2);*/


/*
var cachorro = new Cachorro();
cachorro.Latir();

//Menu.Criar();

Console.WriteLine("========== Cadastro de Cliente ==========");
Cliente c = new Cliente();
c.Nome = "Cliente";
c.Telefone = "11123455236";
c.Cpf = "12365478985";
c.Gravar();

foreach (Cliente cl in new Cliente().Ler())
{
    Console.WriteLine(cl.Nome);
    Console.WriteLine(cl.Telefone);
    Console.WriteLine(cl.Cpf);
}

Console.WriteLine("========== Cadastro de Usuario ==========");
Usuario u = new Usuario();
u.Nome = "Usuario";
u.Telefone = "11123455236";
u.Cpf = "12365478985";
u.Gravar(); 

foreach (Usuario us in new Usuario().Ler())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.Cpf);
}

/*Ferramentas f = new Ferramentas();
f.ValidarCpf("sddsd");*/

/*
Cliente c = new Cliente();
Console.WriteLine("========== Cadastro de Usuario ==========");*/
