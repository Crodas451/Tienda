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

            int id, op;
            string name,tele,ape,dire;
            do
            {
                Console.Write("1- AGG CIENTE");
                Console.Write("2- MOSTRAR TABLA....");
                Console.Write("3- ELIMINAR..");
                Console.Write("OP: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                    {
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
                       System("puase"); 
                       System("cls");
                       break;

                    }
                    case 2:
                    {
                        cLiente.Motrar();
                        System("pause");
                        System("cls");
                        break;
                    }

                    case 3:
                    {
                        Console.Write("CODIG PERSONAL: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    }
                }
            } while (op != 0);
            

        }
    }
}
