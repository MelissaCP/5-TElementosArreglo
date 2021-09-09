using System;
using C = System.Console;

namespace _5_TElementosArreglo
{
    /// Practica 5
    /// 5.- Desplegar todos los elementos de un arreglo.

    /// Chávez Pérez Melissa
    /// #M21210035
    class Program
    {
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            //Declaramos arreglo
            int[, ] numeros = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            string[] lenguajes = { "C#", "C", "C++",  "Java", "PHP", "JavaScript", "Python" };

            //Desplegamos variables en string
            C.WriteLine("\n------------------------------------\nImprimiendo arreglo de Lenguajes \n------------------------------------\n");

            foreach (string lenguaje in lenguajes)
            {
                C.WriteLine(lenguaje);
            }

            //Desplegamos variebles de int
            C.WriteLine("\n------------------------------------\nImprimiendo arreglo de Numeros \n------------------------------------\n");
            foreach (var elemento in numeros)
            {
                C.WriteLine(elemento);
            }

             
            C.ReadLine();
        }
         
    }
}
