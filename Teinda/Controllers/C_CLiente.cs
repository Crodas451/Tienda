using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teinda.Models;

namespace Teinda.Controllers
{
    public class C_CLiente
    {
       Cliente cliente;
        public void Registrar(int id, string name, string ape, string tele, string dire)
        {
            if (id != 0 || name != "" || ape != "" || tele != "" || dire != "")
            {
                cliente = new Cliente(id,name,ape,tele,dire);
                if (cliente.Guardar())
                {
                    Console.Write("ERROR AL GUARDAR...\n");
                }
                else
                {
                    Console.Write("SE GUARDO CORRECTAMENT...\n");
                }
            }
        }

        public void Motra()
        {
            cliente = new Cliente("Cliente");
            cliente.Leer();
        }

        public void BorrarSql(int id)
        {
            cliente = new Cliente(id,"Cliente");

            if (cliente.Elimina())
            {
                Console.Write("REgistro BOrrado");
            }
            else
            {
                Console.Write("ERROR AL BORRAR");
            }

        }
       
    }
}