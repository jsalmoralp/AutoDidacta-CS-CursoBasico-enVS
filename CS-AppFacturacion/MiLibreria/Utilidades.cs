using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            //SqlConnection Con = new SqlConnection("Data Source=DESKTOP-E7JSG2R\\RASKANSQL;Initial Catalog=Administracion;Integrated Security=True");
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=facturacion;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach(Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox Obj)
                {
                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }

                    if (Obj.SoloNumeros == true)
                    {
                        int cont = 0;
                        int LetrasEncontradas = 0;
                        

                        foreach (char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), cont))
                            {
                                LetrasEncontradas++;
                            }
                            cont++;
                        }

                        if (LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Solo Numeros!");
                        }
                    }

                    if (Obj.SoloFloat == true)
                    {
                        // falta para solo float
                        /* podemos mirar si con el float se puede hacer... o
                         * miarar cada char que sea numro i si existe un solo punto o no
                         */
                    }
                }
            }
            return HayErrores;
        }
    }
}
