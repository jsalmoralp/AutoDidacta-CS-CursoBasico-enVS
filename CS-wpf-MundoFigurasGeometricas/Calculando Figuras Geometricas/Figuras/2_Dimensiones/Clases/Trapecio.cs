using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Trapecio
    {
        private double l_largo;
        private double l_corto;
        private double altura;

        public Trapecio(double _l_largo, double _l_corto, double _altura)
        {
            L_largo = _l_largo;
            L_corto = _l_corto;
            Altura = _altura;
        }

        public double L_largo { get => l_largo; set => l_largo = value; }
        public double L_corto { get => l_corto; set => l_corto = value; }
        public double Altura { get => altura; set => altura = value; }

        public double calcularArea()
        {
            double calculo = ((L_largo + L_corto) / 2) * Altura;
            return calculo;
        }
    }
}
