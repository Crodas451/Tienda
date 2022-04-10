using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private DataSet dst;
        private DataTable dte;

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
                String sql = @"SELECT * FROM "+ tabla;
                cone.Open();
                leer = new SqlDataAdapter(sql, cone);
                dst = new DataSet();
                leer.Fill(dst, tabla);
                dte = new DataTable();
                dte = dst.Tables[tabla];
            }
            catch (Exception e )
            {

                throw e;
            }
            finally
            {
                cone.Close();
            }
            return dte;
        }


       public bool Eliminar(string tabla,int condicion)
       {
           try
           {
               string sql = @"DELETE "+ tabla + "WHERE id ="+ condicion;
               cmd = new SqlCommand(sql, cone);
              cone.Open();
              int i = cmd.ExecuteNonQuery();

              if (i > 0)
              {
                  return true;
              }
              else
              {
                  return false;
              }
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
