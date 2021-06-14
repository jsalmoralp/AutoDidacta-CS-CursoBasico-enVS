using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    // SuperClase.
    /* Clase hecha para ver:
     *  -> Clases Padres
     *      (pra ver la herencia en la clase "clsClientesAlPorMayor"
     *  -> Clases Abstractas
     */
    /* Como podemos ver, hacemos uso de la palabra reservada "abstract",
     * tanto en el momento de definir la clase,
     * como en el momento de definir los "getters" y "setters",
     * y si hiciera falta en sus propios metodos;
     * para poder definir que esta clase sera padre de otras clases,
     * y para que podamos usar sus variables y metodos.
     */
    public abstract class clsClientes
    {
        /* Como podemos ver no hace falta declarar las variables, sino,
         * que ya podemos hacer los "Getters" y "Setters" directamente,
         * desde los cuales accederemos a los datos.
         */
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Apellidos { get; set; }
        public abstract long Telefono { get; set; }
    }
}
