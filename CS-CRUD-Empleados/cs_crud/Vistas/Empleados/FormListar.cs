using cs_crud.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_crud.Vistas.Empleados
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            if (_myForm == null)
            {
                _myForm = this;
            }
        }

        private static FormListar _myForm;
        public static FormListar MyForm
        {
            get
            {
                if (_myForm == null)
                {
                    _myForm = new FormListar();
                }
                return _myForm;
            }
            set
            {
                _myForm = value;
            }
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            empleado.ListarEmpleadosDataGridView(dgv_empleados);
        }

        private void LLabel_nuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new FormRegistrar();
            f.ShowDialog();
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            if (txt_buscar.Text.Trim().Length > 0)
            {
                empleado.ListarEmpleadosPorNombreDataGridView(dgv_empleados, txt_buscar.Text.Trim());
            }
            else
            {
                empleado.ListarEmpleadosDataGridView(dgv_empleados);
            }
        }

        private void Dgv_empleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgv_empleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Editar"))
                {
                    FormActualizar f = new FormActualizar();
                    f.Show();

                    Empleado empleado = new Empleado();
                    int empleado_id = int.Parse(dgv_empleados.Rows[e.RowIndex].Cells[6].Value.ToString());
                    DataTable tabla_empleado = empleado.BuscarPorCodigo(empleado_id);

                    if (tabla_empleado.Rows.Count == 1)
                    {
                        FormActualizar.MyForm.txt_nombre.Text = tabla_empleado.Rows[0]["NOMBRE"].ToString();
                        FormActualizar.MyForm.txt_apellidos.Text = tabla_empleado.Rows[0]["APELLIDOS"].ToString();
                        FormActualizar.MyForm.txt_dni.Text = tabla_empleado.Rows[0]["DNI"].ToString();
                        FormActualizar.MyForm.cbo_genero.Text = tabla_empleado.Rows[0]["GENERO"].ToString();
                        FormActualizar.MyForm.cbo_estado_civil.Text = tabla_empleado.Rows[0]["ESTADO_CIVIL"].ToString();
                        FormActualizar.MyForm.txt_direccion.Text = tabla_empleado.Rows[0]["DIRECCION"].ToString();

                        FormActualizar.MyForm.cbo_departamento.SelectedValue = tabla_empleado.Rows[0]["DEPARTAMENTO_ID"].ToString();
                        FormActualizar.MyForm.cbo_provincia.SelectedValue = tabla_empleado.Rows[0]["PROVINCIA_ID"].ToString();
                        FormActualizar.MyForm.cbo_distrito.SelectedValue = tabla_empleado.Rows[0]["DISTRITO_ID"].ToString();

                        var telefono = new Telefono();
                        var tabla_telefonos = telefono.BuscarPorCodigo(empleado_id);
                        var numero_filas = tabla_telefonos.Rows.Count;

                        if (numero_filas > 0)
                        {
                            for (int i = 0; i < numero_filas; i++)
                            {
                                int telefono_id = int.Parse(tabla_telefonos.Rows[i][0].ToString())

                                string operador = tabla_telefonos.Rows[i][1].ToString();
                                string numero = tabla_telefonos.Rows[i][2].ToString();

                                FormActualizar.MyForm.dgv_telefonos.Rows.Add(
                                    operador, numero, "Eliminar", empleado_id, telefono_id);
                            }
                        }
                        FormActualizar.MyForm.empleadoId_TEMP = empleado_id;
                    }
                }
                if (dgv_empleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Eliminar"))
                {
                    int empleado_id = int.Parse(dgv_empleados.Rows[e.RowIndex].Cells[6].Value.ToString());

                    DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar este empleado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        var empleado = new Empleado(empleado_id);
                        if (empleado.Eliminar())
                        {
                            dgv_empleados.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar", "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
