using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    /* Esta clase es simplemente para ver:
     *  -> el uso de clases dentro de otras clases
     */
    class clsPromociones
    {
        public clsPromociones()
        {
            Id = 0;
            Nombre = String.Empty;
            Cantidad = 0;
            Descuento = 0;
        }
        public clsPromociones(int id, string nombre, int cantidad, int descuento)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Descuento = descuento;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Descuento { get; set; }
    }
}
