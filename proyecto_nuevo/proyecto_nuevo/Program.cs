using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_nuevo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[]numeros = new int[3];
            //   for (int i = 0; i < 3; i++)
            //   {
            //       Console.WriteLine("Ingrese un numero:" + (i + 1)+":");
            //       numeros[i] = int.Parse(Console.ReadLine());
            //   }   
            //   Console.WriteLine("\nLos numeros ingresados son:");
            //   foreach (var item in numeros)
            ////       {
            ////       Console.WriteLine(item);
            ////   }
            ////   int suma= 0;
            ////   for (int i = 0; i < 3; i++)
            ////   {
            ////       suma += numeros[i];
            ////   }
            ////   Console.WriteLine("\nLa suma de los numeros es: " + suma);

            //List<int> numeros = new List<int>();
            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);
            //Console.WriteLine("Numeros en la lista:");
            //foreach (int item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            ////acceder  a un elemento por su indice
            //int primernumero = numeros[1];
            //Console.WriteLine($"El numero de la lista es:  + {primernumero}");
            ////modificar un elemento en la lista
            //numeros[2] = 50;
            //Console.WriteLine($"Numeros modificados: {numeros[2]}");

            ////insertar un valor en una posicion especifica  
            //numeros.Insert(2, 15);
            //Console.WriteLine($"Numeros modificaciado: {numeros[2]}");
            ////eliminar un elemento de la lista  
            //numeros.Remove(1); //elimina el elemento en la posicion 1   
            ////eliminar un elemento por su valor 
            //numeros.Remove(10); //elimina el elemento con valor 10


            //EJERCICIO 1
            List<string> nombres = new List<string>();
            List<double> precios = new List<double>();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ DE PRODUCTOS ---");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Actualizar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio del producto: ");
                        double precio = double.Parse(Console.ReadLine());

                        nombres.Add(nombre);
                        precios.Add(precio);
                        Console.WriteLine("Producto agregado correctamente.");
                        break;

                    case 2:
                        Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
                        for (int i = 0; i < nombres.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {nombres[i]} - ${precios[i]}");
                        }
                        if (nombres.Count == 0)
                            Console.WriteLine("No hay productos en la lista.");
                        break;

                    case 3:
                        Console.Write("Número del producto a actualizar: ");
                        int indiceAct = int.Parse(Console.ReadLine()) - 1;
                        if (indiceAct >= 0 && indiceAct < nombres.Count)
                        {
                            Console.Write("Nuevo nombre: ");
                            nombres[indiceAct] = Console.ReadLine();
                            Console.Write("Nuevo precio: ");
                            precios[indiceAct] = double.Parse(Console.ReadLine());
                            Console.WriteLine("Producto actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case 4:
                        Console.Write("Número del producto a eliminar: ");
                        int indiceElim = int.Parse(Console.ReadLine()) - 1;
                        if (indiceElim >= 0 && indiceElim < nombres.Count)
                        {
                            nombres.RemoveAt(indiceElim);
                            precios.RemoveAt(indiceElim);
                            Console.WriteLine("Producto eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 5);
        }

    }
}
