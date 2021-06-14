using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.App_Cliente.MenuPrincipal
{
    public partial class MenuPrincipal : Plantillas.Main
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            btn_atras.Visible = false;
        }

        private void Img_opcion_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.Menu.MenuPlatos ventana = new App_Cliente.Menu.MenuPlatos();
            ventana.Show();
        }

        private void Img_opcion_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.Menu.MenuBocatas ventana = new App_Cliente.Menu.MenuBocatas();
            ventana.Show();
        }

        private void Img_opcion_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.Menu.MenuOtros ventana = new App_Cliente.Menu.MenuOtros();
            ventana.Show();
        }

        private void Img_opcion_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.Menu.MenuCafes ventana = new App_Cliente.Menu.MenuCafes();
            ventana.Show();
        }
    }
}
