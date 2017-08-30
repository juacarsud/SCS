using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaControlHorario.Datos
{
    public class AccesoDatos
    {
        private static String CadConex = "Data Source=JUACARSUD-PC\\SQLEXPRESS;Initial Catalog=SisteControlHorarios;Integrat" +
            "ed Security=True";

        private static SqlConnection conSql;
        private static SqlDataAdapter daSql;
        private static DataTable dtTabla;
        private static SqlCommand coSql;
        
        public static Boolean Conectar()
        {
            Boolean estConex = false;

            try
            {
                conSql = new SqlConnection(CadConex);
                conSql.Open();
                estConex = true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return estConex;
        }
        public static Boolean Conectar(String CadC)
        {
            Boolean estConex = false;
            CadConex = CadC;
            try
            {
                conSql = new SqlConnection(CadConex);
                conSql.Open();
                estConex = true;
            }
            catch (Exception)
            {

                throw;
            }

            return estConex;
        }
        public static void Desconectar()
        {
            conSql.Close();
        }


        public static void reaOperacion(String CadConsul)
        {
            if (Conectar())
            {
                SqlCommand scmComando = new SqlCommand(CadConsul, conSql);
                scmComando.ExecuteNonQuery();
            }
            else
                throw new Exception("No se ha podido realizar la consulta");
            Desconectar();
        }

        

        public static Object ConsultaDato(string consulta)
        {
            if (Conectar())
            {
            coSql = new SqlCommand(consulta, conSql);
            Object aux = coSql.ExecuteScalar();


            if (aux != null)
            {
                Desconectar();
                return aux;
            }
            else
            {
                Desconectar();
                return "";
            }
            
            }
            else
                throw new Exception("No se ha podido realizar la consulta");
           
            
        }

        //-------------------------------------------------------
        public static DataTable reaConsulVista(String CadConsul)
        {
            DataTable curVista = new DataTable();
            if (Conectar())
            {
                SqlCommand scmComando = new SqlCommand(CadConsul, conSql);
                SqlDataAdapter sdaAdaptador = new SqlDataAdapter(scmComando);
                sdaAdaptador.Fill(curVista);
            }
            Desconectar();
            return curVista;
        }

        public static DataTable Consultar(string consulta)
        {
            coSql = new SqlCommand(consulta, conSql);
            daSql = new SqlDataAdapter(coSql);

            dtTabla = new DataTable();
            daSql.Fill(dtTabla);
            Desconectar();
            return dtTabla;
        }
        //--------------------------------------------------

    }
}
