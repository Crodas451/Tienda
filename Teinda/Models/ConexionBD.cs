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
      
         private string conexion = @"Data Source = DESKTOP-LMSRAVI; Initial Catalog = Tienda; Integrated Security =  true";
        private SqlConnection cone;
        private SqlCommand cmd;
        private SqlDataAdapter leer;
        private DataTable sda;
        private DataSet dts;

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

       public DataTable Mostrar(string tabla)
       {
           try
           {
               string sql = @"Select * from " + tabla;
               cone.Open();
               leer = new SqlDataAdapter(sql, cone);
               dts = new DataSet();
               leer.Fill(dts,tabla);
               sda = new DataTable();
               sda = dts.Tables[tabla];
           }
           catch (Exception e) 
           {
               
               throw e;
           }
           finally
           {
               cone.Close();
           }
       }
    }
}
