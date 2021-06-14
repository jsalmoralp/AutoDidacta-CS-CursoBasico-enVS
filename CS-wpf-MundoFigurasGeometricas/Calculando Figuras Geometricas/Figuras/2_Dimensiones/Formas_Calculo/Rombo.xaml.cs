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
    /// Lógica de interacción para Rombo.xaml
    /// </summary>
    public partial class Rombo : Window
    {
        public Rombo()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            double d_larga = Convert.ToDouble(txt_d_larga.Text);
            double d_corta = Convert.ToDouble(txt_d_corta.Text);
            Clases.Rombo figura = new Clases.Rombo(d_larga, d_corta);
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
