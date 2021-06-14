using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Formas_Calculo
{
    /// <summary>
    /// Lógica de interacción para Trapecio.xaml
    /// </summary>
    public partial class Trapecio : Window
    {
        public Trapecio()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            double lado_largo = Convert.ToDouble(txt_l_largo.Text);
            double lado_corto = Convert.ToDouble(txt_l_corto.Text);
            double altura = Convert.ToDouble(txt_altura.Text);
            Clases.Trapecio figura = new Clases.Trapecio(lado_largo, lado_corto, altura);
            lbl_resultado.Content = figura.calcularArea().ToString();
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            EleccionFigura_2D ventana = new EleccionFigura_2D();
            ventana.Show();
            this.Close();
        }
    }
}
