
using Diretorios;
using Calculo;
using Funcoes;
using Tela;
using Classes;

//Menu.Criar();

//Cliente c = new Cliente();

//Cliente c2= new Cliente { Nome= "Danilo", Telefone = "12123454567", Cpf="12396385202" };

//var l = new List<String>();

var cliente = new Cliente(); //metodo de instancia
cliente.Nome = "Danilo";
cliente.Telefone = "16456321456";
cliente.Cpf = "12365478958";
cliente.Gravar();

//var cliente2 = new Cliente();
//cliente2.Nome = "Lucas";
//cliente2.Telefone = "16987456541";
//cliente2.Cpf = "15998774125";
//cliente2.Gravar();

var clientes = Cliente.LerClientes(); //classe

foreach (Cliente c in clientes)
{
    Console.WriteLine(c.Nome);
    Console.WriteLine(c.Telefone);
    Console.WriteLine(c.Cpf);

    Console.WriteLine("==================");
}

Console.ReadLine();