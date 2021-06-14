using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esto es un comentario de una sola linea.
            /* Esto es un comentario de bloque.
             * Todas las sentencias deben terminar con un ";".
             */

            // Imprimimos en la consola nuestro "Hola Mundo".
            Console.WriteLine("Hola Mundo!");
            // Esperamos a que se pulse una tecla, para que se cierre el programa.
            Console.ReadKey();

            /* Para declarar una variable lo haremos de la siguiente forma:
             * TIPO de valor >> NOMBRE de la variable >> VALOR a inicializar (optativo)
             */
            // Variables de tipo entero.
            int a = 0;
            // Variables de tipo punto decimal corto (con pocos decimales).
            decimal b = 0.0m;
            // Variables de tipo punto decimal medio (con unos cuantos decimales).
            float c = 0.0f;
            // Variables de tipo punto decimal largo (con muchos decimales).
            double d = 0.0D;
            // Variables de tipo cadena de texto.
            string e = "Hola Mundo";
            // Varriables de tipo boolean.
            bool f = true;
            // Variables de tipo fecha.
            DateTime g = DateTime.MinValue;
            // Forma de salida (para numeros) normal (con un solo valor)
            Console.WriteLine("El valor de 'a' es: {0}", a);
            // Forma de salida (para numeros) normal (con varios valores)
            Console.WriteLine("El valor de 'c' es: {0} y el valor de 'd' es: {1}", c, d);
            // Forma de salida (para numeros) con formato  -> Ver documentacion de 'String.Format'
            Console.WriteLine("El valor de 'b' es: {0:C}", b);
            Console.WriteLine("El valor de 'c' es: {0:F2}", c);
            // Forma de salida (para strings)
            Console.WriteLine("El valor de 'e' es: " + e);
            // Forma de salida (para booleans)
            Console.WriteLine("El valor de 'f' es: " + f.ToString());
            Console.WriteLine("El valor de 'g' es: " + g.ToShortDateString());
            /* El metodo 'ToString()' lo tienen muchos tipos de variables.
             * El metodo 'ToShortDateString()' es para las variables de tipo 'DateTime'.
             * Por lo tanto seria otra forma mas de concatenar valores.
             */

            // Conversiones de tipos.
            int h = 10;
            decimal i = 12.2m;
            /* -> En casos numericos
             * En el caso de transformar un 'int' a un 'decimal', podemos hacerlo de forma implicita,
             * y NO habria problema ya que el valor pasa a tener mas uso de memoria:
             *  h = i;
             * En el caso de transformar un 'decimal' a un 'int', debemos hcerlo de forma explicita,
             * por lo tanto DEBEMOS CASTEAR que vamos a transformar a 'int',
             * ya que vamos a pasar de usar de mas a menos memoria:
             *  i = (int)h;
             */
            bool j = false;
            string k = string.Empty;
            DateTime l = DateTime.MinValue;
            /* -> En casos alfabeticos:
             * La mayoria de tipos (objetos) tienen un metodo,
             * que suele llamarse 'ToString' o algo similar,
             * que lo que hace es transformar el valor, a un valor de 'string'.
             *  j.ToString();
             *  l.ToShortDateString();
             */
            /* Tambien podemos hacer uso del objeto 'Convert',
             * que tiene multitud de metodos, los cuales podemos utilizar
             * para hacer las conversiones.
             *  i = Convert.ToInt32(h);
             * -> NOTA:
             *   Podemos hacer conversiones de tipo string a numerico,
             *   siempre y cuando el valor de la string sean solo numeros,
             *   no puede contener ningun caracter alfabetico, sino,
             *   dara error a la que ejecutemos el programa.
             */

            // Declaracion de los IF, ELSE, ELSE IF
            /* Los IF, ELSE, y posibles ELSE IF,
             * no necesitan obligatoriamente ir entre llaves, pero..
             * Si tenemos IF, ELSE o ELSE IF anidados dentro de otros,
             * es muy recomendado (casi obligatorio) para que no surjan errores,
             * el uso de llaves en los mas externos, si no en todos.
             */
            int valor1 = 10, valor2 = 20;
            if (valor1 >= valor2)
            { 
                if (valor1 == valor2)
                    Console.WriteLine("El valor1 es igual al valor2");
                else
                    Console.WriteLine("El valor1 es mayor al valor2");
            }
            else
                Console.WriteLine("El valor1 es menor al valor2");

            // Objetos y clases.
            clsEmpleados empleado;              // Declaracion del objeto clase.
            empleado = new clsEmpleados("Joan", 28, 40.5m);      // Instanciacion del objeto clase.
            decimal total = empleado.calcularSalario(30);
            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es de: " + total.ToString());

            // Haciendo uso de una clase con su interface y llamando a dichos metodos.
            clsClientesAlPorMayor cliente = new clsClientesAlPorMayor(
                0, "Joan", "Salmoral Parramon", (Int64)691835095, @"38554813-V",
                "Eduard ALcoy", "Mataro", "Barcelona", "España",
                0, "Promocion 50", 1, 50);

            clsArchivos escritura = new clsArchivos();
            escritura.ArchivoCliente(cliente);

        }
    }
}
