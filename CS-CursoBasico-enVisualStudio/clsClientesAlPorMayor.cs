using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    /* Para indicar que una clase hereda de otra clase,
     * deberemos indicarlo al finalizar la declaracion de la clase,
     * con ":" y el nombre de la clase de la cual hereda.
     */
    public class clsClientesAlPorMayor : clsClientes
    {
        /* Como vemos podemos hacer dos metodos constructores,
         * a los cuales accederemos a ellos a traves de sus parametros,
         * si usamos el metodo sin parametros accederemos al primer metodo constructor,
         * y si lo usamos con parametros, accederemos al segundo metodo constructor.
         */
        public clsClientesAlPorMayor()
        {
            Id = 0;
            Nombre = String.Empty;
            Apellidos = String.Empty;
            Telefono = 0;
            Nie = String.Empty;
            Direccion = String.Empty;
            Ciudad = String.Empty;
            Provincia = String.Empty;
            Pais = String.Empty;
            promocion = new clsPromociones();
        }
        public clsClientesAlPorMayor(
            int id, string nombre, string apellidos, long telefono,
            string nie, string direccion, string ciudad, string provincia, string pais,
            int promoId, string promoNombre, int promoCantidad, int promoDescuento)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Nie = nie;
            Direccion = direccion;
            Ciudad = ciudad;
            Provincia = provincia;
            Pais = pais;
            /* Si hacemos uso de otras clases en esta, en los metodos constructores,
             * debemos instanciarlos, para poder hacer uso del "getter" y "setter",
             * que hemos tambien declarado previamente. Y lo haremos de esta forma.
             */
            promocion = new clsPromociones();
            Promocion.Id = promoId;
            Promocion.Nombre = promoNombre;
            Promocion.Cantidad = promoCantidad;
            Promocion.Descuento = promoDescuento;
        }
        /* Para poder hacer uso de las variables y metodos de la clase que hereda,
         * tendremos que declarar los "getters" y "setters" de esas variables,
         * y hacer uso de la palabra reservada "override".
         */
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Apellidos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override long Telefono { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nie { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        /* Tambien podemos hacer uso como si fueran variables propias en el motodo constructor,
         * de variables de otras clases declarandolas de esta forma,
         * y con la palabra reservada "internal".
         */
        private clsPromociones promocion;
        internal clsPromociones Promocion { get => promocion; set => promocion = value; }

    }
}