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
    class Empleado : IntFunciones
    {
        readonly SqlConnection cn = ConfigSQL.ConexionBdSQL();

        public int EmpleadoId { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string DistritoId { get; set; }

        // Constructor
        public Empleado()
        {

        }
        // Constructor Registrar
        public Empleado(string apellidos, string nombre, string dni, string genero, string estadoCivil,
            string direccion, string distritoId)
        {
            this.Apellidos = apellidos;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Genero = genero;
            this.EstadoCivil = estadoCivil;
            this.Direccion = direccion;
            this.DistritoId = distritoId;
        }
        // Constructor Actualizar
        public Empleado(string apellidos, string nombre, string dni, string genero, string estadoCivil,
            string direccion, string distritoId, int empleadoId)
        {
            this.Apellidos = apellidos;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Genero = genero;
            this.EstadoCivil = estadoCivil;
            this.Direccion = direccion;
            this.DistritoId = distritoId;
            this.EmpleadoId = empleadoId;
        }
        // Constructor Eliminar
        public Empleado(int empleadoId)
        {
            this.EmpleadoId = empleadoId;
        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_EMPLEADO", cn))
                {
                    cmd.Parameters.AddWithValue("@APELLIDOS", this.Apellidos);
                    cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    cmd.Parameters.AddWithValue("@DNI", this.Dni);
                    cmd.Parameters.AddWithValue("@GENERO", this.Genero);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", this.EstadoCivil);
                    cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
                    cmd.Parameters.AddWithValue("@DISTRITO_ID", this.DistritoId);
                    cmd.Parameters.Add("@ULTIMO_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    ultimo_id = Convert.ToInt32(cmd.Parameters["@ULTIMO_ID"].Value.ToString());
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return ultimo_id;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return ultimo_id;
        }

        public bool Actualizar()
        {
            try
            {
                using (var cmd = new SqlCommand("SP_ACTUALIZAR_EMPLEADO", cn))
                {
                    cmd.Parameters.AddWithValue("@APELLIDOS", this.Apellidos);
                    cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    cmd.Parameters.AddWithValue("@DNI", this.Dni);
                    cmd.Parameters.AddWithValue("@GENERO", this.Genero);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", this.EstadoCivil);
                    cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
                    cmd.Parameters.AddWithValue("@DISTRITO_ID", this.DistritoId);
                    cmd.Parameters.AddWithValue("@EMPLEADO_ID", this.EmpleadoId);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    var r = cmd.ExecuteNonQuery();
                    cn.Close();

                    if (r==1)
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

        public bool Eliminar()
        {
            try
            {
                using (var cmd = new SqlCommand("SP_ELIMINAR_EMPLEADO", cn))
                {
                    cmd.Parameters.AddWithValue("@EMPLEADO_ID", this.EmpleadoId);

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

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_EMPLEADOS", cn))
                {
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
        public DataTable ListarPorNombre(string nombre)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_EMPLEADOS_POR_NOMBRE", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@NOMBRE", nombre.Trim().ToLower());
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

        public DataTable BuscarPorCodigo(int id)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_BUSCAR_EMPLEADO_POR_ID", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@ID", id);
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

        public void ListarEmpleadosDataGridView(DataGridView dgv)
        {
            var tabla = this.Listar();
            this.ListarGrid(dgv, tabla);
            
        }

        public void ListarEmpleadosPorNombreDataGridView(DataGridView dgv, string nombre)
        {
            var tabla = this.ListarPorNombre(nombre);
            this.ListarGrid(dgv, tabla);

        }

        private void ListarGrid(DataGridView dgv, DataTable tabla)
        {
            var numero_filas = tabla.Rows.Count;
            if (numero_filas > 0)
            {
                dgv.Rows.Clear();
                for (int i = 0; i < numero_filas; i++)
                {
                    string nombre_completo = tabla.Rows[i][2].ToString() + " " + tabla.Rows[i][1].ToString();
                    string dni = tabla.Rows[i][3].ToString();
                    string genero = tabla.Rows[i][4].ToString();
                    string distrito = tabla.Rows[i][5].ToString();
                    int empleadoId = int.Parse(tabla.Rows[i][0].ToString());

                    dgv.Rows.Add(
                        nombre_completo, dni, genero, distrito, "Editar", "Eliminar", empleadoId
                    );

                }
            }
        }
    }
}
