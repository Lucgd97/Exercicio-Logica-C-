using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public void Chamar()
        {
            Cliente c = new Cliente();

            Cliente c2 = new Cliente { nome = "danilo", telefone = "12123454567", cpf = "12396385202" };

            var l = new list<string>();

            var Cliente = new Cliente(); //metodo de instancia
            Cliente.nome = "geraldo";
            Cliente.telefone = "16456321456";
            Cliente.cpf = "12365478958";
            Cliente.gravar();

            var cliente2 = new cliente();
            cliente2.nome = "lucas";
            cliente2.telefone = "16987456541";
            cliente2.cpf = "15998774125";
            cliente2.gravar();

            var clientes = cliente.lerclientes(); //classe

            foreach (cliente c in clientes)
            {
                console.writeline(c.nome);
                console.writeline(c.telefone);
                console.writeline(c.cpf);

                console.writeline("==================");
            }

            console.readline();
        }
    }
}
