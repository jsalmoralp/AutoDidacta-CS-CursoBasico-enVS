using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_crud.Clases
{
    class Telefono
    {
        readonly SqlConnection cn = ConfigSQL.ConexionBdSQL();

        public int TelefonoId { get; set; }
        public string Operador { get; set; }
        public string Numero { get; set; }
        public int EmpleadoId { get; set; }

        // Constructor
        public Telefono()
        {

        }

        public Telefono(int telefonoId)
        {
            this.TelefonoId = telefonoId;
        }

        public Telefono(string operador, string numero, int empleadoId)
        {
            this.Operador = operador;
            this.Numero = numero;
            this.EmpleadoId = empleadoId;
        }

        public bool Registrar()
        {
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_TELEFONO", cn))
                {
                    cmd.Parameters.AddWithValue("@OPERADOR", this.Operador);
                    cmd.Parameters.AddWithValue("@NUMERO", this.Numero);
                    cmd.Parameters.AddWithValue("@EMPLEADO_ID", this.EmpleadoId);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    int r = cmd.ExecuteNonQuery();
                    cn.Close();
                    if (r == 1)
                    {
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return false;
        }

        public DataTable BuscarPorCodigo(int empleadoId)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_BUSCAR_TELEFONO_POR_EMPLEADO_ID", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@EMPLEADO_ID", empleadoId);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return tabla;
            }
            return tabla;
        }

        public bool Eliminar()
        {
            try
            {
                using (var cmd = new SqlCommand("SP_ELIMINAR_TELEFONO", cn))
                {
                    cmd.Parameters.AddWithValue("@TELEFONO_ID", this.TelefonoId);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    var r = cmd.ExecuteNonQuery();
                    cn.Close();

                    if (r == 1)
                    {
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return false;
        }
    }
}
