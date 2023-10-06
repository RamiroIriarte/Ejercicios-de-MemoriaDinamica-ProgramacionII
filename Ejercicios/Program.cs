
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        SortedList<string,string> glosario = new SortedList<string,string>();
        glosario.Add("hola", "hello");
        glosario.Add("bienvenido", "welcome");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");
        //glosario.Add("", "");

        string palabra = Console.ReadLine();
        Console.WriteLine(glosario[palabra]);
        #endregion

    }




}
