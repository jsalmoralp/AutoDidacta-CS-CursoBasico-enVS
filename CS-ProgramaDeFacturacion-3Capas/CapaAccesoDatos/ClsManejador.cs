using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ClsManejador
    {
        SqlConnection conexion = new SqlConnection("Server=. ; DataBase=Administracion; Integrated Security=True");

        //Metodo para abrir conexion
        void abrir_conexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        //Metodo para cerrar conexion
        void cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        //Metodo para ejecutar sp (StoredProcedures) (Insert,Delete,Update)
        public void Ejecutar_Sp(string NombreSp, List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                abrir_conexion();
                cmd = new SqlCommand(NombreSp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if(lst != null)
                {
                    for(int i =0; i<lst.Count; i++)
                    {
                        if (lst[i].Direccion== ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction== ParameterDirection.Output)
                        {
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                        }
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            cerrar_conexion();
        }
        //Metodo para los listados o Consultas (Select)
        public DataTable Listado(String NombreSP,List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
