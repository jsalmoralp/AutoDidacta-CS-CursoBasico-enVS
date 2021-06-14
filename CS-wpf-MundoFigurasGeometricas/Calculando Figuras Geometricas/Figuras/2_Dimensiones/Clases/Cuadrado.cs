using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Cuadrado
    {
        private double lado;

        public Cuadrado(double _lado)
        {
            Lado = _lado;
        }

        public double Lado { get => lado; set => lado = value; }

        public double calcularArea()
        {
            double calculo = Lado * Lado;
            return calculo;
        }
    }
}
