using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Teinda.Models
{
    public class ConexionBD
    {
      
        private string conexion = @"Data Source = DESKTOP-LMSRAVI; Initical Catalog = Tienda; Integrated Securty =  true";
        private SqlConnection cone;
        private SqlCommand cmd;
        private SqlDataAdapter leer;

        private void Conectar()
        {
            cone = new SqlConnection(conexion);
        }        

        public ConexionBD()
        {
            Conectar();
        }  

        public bool Guardar(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql,cone);
                cone.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                
                    return false;
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.Write("ERROR AL CONECTAR A LA BASE DE DATOS...");
                throw e;
            }
            finally
            {
                cone.Close();
            }
        }
    }
}