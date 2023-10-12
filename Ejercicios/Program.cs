
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Ejercicio
{
    public static void Main()
    {
        #region video-073

        //Queue<string> cola = new Queue<string>();
        //Console.WriteLine("Escriba el texto que desea almacenar en la cola");
        //Console.WriteLine("y si quiere dejar de agregar contenido, solo debe ingresar un texto nulo");
        //Console.WriteLine("");

        //while (true)
        //{


        //    string datoEnQueue = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (datoEnQueue == "")
        //    {
        //        Console.WriteLine("El contenido de la cola es:");
        //        MostrarQueue(cola);
        //        break;
        //    }
        //    else
        //    {
        //        cola.Enqueue(datoEnQueue);
        //    }
        //}

        //static void MostrarQueue(Queue<string> cola)
        //{
        //    while (cola.Count > 0)
        //    {
        //        string dato = cola.Dequeue();

        //        Console.WriteLine(dato);
        //    }
        //}
        #endregion
        #region video-074

        //Stack<string> pila = new Stack<string>();
        //Console.WriteLine("Escriba el texto que desea almacenar en la pila");
        //Console.WriteLine("y si quiere dejar de agregar contenido, solo debe ingresar un texto nulo");
        //Console.WriteLine("");

        //while (true)
        //{


        //    string datoPila = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (datoPila == "")
        //    {
        //        Console.WriteLine("El contenido de la cola es:");
        //        MostrarStack(pila);
        //        break;
        //    }
        //    else
        //    {
        //        pila.Push(datoPila);
        //    }
        //}

        //static void MostrarStack(Stack<string> pila)
        //{
        //    while (pila.Count > 0)
        //    {
        //        string dato = pila.Pop();

        //        Console.WriteLine(dato);
        //    }
        //}
        #endregion
        #region video-075
        //List<string> lista = new List<string>();
        //Console.WriteLine("ingrese lo que desea guardar en su lista");
        //Console.WriteLine("y si ya quiere dejar de agregar contenido");
        //Console.WriteLine("solo debe apretar 'enter' sin escribir nada");
        //Console.WriteLine("");
        //while (true)
        //{
        //    string texto = Console.ReadLine();
        //    Console.WriteLine("");
        //    if (texto == "")
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        lista.Add(texto);
        //    }
        //}
        //Console.Clear();
        //Console.WriteLine("Para traer un dato de la lista, ponga el numero de la posicion del dato que quiere traer");
        //Console.WriteLine("y si ya no quiere seguir con su busqueda, ingrese '0'");
        //while (true)
        //{

        //    int posicion = Convert.ToInt32(Console.ReadLine());
        //    if (posicion > lista.Count)
        //    {
        //        Console.WriteLine("no hay nada cargado en la posicion" +posicion);
        //    }
        //    else
        //    {
        //        if (posicion == 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"El dato con la posicion '{posicion}' es:" + lista[posicion - 1]);
        //            Console.WriteLine("");

        //            //for (int i = 0; i < lista.Count ; i++)
        //            //{
        //            //    if (i == posicion - 1)
        //            //    {
        //            //        string dato = lista[posicion - 1];
        //            //        Console.WriteLine(dato);
        //            //    }

        //            //}
        //        }
        //    }

        //}   
        #endregion
        #region video-077
        //SortedList<string, string> diccionario = new SortedList<string, string>();
        //diccionario.Add("hola", "hello");
        //diccionario.Add("bienvenido", "welcome");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        //Console.WriteLine("El diccionario puede traducir las siguientes palabras:");

        //foreach (var i in diccionario)
        //{
        //    Console.WriteLine(i.Key);
        //    Console.WriteLine("");
        //}

        //Console.ReadLine();
        //Console.Clear();
        //Console.WriteLine("Escriba la palabra que desea traducir");
        //Console.WriteLine("Y si ya no quiere seguir traduciendo, apriete 'enter' sin escribir nada");
        //Console.WriteLine("");

        //while (true)
        //{
        //    string palabra = Console.ReadLine();
        //    if (palabra == "")
        //    {
        //        break;
        //    }
        //    else
        //    {
        //       Console.WriteLine(diccionario[palabra]);
        //    }
        //}

        #endregion
        #region video-078
        //Dictionary<string, string> diccionario = new Dictionary<string, string>();
        //diccionario.Add("hola", "hello");
        //diccionario.Add("bienvenido", "welcome");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        ////diccionario.Add("", "");
        //Console.WriteLine("El diccionario puede traducir las siguientes palabras:");

        //foreach (var i in diccionario)
        //{
        //    Console.WriteLine(i.Key);
        //    Console.WriteLine("");
        //}

        //Console.ReadLine();
        //Console.Clear();
        //Console.WriteLine("Escriba la palabra que desea traducir");
        //Console.WriteLine("Y si ya no quiere seguir traduciendo, apriete 'enter' sin escribir nada");
        //Console.WriteLine("");

        //while (true)
        //{
        //    string palabra = Console.ReadLine();
        //    if (palabra == "")
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine(diccionario[palabra]);
        //    }
        //}

        #endregion
        #region video-079
        SortedSet<string> listado = new SortedSet <string>();
        Console.WriteLine("Escriba lo que desee guardar en el listado");
        Console.WriteLine("Si ya no quiere agregar cosas, escriba 'terminar'");
        while (true)
        {
           string cosa = Console.ReadLine();

            //se verifica de que lo que esta cargando el usuario no este ya cargado
            for (int i = 0; i < listado.Count; i++)
            {
                if (listado.Contains(cosa))
                {
                    Console.WriteLine("Lo que quiere ingresar ya se encuentra en la lista");
                    i = 0;
                    cosa = Console.ReadLine();
                }

            }

            //Se agrega el contenido al sortedset o se finaliza la carga de texto
            if (cosa != "terminar") 
            {
                listado.Add(cosa);
            }
            else
            {
                break;
            }

        }
        #endregion
    }




}
