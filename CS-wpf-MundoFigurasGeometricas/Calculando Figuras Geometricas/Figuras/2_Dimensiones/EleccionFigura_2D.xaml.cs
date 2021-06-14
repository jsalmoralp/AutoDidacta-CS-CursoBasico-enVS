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

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones
{
    /// <summary>
    /// Lógica de interacción para EleccionFigura.xaml
    /// </summary>
    public partial class EleccionFigura_2D : Window
    {
        public EleccionFigura_2D()
        {
            InitializeComponent();
        }

        private void Img_cuadrado_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Cuadrado ventana = new Figuras._2_Dimensiones.Formas_Calculo.Cuadrado();
            ventana.Show();
            this.Close();
        }

        private void Img_rectangulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Rectangulo ventana = new Figuras._2_Dimensiones.Formas_Calculo.Rectangulo();
            ventana.Show();
            this.Close();
        }

        private void Img_triangulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Triangulo ventana = new Figuras._2_Dimensiones.Formas_Calculo.Triangulo();
            ventana.Show();
            this.Close();
        }

        private void Img_traopecio_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Trapecio ventana = new Figuras._2_Dimensiones.Formas_Calculo.Trapecio();
            ventana.Show();
            this.Close();
        }

        private void Img_circulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Circulo ventana = new Figuras._2_Dimensiones.Formas_Calculo.Circulo();
            ventana.Show();
            this.Close();
        }

        private void Img_paralelogramo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Paralelogramo ventana = new Figuras._2_Dimensiones.Formas_Calculo.Paralelogramo();
            ventana.Show();
            this.Close();
        }

        private void Img_rombo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Figuras._2_Dimensiones.Formas_Calculo.Rombo ventana = new Figuras._2_Dimensiones.Formas_Calculo.Rombo();
            ventana.Show();
            this.Close();
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new MainWindow();
            ventana.Show();
            this.Close();
        }
    }
}
