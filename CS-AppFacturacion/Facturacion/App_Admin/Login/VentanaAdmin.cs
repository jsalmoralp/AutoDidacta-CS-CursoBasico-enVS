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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAdmin.Text = DS.Tables[0].Rows[0]["nom_usu"].ToString();
            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = "C:\\Fotos\\"+DS.Tables[0].Rows[0]["foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }

        private void App_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.MenuPrincipal.MenuPrincipal ventana = new App_Cliente.MenuPrincipal.MenuPrincipal();
            ventana.Show();
        }
    }
}
