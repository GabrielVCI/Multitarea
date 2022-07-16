using System;
using System.Threading;

namespace Multitarea
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(MetodoContador);
            t.Start(); //Sirve para iniciar la tarea simultanea.

            Console.WriteLine("Probando los thread.");
            Thread.Sleep(500);

        }

        static void MetodoContador()
        {
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Incrementando el contador " + contador);
                contador++;
            }
            Thread.Sleep(500);

            Console.WriteLine("Probando los thread en el contador.");
            Thread.Sleep(500);
        }
    }
}
