
using Diretorios;
using Calculo;
using Funcoes;
using Tela;
using Classes;

//Menu.Criar();

Cliente c = new Cliente();
c.Nome = "Camila";
c.Telefone = "11123455236";
c.Cpf = "12365478985";
c.Gravar();

foreach (Cliente us in Cliente.LerClientes())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.Cpf);
}

Usuario u = new Usuario();
u.Nome = "Camila";
u.Telefone = "11123455236";
u.Cpf = "12365478985";
u.Gravar();

foreach (Usuario us in Usuario.LerUsuarios())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.Cpf);
}