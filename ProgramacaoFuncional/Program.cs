
using Diretorios;
using Calculo;
using Funcoes;
using Tela;
using Classes;
using Componentes;


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
