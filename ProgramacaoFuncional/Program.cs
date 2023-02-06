
using Diretorios;
using Calculo;
using Funcoes;
using Tela;
using Classes;

//Menu.Criar();

Cliente c = new Cliente();
c.Nome = "Lucas";
c.Telefone = "11123455236";
c.Cpf = "12365478985";
c.Gravar();
foreach (Cliente cl in Cliente.LerClientes())
{
    Console.WriteLine(cl.Nome);
    Console.WriteLine(cl.Telefone);
    Console.WriteLine(cl.Cpf);
}

Usuario u = new Usuario();
u.Nome = "Danilo";
u.Telefone = "11123455236";
u.Cpf = "12365478985";
u.Gravar();
foreach (Usuario us in Usuario.LerUsuarios())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.Cpf);
}