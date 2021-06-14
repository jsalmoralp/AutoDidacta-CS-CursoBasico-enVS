using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Datos
{
    public static class dat_calcBase
    {
        /**
         * Variables para uso global.
         * 
         * @var     int?    almacenamiento  -Donde almacenaremos todos loas datos.
         * @var     int     dimension1      -La usaremos para definir en que numero nos encontramos.
         * @var     int     dimension2      -La usaremos para definir en que tipo de dato vamos a escribir en el numero.
         * @var     int     dimension3      -La usaremos para guardar los datos del numero.
         */
        private static int?[,,] almacenamiento;
        private static int dimension1;
        private static int dimension2;
        private static int dimension3;

        public static int?[,,] Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public static int Dimension1 { get => dimension1; set => dimension1 = value; }
        public static int Dimension2 { get => dimension2; set => dimension2 = value; }
        public static int Dimension3 { get => dimension3; set => dimension3 = value; }

    }
}
