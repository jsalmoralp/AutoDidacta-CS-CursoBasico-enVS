using cs_crud.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_crud.Vistas.Empleados
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_apellidos.Text.Trim().Equals(""))
            {
                txt_apellidos.Focus();
                MessageBox.Show("Completar Apellidos", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_nombre.Text.Trim().Equals(""))
            {
                txt_nombre.Focus();
                MessageBox.Show("Completar Nombre", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_dni.Text.Trim().Length != 9)
            {
                txt_dni.Focus();
                MessageBox.Show("Completar DNI con 8 numeros", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_direccion.Text.Trim().Equals(""))
            {
                txt_direccion.Focus();
                MessageBox.Show("Completar Direccion", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv_telefonos.Rows.Count == 0)
            {
                MessageBox.Show("Ingresar al menos un telefono", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var empleado = new Empleado(
                    txt_apellidos.Text.Trim().ToLower(),
                    txt_nombre.Text.Trim().ToLower(),
                    txt_dni.Text.Trim(),
                    cbo_genero.Text,
                    cbo_estado_civil.Text,
                    txt_direccion.Text.Trim(),
                    cbo_distrito.SelectedValue.ToString()
                );
                int ultimo_id = empleado.Registrar();

                if (ultimo_id > 0)
                {
                    int numero_filas = dgv_telefonos.Rows.Count;
                    for (int i = 0; i < numero_filas; i++)
                    {
                        string operador = dgv_telefonos.Rows[i].Cells[0].Value.ToString();
                        string numero = dgv_telefonos.Rows[i].Cells[1].Value.ToString();
                        int empleado_id = ultimo_id;
                        var telefono = new Telefono(operador, numero, empleado_id);
                        var resultado = telefono.Registrar();
                        if (!resultado)
                        {
                            MessageBox.Show("Error al registrar Telefonos", "Error con el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Empleado registrado correctamenre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    empleado.ListarEmpleadosDataGridView(FormListar.MyForm.dgv_empleados);
                }
                else
                {
                    MessageBox.Show("Error al Registrar", "Error con el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            cbo_genero.SelectedIndex = 0;
            cbo_estado_civil.SelectedIndex = 0;
            cbo_operador.SelectedIndex = 0;

            Ubigeo ubigeo = new Ubigeo();
            DataTable tabla = ubigeo.ListarDepartamentos();
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }
        }

        private void Cbo_departamento_SelectedValueChanged(object sender, EventArgs e)
        {
            Ubigeo ubigeo = new Ubigeo();
            var departamentoId = cbo_departamento.SelectedValue.ToString();
            DataTable tabla = ubigeo.ListarProvinciasPorDepartamentoId(departamentoId);
            if (tabla.Rows.Count > 0)
            {
                cbo_provincia.DataSource = tabla;
                cbo_provincia.DisplayMember = "NOMBRE_PROVINCIA";
                cbo_provincia.ValueMember = "PROVINCIA_ID";
            }
        }

        private void Cbo_provincia_SelectedValueChanged(object sender, EventArgs e)
        {
            Ubigeo ubigeo = new Ubigeo();
            var provinciaId = cbo_provincia.SelectedValue.ToString();
            DataTable tabla = ubigeo.ListarDistritosPorProvinciaId(provinciaId);
            if (tabla.Rows.Count > 0)
            {
                cbo_distrito.DataSource = tabla;
                cbo_distrito.DisplayMember = "NOMBRE_DISTRITO";
                cbo_distrito.ValueMember = "DISTRITO_ID";
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_numero.Text.Trim().Equals(""))
            {
                MessageBox.Show("Completar Numero", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_numero.Text.Trim().Length != 9)
            {
                MessageBox.Show("Completar Numero con 9 digitos", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int numero_filas = dgv_telefonos.Rows.Count;
                if (numero_filas == 0)
                {
                    AgregarTelefonos();
                }
                else
                {
                    bool existe = false;
                    string numero = txt_numero.Text;
                    for (int i = 0; i < numero_filas; i++)
                    {
                        if (numero.Equals(dgv_telefonos.Rows[i].Cells[1].Value.ToString()))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe)
                    {
                        MessageBox.Show("Este telefono ya existe");
                    }
                    else
                    {
                        AgregarTelefonos();
                    }
                }
            }
        }

        private void AgregarTelefonos()
        {
            string operador = cbo_operador.Text;
            string numero = txt_numero.Text;
            dgv_telefonos.Rows.Add(operador, numero, "Eliminar", 0);
            txt_numero.Text = string.Empty;
            txt_numero.Focus();
        }

        private void Txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                // falta colocar que el ultimo caracter sea letra y añadir el "-" automaticamente
                /* para añadir el guion automaticamente abria que refractorizar todo en relacion a
                 la cantidad de caracteres del dni de 9 caracteres a 10 caracteres */
            }
        }

        private void Txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                // falta colocar que el ultimo caracter sea letra y añadir el "-" automaticamente
                /* para añadir el guion automaticamente abria que refractorizar todo en relacion a
                 la cantidad de caracteres del dni de 9 caracteres a 10 caracteres */
            }
        }
    }
}
