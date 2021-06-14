using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Clases
{
    class Rombo
    {
        private double d_larga;
        private double d_corta;

        public Rombo(double _d_larga, double _d_corta)
        {
            D_larga = _d_larga;
            D_corta = _d_corta;
        }

        public double D_larga { get => d_larga; set => d_larga = value; }
        public double D_corta { get => d_corta; set => d_corta = value; }

        public double calcularArea()
        {
            double calculo = (D_larga * D_corta) / 2;
            return calculo;
        }
    }
}
