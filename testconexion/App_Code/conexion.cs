using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;

namespace testconexion.App_Code
{
    public class conexion
    {
        private static SqlConnection objconexion;
        private static string error;

        public static SqlConnection getconexion() 
        { 
            if(objconexion !=null)
                return objconexion;
            objconexion = new SqlConnection();
            objconexion.ConnectionString = "Data Source=masbien;Initial Catalog=Agenda;Integrated Security=True";
            try
            {
                objconexion.Open();
                return objconexion;
            }
            catch (Exception e) 
            { 
                error = e.Message;
                return null;
            }
        }
        public static void cerrarConexion() 
        {
            if (objconexion !=null) 
                objconexion.Close();
        }
        
           

        

    }
}