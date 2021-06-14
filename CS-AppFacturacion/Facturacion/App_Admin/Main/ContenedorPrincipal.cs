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
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoClientes manCli = new MantenimientoClientes();
            manCli.MdiParent = this;
            manCli.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos manPro = new MantenimientoProductos();
            manPro.MdiParent = this;
            manPro.Show();
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarClientes conCli = new ConsultarClientes();
            conCli.MdiParent = this;
            conCli.Show();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProductos conPro = new ConsultarProductos();
            conPro.MdiParent = this;
            conPro.Show();
        }

        private void FacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion fac = new Facturacion();
            fac.MdiParent = this;
            fac.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE id_usuario={0}", VentanaLogin.Codigo);

                DataSet ds = Utilidades.Ejecutar(CMD);

                this.Hide();
                if (ds.Tables[0].Rows[0]["status_admin"].ToString() == "True")
                {
                    VentanaAdmin vAdmin = new VentanaAdmin();
                    vAdmin.Show();
                } else if (ds.Tables[0].Rows[0]["status_admin"].ToString() == "False")
                {
                    VentanaUser vUser = new VentanaUser();
                    vUser.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo salir!! Algo fue mal... \r\n [ Error --> " + ex.ToString()+ " ]");

            }
        }
        
    }
}
