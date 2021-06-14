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
    class Ubigeo
    {
        readonly SqlConnection cn = ConfigSQL.ConexionBdSQL();

        public DataTable ListarDepartamentos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_DEPARTAMENTOS", cn))
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

        public DataTable ListarProvinciasPorDepartamentoId(string departamentoId)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_PROVINCIAS", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@DEPARTAMENTO_ID", departamentoId);
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
        public DataTable ListarDistritosPorProvinciaId(string provinciaId)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_DISTRITOS", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@PROVINCIA_ID", provinciaId);
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

    }
}
