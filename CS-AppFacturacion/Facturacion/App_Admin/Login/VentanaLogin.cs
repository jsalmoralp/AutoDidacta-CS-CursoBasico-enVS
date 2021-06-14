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
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String Codigo = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status_admin"]) == true)
                    {
                        VentanaAdmin venAd = new VentanaAdmin();
                        this.Hide();
                        venAd.Show();
                    }
                    else
                    {
                        VentanaUser venUs = new VentanaUser();
                        this.Hide();
                        venUs.Show();
                    }
                }

            } catch(Exception)
            {
                MessageBox.Show("Usuario o Contraseña incorrectos...");
            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
