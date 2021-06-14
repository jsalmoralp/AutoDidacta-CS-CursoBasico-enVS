using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    // Se le pone 'public' para que sea accesible desde cualquier lugar.
     public class clsEmpleados
    {
        /* A las propiedades, se les puede poner 'public' para que sean accesibles.
         * Pero es mejor hacer uso de la modularidad que ofrece este lenguaje,
         * y hacerlas privadas, para despues usarlas haciendo uso de los 'getters' y 'setters'
         */
        private string _nombre;
        private decimal _sueldoDiario;
        private int _edad;

        // Metodo Constructor
        /* El metodo constructor debe llevar el mismo nombre que la clase.
         * Si no llevara el mismo nombre ya no seria el metodo constructor.
         */
        public clsEmpleados(string nombre, int edad, decimal sueldoDiario)
        {
            this._nombre = nombre;
            this._sueldoDiario = sueldoDiario;
            this._edad = edad;
        }

        /* Getters y Setters de nuestras propiedades. (Ejemplos claros de encapsulamiento)
         * Para usarlos, hacemos uso del mismo modo que si no tubiesen el set y el get,
         * accesando a ellas con la forma de accesar a una propiedad definida como publica.
         */
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal SueldoDiario { get => _sueldoDiario; set => _sueldoDiario = value; }
        public int Edad { get => _edad; set => _edad = value; }

        /* Como en todas las clases, una clase de tipo objeto,
         * tambien puede tener sus propios metodos que interactuan o realizan operaciones,
         * con o sin sus propiedades, devolviendo o no un resultado.
         */
        public decimal calcularSalario(int numeroDias)
        {
            return this._sueldoDiario * numeroDias;
        }

    }
}
