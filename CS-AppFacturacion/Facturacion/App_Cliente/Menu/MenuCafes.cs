using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.App_Cliente.Menu
{
    public partial class MenuCafes : Plantillas.Main
    {
        public MenuCafes()
        {
            InitializeComponent();
        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_Cliente.MenuPrincipal.MenuPrincipal ventana = new App_Cliente.MenuPrincipal.MenuPrincipal();
            ventana.Show();
        }
    }
}
