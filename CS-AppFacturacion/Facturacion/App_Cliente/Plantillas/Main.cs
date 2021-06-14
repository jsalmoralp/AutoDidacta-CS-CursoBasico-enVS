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

namespace Facturacion.App_Cliente.Plantillas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSet isAdmin = Utilidades.Ejecutar(string.Format("Select status_admin from Usuarios where id_usuario={0}", VentanaLogin.Codigo));
            if (Convert.ToBoolean(isAdmin.Tables[0].Rows[0]["status_admin"]) == true)
            {
                VentanaAdmin ventana = new VentanaAdmin();
                ventana.Show();
            } else
            {
                VentanaUser ventana = new VentanaUser();
                ventana.Show();
            }
        }
    }
}
