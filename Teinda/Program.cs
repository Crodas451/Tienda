using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teinda.Controllers;

namespace Teinda
{
    class Program
    {
        static void Main(string[] args)
        {
            C_CLiente cLiente = new C_CLiente();

            int id;
            string name,tele,ape,dire;
            Console.Write("INGRESE N.CARNE.");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRESE NOMBRE..");
            name = Console.ReadLine();
            Console.Write("INGRESE APELLIDO");
            ape = Console.ReadLine(); 
            Console.Write("INGRESE TELEFONO");
            tele = Console.ReadLine();
            Console.Write("DIRECCION.......");
            dire = Console.ReadLine();

            cLiente.Registrar(id,name,ape,tele,dire);

        }
    }
}
