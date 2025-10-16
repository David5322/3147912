using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_control
{
    internal class Program
    {
        static void Main(string[] args)        // es el punto de partida
        {
            ////tipos de datos
            //int numero1 = 10;
            //string nombre = "clarent";// string es una cadena de caracteres con comillas sobles
            //char letra = 'c'; // char es un solo caracter con comillas simples
            //decimal precio = 7.99m; // decimal es un numero con decimales y la m al final indica que es decimal
            //float altura = 1.75f; // float es un numero con coma y f l final
            //bool esVerdadero = true; // bool es un valor logico verdadero o falso
            //DateTime fecha = DateTime.Now; // DateTime es una fecha y hora

            ////estructuras de control
            //Console.WriteLine(" ingrese su edad");
            //int numero = int.Parse(Console.ReadLine()); //readline lee lo que el usuario escribe en la consola   
            //Console.WriteLine(" su edad es: " + numero);



            Console.WriteLine(" ingrese la primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese la tercera nota");
            float nota3 = float.Parse(Console.ReadLine());  

            float promedio = (nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f);
            Console.WriteLine(" su promedio es: " + promedio);  

            if (promedio >= 3)
            {
                Console.WriteLine(" aprobado");
            }
            else
            {
                Console.WriteLine(" reprobado");
            }
        }
    }
}
