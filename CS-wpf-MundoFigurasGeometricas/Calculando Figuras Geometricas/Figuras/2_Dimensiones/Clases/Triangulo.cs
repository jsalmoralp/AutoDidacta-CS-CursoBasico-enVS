using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Triangulo
    {
        private double l_base;
        private double altura;

        public Triangulo(double _l_base, double _altura)
        {
            L_base = _l_base;
            Altura = _altura;
        }

        public double L_base { get => l_base; set => l_base = value; }
        public double Altura { get => altura; set => altura = value; }

        public double calcularArea()
        {
            double calculo = (L_base * Altura) / 2;
            return calculo;
        }
    }
}
