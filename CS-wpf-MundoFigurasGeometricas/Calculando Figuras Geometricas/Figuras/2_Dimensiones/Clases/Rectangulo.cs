using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Rectangulo
    {
        private double lado1;
        private double lado2;

        public Rectangulo(double _lado1, double _lado2)
        {
            Lado1 = _lado1;
            Lado2 = _lado2;
        }

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public double calcularArea()
        {
            double calculo = Lado1 * Lado2;
            return calculo;
        }
    }
}
