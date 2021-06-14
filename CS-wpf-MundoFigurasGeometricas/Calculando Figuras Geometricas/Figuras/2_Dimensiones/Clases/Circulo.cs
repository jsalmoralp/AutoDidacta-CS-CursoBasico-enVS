using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Circulo
    {
        private double radio;

        public Circulo(double _radio)
        {
            Radio = _radio;
        }

        public double Radio { get => radio; set => radio = value; }

        public double calcularArea()
        {
            double calculo = Math.PI * Math.Pow(radio, 2);
            return calculo;
        }
    }
}
