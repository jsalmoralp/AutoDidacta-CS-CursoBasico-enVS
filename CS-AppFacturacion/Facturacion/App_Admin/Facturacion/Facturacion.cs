using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Facturacion
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios Where id_usuario=" + VentanaLogin.Codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["nom_usu"].ToString().Trim();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("SELECT nom_cli FROM Clientes WHERE id_cli='{0}'", txtCodigoCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["nom_cli"].ToString().Trim();

                    txtCodigoProducto.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public static int cont_fila = 0;
        public static double total;

        private void BtnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this,errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);

                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodigoProducto.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();

                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);

                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }
                }

                total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                lblTotal.Text = total.ToString() + " €";
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total -= Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                lblTotal.Text = total.ToString() + " €";

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes conCli = new ConsultarClientes();
            conCli.ShowDialog();

            if (conCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodigoProducto.Focus();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos conPro = new ConsultarProductos();
            conPro.ShowDialog();

            if (conPro.DialogResult == DialogResult.OK)
            {
                txtCodigoProducto.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                txtCantidad.Focus();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            txtCodigoCli.Text = "";
            txtCliente.Text = "";
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "0 €";
            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCodigoCli.Focus();
        }
    }
}
