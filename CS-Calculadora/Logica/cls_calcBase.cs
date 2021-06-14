using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Datos;
using Calculadora.Diseño;

namespace Calculadora.Logica
{
    public static class cls_calcBase
    {
        /******************************************
         * Funcion que cambia los valores de las variables "dimension1", "dimension2", "dimension3",
         * y eso nos permite movernos dentro del array para insertar o visualizar los datos.
         */
        public static void seleccionAlmacenamiento(int accionAlmacenamiento)
        {
            /*********************************************/
            /************ ACCIONES OPCIONALES ************/
            /*********************************************/
            //Con esta accion elegimos el elemento del array (unico para esta accion), donde vamos almacenar un valor si queremos introducir un cierre de parentesis.
            if (accionAlmacenamiento == 6)
            {
                dat_calcBase.Dimension3 = 0;
                dat_calcBase.Dimension2 = 2;
            }
            //Con esta accion elegimos el elemento del array (unico para esta accion), donde vamos almacenar un valor si queremos introducir una apertura de parentesis.
            else if (accionAlmacenamiento == 5)
            {
                dat_calcBase.Dimension3 = 0;
                dat_calcBase.Dimension2 = 0;
            }
            /*********************************************/
            /********** FIN ACCIONES OPCIONALES **********/
            /*********************************************/

            /***************************************/
            /************ ACCIONES BASE ************/   // ==> Las ACCIONES A REALIZAR estan descritas por secuencia logica <== //
            /***************************************/
            /** QUINTA ACCION BASE a realizar **/
            //Con esta accion elegimos el elemento del array (unico para esta accion), donde vamos a almacenar el tipo de operacion que va a tener que realizar nuestra calculadora.
            else if (accionAlmacenamiento == 4)
            {
                dat_calcBase.Dimension3 = 1;
                dat_calcBase.Dimension2 = 2;
            }
            /** SEGUNDA ACCION BASE a realizar **/  /** CUARTA ACCION BASE a realizar **/
            //Con esta accion pasamos al siguiente elemento del array (de la tercera dimension), donde vamos a almacenar (los numeros base "uno a uno, de los que componen el numero completo") de antes o despues de la coma.
            else if (accionAlmacenamiento == 3)
            {
                dat_calcBase.Dimension3++;
            }
            /** TERCERA ACCION BASE a realizar **/
            //Con esta accion pasamos a la siguiente posicion del array (de la segunda dimension), donde dentro de este (en la siguiente dimension), se almacena cada componente que forma el numero completo.
            /** INFO ADICIONAL QUE CONFORMA CASI TODA ESTA LOGICA
             * Dentro de la posicion 0 (de la segunda dimension), apertura de parentesis (x,0,0), y elementos (numero uno a uno) que conforman el numero completo de antes de la coma (x,0,1 | x,0,2 | ...);
             * de la posicion 1 (de la segunda dimension), elementos (numero uno a uno) que conforman el numero completo de despues de la coma (x,1,1 | x,1,2 | ...);
             * y de la posicion 2 (de la segunda dimension), cierre de parentesis (x,2,0), y la operacion que realizara nuestra calculadora (x,2,1).
             */
            else if (accionAlmacenamiento == 2)
            {
                dat_calcBase.Dimension3 = 0;
                dat_calcBase.Dimension2++;
            }
            /** PRIMERA ACCION BASE a realizar **/
            //Con esta accion pasamos al siguiente elemento del array (de la primera dimension), donde dentro de este (en las siguientes dos dimensiones) se almacena de forma completa el numero, opciones, y operaciones con las que va a operar nuestra calculadora.
            else if (accionAlmacenamiento == 1)
            {
                dat_calcBase.Dimension3 = 0;
                dat_calcBase.Dimension2 = 0;
                dat_calcBase.Dimension1++;
            }
            /***************************************/
            /********** FIN ACCIONES BASE **********/
            /***************************************/
        }

        /****************************************
         * Funcion que devuelve una string,
         * con toda la operacion introducida que este almacenada en el array "almacenamiento",
         * y esta no deve pasar el "limite" que lo estableceremos con "dimension1", a la que hagamos uso de esta funcion,
         * pero queda a libre eleccion, para mostrar tambien toda la ultima "dimension1" cuando queramos el resultado.
         * - MAS INFO:
         * Tambien se hace de esta forma para no recorrer todo el posible array y ahorrar tiempo de ejecucion.
         */
        public static string visualOperaciones(int? limite = null)
        {
            string visualOperaciones = "";
            if (limite == null)
            {
                limite = dat_calcBase.Dimension1;
            }
            for (int posicionNumero = 0; posicionNumero < 50; posicionNumero++)
            {//INICIO PRIMERA DIMENSION
                if (posicionNumero == limite)
                {
                    break;
                }
                for (int comaOperacion = 0; comaOperacion < 3; comaOperacion++)
                {//INICIO SEGUNDA DIMENSION
                    for (int valorNumero = 0; valorNumero < 20; valorNumero++)
                    {//INICIO TERCERA DIMENSION
                        //Este if comprueba si existe algun valor (en esta posicion del array), para pasar a la siguiente en caso de que no contenga nada, y no nos salte algun posible error y/o imprima algo no deseado.
                        if (dat_calcBase.Almacenamiento[posicionNumero, comaOperacion, valorNumero].HasValue == false)
                        {
                            //Anidamos este if aqui ya que vamos a aprobechar para escribir la coma cuando lleguemos a la posiciom 1 (de la segunda dimension), y a la posicion 0 (de la tercera dimension), que no deberia contener ningun valor. Este es el momento mas idoneo para hacerlo. Esto siempre y cuando tengamos almenos un valor (un elemento de numero completo de despues de la coma), y esto es dentro de la posicion 1 (de la segunda dimension).
                            if (comaOperacion == 1 && valorNumero == 0 && dat_calcBase.Almacenamiento[posicionNumero, 1, 1].HasValue == true)
                            {
                                visualOperaciones += ",";
                            }
                            continue;
                        }
                        //Si partimos de la primera dimension, y en las dos siguientes, en la posicion exacta de (x,0,0) tenemos valor, es porque existe apertura de parentesis.
                        if (comaOperacion == 0 && valorNumero == 0 && dat_calcBase.Almacenamiento[posicionNumero, 0, 0].HasValue == true)
                        {
                            visualOperaciones += " (";
                            continue;
                        }
                        //Si nos encontramos en la posicion exacta de (x,2,0), y este tiene valor (si llegamos aqui, es porque si tiene valor). Es porque existe cierre de parentesis.
                        if (comaOperacion == 2 && valorNumero == 0 && dat_calcBase.Almacenamiento[posicionNumero, 2, 0].HasValue == true)
                        {
                            visualOperaciones += " )";
                            continue;
                        }
                        //Si nos encontramos en la posicion exacta de (x,2,1), y este tiene valor (si llegamos aqui es porque si tiene valor). Ese valor sera el que defina el tipo de operaciopn que vamos a realizar en nuesta calculadora.
                        if (comaOperacion == 2 && valorNumero == 1 && dat_calcBase.Almacenamiento[posicionNumero, 2, 1].HasValue == true)
                        {
                            //Switch donde valoramos exactamente que tipo de operacion va ha realizar nuestra calculadora.
                            switch (dat_calcBase.Almacenamiento[posicionNumero, 2, 1])
                            {
                                //igual
                                case 0:
                                    visualOperaciones += " =";
                                    break;
                                //suma
                                case 1:
                                    visualOperaciones += " +";
                                    break;
                                //resta
                                case 2:
                                    visualOperaciones += " -";
                                    break;
                                //multiplicacion
                                case 3:
                                    visualOperaciones += " *";
                                    break;
                                //division
                                case 4:
                                    visualOperaciones += " /";
                                    break;
                            }
                            continue;
                        }
                        visualOperaciones += " " + dat_calcBase.Almacenamiento[posicionNumero, comaOperacion, valorNumero].ToString();
                    }//FIN TERCERA DIMENSION
                }//FIN SEGUNDA DIMENSION
            }//FIN PRIMERA DIMENSION
            return visualOperaciones;
        }

        public static void numerosBase(int numero)
        {
            cls_calcBase.seleccionAlmacenamiento(3);
            dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, dat_calcBase.Dimension2, dat_calcBase.Dimension3] = numero;
        }

        public static void operacionesBase(int operacion)
        {
            if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 1].HasValue == true)
            {
                cls_calcBase.seleccionAlmacenamiento(4);
                dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, dat_calcBase.Dimension2, dat_calcBase.Dimension3] = operacion;
                cls_calcBase.seleccionAlmacenamiento(1);
            }
        }

        public static void borrado_tipoReturn()
        {
            int? posUltimoNumero = null;
            for (int comaOperacion = 2; comaOperacion < 0; comaOperacion--)
            {
                if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 2, 0].HasValue)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 2, 0] = null;
                    break;
                }
                else if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 0].HasValue && !dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 1].HasValue)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 0] = null;
                    if (dat_calcBase.Dimension1 > 0)
                    {
                        dat_calcBase.Dimension1--;
                    }
                    break;
                }
                for (int valorNumero = 19; valorNumero < 0; valorNumero--)
                {
                    if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, comaOperacion, valorNumero].HasValue)
                    {
                        posUltimoNumero = valorNumero;
                        break;
                    }
                }
                if (posUltimoNumero.HasValue)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, comaOperacion, posUltimoNumero.Value] = null;
                    break;
                }
            }
        }

        public static void borrado_tipoCE()
        {
            for (int comaOperacion = 0; comaOperacion < 3; comaOperacion++)
            {
                if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 2, 0].HasValue)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 2, 0] = null;
                    break;
                }
                else if (dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 0].HasValue && !dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 1].HasValue)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, 0, 0] = null;
                    if (dat_calcBase.Dimension1 > 0)
                    {
                        dat_calcBase.Dimension1--;
                    }
                    break;
                }
                for (int valorNumero = 0; valorNumero < 20; valorNumero++)
                {
                    dat_calcBase.Almacenamiento[dat_calcBase.Dimension1, comaOperacion, valorNumero] = null;
                }
            }
        }

        public static void borrado_tipoC()
        {
            for (int posicionNumero = 0; posicionNumero < 50; posicionNumero++)
            {
                if (posicionNumero > dat_calcBase.Dimension1)
                {
                    break;
                }
                for (int comaOperacion = 0; comaOperacion < 3; comaOperacion++)
                {
                    for (int valorNumero = 0; valorNumero < 20; valorNumero++)
                    {
                        dat_calcBase.Almacenamiento[posicionNumero, comaOperacion, valorNumero] = null;
                    }
                }
            }
            dat_calcBase.Dimension1 = 0;
            dat_calcBase.Dimension2 = 0;
            dat_calcBase.Dimension3 = 0;
        }

    }
}
