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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Calculando_Figuras_Geometricas.Figuras._2_Dimensiones;

namespace Calculando_Figuras_Geometricas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Img_adimensionales_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Img_unidimensionales_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Img_bidimensionales_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EleccionFigura_2D ventana = new EleccionFigura_2D();
            ventana.Show();
            this.Close();
        }

        private void Img_tridimensionales_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Img_nDimensionales_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
