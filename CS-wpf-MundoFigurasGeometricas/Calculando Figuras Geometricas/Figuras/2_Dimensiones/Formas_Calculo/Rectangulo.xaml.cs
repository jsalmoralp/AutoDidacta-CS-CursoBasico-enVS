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
    /// Lógica de interacción para Rectangulo.xaml
    /// </summary>
    public partial class Rectangulo : Window
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            double lado1 = Convert.ToDouble(txt_lado_1.Text);
            double lado2 = Convert.ToDouble(txt_lado_2.Text);
            Clases.Rectangulo figura = new Clases.Rectangulo(lado1, lado2);
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
