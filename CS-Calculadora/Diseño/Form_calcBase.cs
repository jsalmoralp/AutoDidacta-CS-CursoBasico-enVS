using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Logica;
using Calculadora.Datos;

namespace Calculadora.Diseño
{
    public partial class Form_calcBase : Form
    {
        public Form_calcBase()
        {
            InitializeComponent();
            dat_calcBase.Almacenamiento = new int?[50, 3, 20];
            dat_calcBase.Dimension1 = 0;
            dat_calcBase.Dimension2 = 0;
            dat_calcBase.Dimension3 = 0;
        }

        /****************************************
         * Funcion que imprime en "lbl_visualOperaciones" y "txt_resultado" la operacion y numeros que pertoquen.
         */
        public void imprimirOperacion(string valor = null, bool actu_lblVisuOpera = true, bool reset_txtResul = false)
        {
            string str = "";
            if (valor == null)
            {
                for (int comaOperacion = 0; comaOperacion < 3; comaOperacion++)
                {
                    for (int valorNumero = 0; valorNumero < 20; valorNumero++)
                    {
                        if (comaOperacion == 0 && valorNumero == 0 && dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 0].HasValue)
                        {
                            str += "(";
                            break;
                        }
                        else if (comaOperacion == 1 && valorNumero == 0 && dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 1, 1].HasValue)
                        {
                            str += ",";
                            break;
                        }
                        else if (comaOperacion == 2 && valorNumero == 0 && dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 2, 0].HasValue)
                        {
                            str += ")";
                            break;
                        }
                        else if (comaOperacion == 2 && valorNumero > 0)
                        {
                            break;
                        }
                        else if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, comaOperacion, valorNumero].HasValue)
                        {
                            str += dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, comaOperacion, valorNumero].ToString();
                            break;
                        }
                    }
                }
            }
            else
            {
                string txtAnterior = txt_resultado.Text;
                str = txtAnterior + valor;
            }
            txt_resultado.Text = str;
            if (actu_lblVisuOpera)
            {
                lbl_visualOperaciones.Text = cls_calcBase.visualOperaciones();
            }
        }

        private void Btn_numero0_Click(object sender, EventArgs e)
        {
            if (dat_calcBase.Dimension2 != 0 && dat_calcBase.Dimension3 != 0)
            {
                cls_calcBase.numerosBase(0);
            }
            imprimirOperacion("0");
        }

        private void Btn_numero1_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(1);
            imprimirOperacion("1");
            
        }

        private void Btn_numero2_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(2);
            imprimirOperacion("2");
        }

        private void Btn_numero3_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(3);
            imprimirOperacion("3");
        }

        private void Btn_numero4_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(4);
            imprimirOperacion("4");
        }

        private void Btn_numero5_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(5);
            imprimirOperacion("5");
        }

        private void Btn_numero6_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(6);
            imprimirOperacion("6");
        }

        private void Btn_numero7_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(7);
            imprimirOperacion("7");
        }

        private void Btn_numero8_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(8);
            imprimirOperacion("8");
        }

        private void Btn_numero9_Click(object sender, EventArgs e)
        {
            cls_calcBase.numerosBase(9);
            imprimirOperacion("9");
        }

        private void Btn_simboloComa_Click(object sender, EventArgs e)
        {
            cls_calcBase.seleccionAlmacenamiento(2);
            imprimirOperacion(",");
        }

        private void Btn_simboloAParentesis_Click(object sender, EventArgs e)
        {
            if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 1].HasValue == false)
            {
                cls_calcBase.seleccionAlmacenamiento(5);
                dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, dat_calcBase.Dimension2, dat_calcBase.Dimension3] = 1;
                imprimirOperacion("(", false);
            }
        }

        private void Btn_simboloCParentesis_Click(object sender, EventArgs e)
        {
            if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 1].HasValue == true)
            {
                cls_calcBase.seleccionAlmacenamiento(6);
                dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, dat_calcBase.Dimension2, dat_calcBase.Dimension3] = 1;
                imprimirOperacion(")", false);
            }
        }

        private void Btn_operacionSumar_Click(object sender, EventArgs e)
        {
            cls_calcBase.operacionesBase(1);
            imprimirOperacion(null, true, true);
        }

        private void Btn_operacionRestar_Click(object sender, EventArgs e)
        {
            cls_calcBase.operacionesBase(2);
            imprimirOperacion(null, true, true);
        }

        private void Btn_operacionMultiplicar_Click(object sender, EventArgs e)
        {
            cls_calcBase.operacionesBase(3);
            imprimirOperacion(null, true, true);
        }

        private void Btn_operacionDividir_Click(object sender, EventArgs e)
        {
            cls_calcBase.operacionesBase(4);
            imprimirOperacion(null, true, true);
        }

        private void Btn_operacionIgual_Click(object sender, EventArgs e)
        {
            cls_calcBase.operacionesBase(0);
            imprimirOperacion(null, true, true);
        }

        private void Btn_borrarReturn_Click(object sender, EventArgs e)
        {
            cls_calcBase.borrado_tipoReturn();
            imprimirOperacion(null, true, true);
        }

        private void Btn_borrarCE_Click(object sender, EventArgs e)
        {
            cls_calcBase.borrado_tipoCE();
            imprimirOperacion(null, true, true);
        }

        private void Btn_borrarC_Click(object sender, EventArgs e)
        {
            cls_calcBase.borrado_tipoC();
            imprimirOperacion(null, true, true);
        }
    }
}
