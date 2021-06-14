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
    public partial class ConsultarClientes : Consultas
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Clientes").Tables[0];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string cmd = "";
            if (string.IsNullOrEmpty(errorTxtBox1.Text.Trim())== false)
            {
                cmd = "SELECT * FROM Clientes WHERE nom_cli LIKE ('%" + errorTxtBox1.Text.Trim() + "%')";
            }
            else
            {
                cmd = "SELECT * FROM Clientes";
            }

            try
            {
                DataSet ds;
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
    }
}
