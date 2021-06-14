using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico_CS_enVisualStudio
{
    /* Al igual que usabamos los ":" para la herencia de clases,
     * y la ventaja que tienen las interfaces,
     * es que podemos implementar varias interfaces a la vez.
     */
    class clsArchivos : intClientes
    {
        /* Implementamos el mismo metodo que hemos declarado previamente en la interface,
         * pero esta vez indicando tambien, que tareas va a realizar.
         */
        public void ArchivoCliente(clsClientesAlPorMayor cliente)
        {
            /* Como podemos ver, declaramos la creacion de un archivo,
             * la escritura en el mismo, y finalmente el cierre de este,
             * con el objeto de "System.IO" llamado "StreamWriter",
             * y lo utilizamos de la siguiente manera:
             */
            // Con el "@", indicamos que nos coja el siguiente parametro tal y como lo definimos.
            // Y con el segundo parametro en "true", sle indicamos que nos lo añada si ya existe el archivo.
            StreamWriter archivo = new StreamWriter(@"E:\archivoClienteAlPorMayor.log", true);
            archivo.WriteLine(cliente.Nombre + " " + cliente.Apellidos);
            archivo.WriteLine(cliente.Direccion + " " + cliente.Ciudad + " " + cliente.Provincia + " " + cliente.Pais);
            archivo.WriteLine(cliente.Telefono);
            archivo.WriteLine(cliente.Promocion.Descuento + "% de Descuento.");
            // Este es un metodo importante de este tipo de objeto, ya que debemos cerrar el archivo despues de escribir en el.
            archivo.Close();
        }
    }
}
