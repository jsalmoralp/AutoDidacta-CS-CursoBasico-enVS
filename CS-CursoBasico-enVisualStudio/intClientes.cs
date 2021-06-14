using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    /* Las "interfaces" son una forma de declarar metodos que seran requeridos,
     * a la hora de que implementemos esta interface a una clase.
     * Tambien nos servira para ver una de las formas del "polimorfismo".
     */
    public interface intClientes
    {
        /* En una "interface" simplemente declaramos el metodo con sus parametros,
         * que a la hora de ser implementados en una clase,
         * seran requeridos, y se tendran que implementar de igual forma.
         */
        void ArchivoCliente(clsClientesAlPorMayor cliente);

    }
}
