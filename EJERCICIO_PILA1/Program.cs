using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EJERCICIO_PILA1
{

    class Program
    {
        public static void Main(string[] args)
        {

            ///Crea un programa que pida al usuario 5 numeros enteros 
            ///y luego los muestra en orden contrario, utilizando una pila
            int valores = 0, val = 0;
            Stack miCola = new Stack();  // genera la pila de nombre miCola y la inicia como pila
            for (byte i = 0; i < 5; i++) // arma el bucle para solicitar la pila
            {

                System.Console.WriteLine("Ingrese valor: ");
                val = System.Convert.ToInt32(System.Console.ReadLine());
                miCola.Push(val);    // ingresa numero solicitado con push

            }

            System.Console.WriteLine("LOS VALORES INGRESADOS SON: ");
            for (byte i = 0; i < 5; i++) // arma el bucle para recorrer la pila
            {
                valores = (int)miCola.Pop(); // desencola la pila con Pop
                Console.WriteLine(valores);         // imprime por pantalla

            }
            Console.ReadKey();



        }

    }




}
