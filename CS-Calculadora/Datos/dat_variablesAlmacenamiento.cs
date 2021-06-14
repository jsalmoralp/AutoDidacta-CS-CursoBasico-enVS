using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Datos
{
    public class dat_variablesAlmacenamiento
    {
        /**
         * Variables base para el almacenamiento de los datos.
         * 
         * @var     int?    almacenamiento  -Donde almacenaremos todos loas datos.
         * @var     int     dimension1      -La usaremos para definir en que numero nos encontramos.
         * @var     int     dimension2      -La usaremos para definir en que tipo de dato vamos a escribir en el numero.
         * @var     int     dimension3      -La usaremos para guardar los datos del numero.
         */
        private int?[,,] almacenamiento;
        private int dimension1;
        private int dimension2;
        private int dimension3;

        public dat_variablesAlmacenamiento()
        {
            almacenamiento = new int?[50, 3, 20];
            Dimension1 = 0;
            Dimension2 = 0;
            Dimension3 = 0;
        }
        public int?[,,] Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public int Dimension1 { get => dimension1; set => dimension1 = value; }
        public int Dimension2 { get => dimension2; set => dimension2 = value; }
        public int Dimension3 { get => dimension3; set => dimension3 = value; }
    }
}
