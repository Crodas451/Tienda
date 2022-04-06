using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teinda.Models
{
    public class Cliente
    {
        ConexionBD conexion = new ConexionBD();
        private int _id;
        private String _nombre;
        private String _apellido;
        private String _telefono;
        private String _direccion;

        public int Id {get => _id; set => _id = value;}
        public String Nombre {get => _nombre; set => _nombre = value;}
        public String Apellido {get => _apellido; set => _apellido = value;}
        public String Telefono {get => _telefono; set => _telefono = value;}
        public String Direccion {get => _direccion; set => _direccion = value;}

        public Cliente(int _id, String _nombre,String _apellido,String _telefono,String _direccion)
        {
            this.Id = _id;
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.Telefono = _telefono;
            this.Direccion = _direccion;
        }

        public bool Guardar()
        {
            string sql = @"INSERT INTO Cliente values('"+this.Id+"','"+this.Nombre+"','"+this.Apellido+"','"+this.Telefono+"','"+this.Direccion+"');";
            if (conexion.Guardar(sql))
            return true;
            
            else
            {
                return false;

            }
        }

    }
}