using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_problemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1

            //Console.Write("Monto del préstamo: ");
            //double monto = Convert.ToDouble(Console.ReadLine());
            //double tasa = 0.05; 

            //double interesAnual = monto * tasa;
            //double interesTercerTrimestre = monto * tasa * 3.0 / 12.0;
            //double interesPrimerMes = monto * tasa / 12.0;
            //double total5Anios = monto + monto * tasa * 5.0;

            //Console.WriteLine("Interés pagado en 1 año: " + interesAnual);
            //Console.WriteLine("Interés en el 3er trimestre (3 meses): " + interesTercerTrimestre);
            //Console.WriteLine("Interés en el 1er mes: " + interesPrimerMes);
            //Console.WriteLine("Total a pagar en 5 años (capital + intereses simples): " + total5Anios);


            // ejercicio 2

            //Console.Write("Salario: ");
            //double salario = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ahorro mensual programado: ");
            //double ahorro = Convert.ToDouble(Console.ReadLine());

            //double eps = salario * 0.125;
            //double pension = salario * 0.16;
            //double totalDeducciones = eps + pension + ahorro;
            //double neto = salario - totalDeducciones;

            //Console.WriteLine("Salario: " + salario);
            //Console.WriteLine("Ahorro: " + ahorro);
            //Console.WriteLine("EPS (12.5%): " + eps);
            //Console.WriteLine("Pensión (16%): " + pension);
            //Console.WriteLine("Total deducciones: " + totalDeducciones);
            //Console.WriteLine("Total a recibir (neto): " + neto);


            // ejercicio 3: Agenda

            //Console.Write("Nombre: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Edad: ");
            //int edad = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Género (F/M): ");
            //char genero = Convert.ToChar(Console.ReadLine().ToUpper());

            //Console.Write("Teléfono: ");
            //string tel = Console.ReadLine();

            //Persona p = new Persona(nombre, edad, genero, tel);

            //while (true)
            //{
            //    Console.WriteLine("\n1 - Imprimir");
            //    Console.WriteLine("2 - Edad en días");
            //    Console.WriteLine("3 - Editar");
            //    Console.WriteLine("4 - Salir");
            //    Console.Write("Opción: ");
            //    int op = Convert.ToInt32(Console.ReadLine());

            //    if (op == 1)
            //    {
            //        p.ImprimirDetalles();
            //    }
            //    else if (op == 2)
            //    {
            //        p.EdadEnDias();
            //    }
            //    else if (op == 3)
            //    {
            //        Console.Write("Nuevo nombre: ");
            //        p.Nombre = Console.ReadLine();

            //        Console.Write("Nueva edad: ");
            //        p.Edad = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Nuevo género (F/M): ");
            //        p.Genero = Convert.ToChar(Console.ReadLine().ToUpper());

            //        Console.Write("Nuevo teléfono: ");
            //        p.Telefono = Console.ReadLine();

            //        Console.WriteLine("Actualizado.");
            //    }
            //    else if (op == 4)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opción no válida.");
            //    }
            //}
        }
    }

    //class Persona
    //{
    //    public string Nombre;
    //    public int Edad;
    //    public char Genero;
    //    public string Telefono;

    //    public Persona(string nombre, int edad, char genero, string telefono)
    //    {
    //        Nombre = nombre;
    //        Edad = edad;
    //        Genero = genero;
    //        Telefono = telefono;
    //    }

    //    public void ImprimirDetalles()
    //    {
    //        Console.WriteLine("Nombre: " + Nombre);
    //        Console.WriteLine("Edad: " + Edad);
    //        Console.WriteLine("Género: " + Genero);
    //        Console.WriteLine("Teléfono: " + Telefono);
    //    }

    //    public void EdadEnDias()
    //    {
    //        Console.WriteLine("Edad en días (aprox.): " + (Edad * 365));
    //    }
    //}

    //ejercicio 4
    //class Libro
    //{
    //    public string Titulo;
    //    public string Autor;
    //    public string Editorial;
    //    public int Anio;

    //    public Libro(string t, string a, string e, int anio)
    //    {
    //        Titulo = t;
    //        Autor = a;
    //        Editorial = e;
    //        Anio = anio;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Titulo} - {Autor} ({Anio}) - {Editorial}";
    //    }
    //}

    //class Biblioteca
    //{
    //    static void Main()
    //    {
    //        List<Libro> libros = new List<Libro>();

    //        while (true)
    //        {
    //            Console.WriteLine("\n1-Agregar libro  2-Listar libros  3-Buscar por título  4-Salir");
    //            Console.Write("Opción: ");
    //            int op = Convert.ToInt32(Console.ReadLine());

    //            if (op == 1)
    //            {
    //                Console.Write("Título: ");
    //                string t = Console.ReadLine();
    //                Console.Write("Autor: ");
    //                string a = Console.ReadLine();
    //                Console.Write("Editorial: ");
    //                string e = Console.ReadLine();
    //                Console.Write("Año: ");
    //                int an = Convert.ToInt32(Console.ReadLine());
    //                libros.Add(new Libro(t, a, e, an));
    //                Console.WriteLine("Libro agregado.");
    //            }
    //            else if (op == 2)
    //            {
    //                Console.WriteLine("Libros en la biblioteca:");
    //                foreach (var l in libros) Console.WriteLine(l);
    //            }
    //            else if (op == 3)
    //            {
    //                Console.Write("Título a buscar: ");
    //                string q = Console.ReadLine().ToLower();
    //                foreach (var l in libros)
    //                {
    //                    if (l.Titulo.ToLower().Contains(q)) Console.WriteLine(l);
    //                }
    //            }
    //            else break;
    //        }
    //    }
    //}

    //ejercicio 5
    //class Matricula
    //{
    //    static void Main()
    //    {
    //        int[] creditos = { 20, 16, 18, 18, 20 };
    //        double[] descuento = { 0.18, 0.12, 0.10, 0.05, 0.15 };
    //        string[] programas = { "Ingeniería de sistemas", "Psicología", "Economía", "Comunicación Social", "Administración de Empresas" };
    //        const int valorCredito = 200000;

    //        Console.Write("Número de estudiantes a matricular: ");
    //        int n = Convert.ToInt32(Console.ReadLine());

    //        int[] cuentaPorPrograma = new int[5];
    //        int totalCreditos = 0;
    //        double totalSinDescuento = 0;
    //        double totalDescuentos = 0;

    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.WriteLine($"\nEstudiante {i + 1}:");
    //            Console.WriteLine("Programas: 1-Ing.Sistemas 2-Psicología 3-Economía 4-Com.Social 5-Admin");
    //            Console.Write("Ingrese número de programa (1-5): ");
    //            int p = Convert.ToInt32(Console.ReadLine()) - 1;

    //            if (p < 0 || p > 4)
    //            {
    //                Console.WriteLine("Programa inválido, se considera 1.");
    //                p = 0;
    //            }

    //            Console.Write("Forma de pago (E para efectivo, O para online): ");
    //            char pago = Convert.ToChar(Console.ReadLine().ToUpper());

    //            cuentaPorPrograma[p]++;
    //            totalCreditos += creditos[p];

    //            double valorInscripcion = creditos[p] * valorCredito;
    //            totalSinDescuento += valorInscripcion;

    //            double desc = 0;
    //            if (pago == 'E') desc = valorInscripcion * descuento[p];
    //            totalDescuentos += desc;
    //        }

    //        double valorNeto = totalSinDescuento - totalDescuentos;
    //        Console.WriteLine("\nResultados:");
    //        for (int i = 0; i < 5; i++) Console.WriteLine($"{programas[i]}: {cuentaPorPrograma[i]} estudiantes");
    //        Console.WriteLine("Total de créditos inscritos: " + totalCreditos);
    //        Console.WriteLine("Valor total sin descuento: " + totalSinDescuento);
    //        Console.WriteLine("Valor total descuentos aplicados: " + totalDescuentos);
    //        Console.WriteLine("Valor neto de inscripciones: " + valorNeto);
    //    }
    //}

    //ejercicio 6
    //class Computronic
    //{
    //    static void Main()
    //    {
    //        const double pagoBasico = 500000;
    //        Console.Write("Número de empleados: ");
    //        int empleados = Convert.ToInt32(Console.ReadLine());

    //        for (int e = 1; e <= empleados; e++)
    //        {
    //            Console.WriteLine($"\nEmpleado {e}:");
    //            Console.Write("Número de ventas realizadas hoy: ");
    //            int ventas = Convert.ToInt32(Console.ReadLine());

    //            int cnt_menorIgual300 = 0;
    //            int cnt_entre300y800 = 0;
    //            int cnt_mayorIgual800 = 0;
    //            double totalVentasEmpleado = 0;
    //            double totalBonificacion = 0;

    //            for (int i = 0; i < ventas; i++)
    //            {
    //                Console.Write($"Valor venta #{i + 1}: ");
    //                double v = Convert.ToDouble(Console.ReadLine());
    //                if (v <= 300000) cnt_menorIgual300++;
    //                else if (v < 800000) cnt_entre300y800++;
    //                else cnt_mayorIgual800++;

    //                totalVentasEmpleado += v;

    //                double porcentaje = 0;
    //                if (v > 800000) porcentaje = 0.10;
    //                else if (v >= 400001 && v <= 800000) porcentaje = 0.05;
    //                else if (v == 400000) porcentaje = 0.03;

    //                double bon = v * porcentaje;
    //                totalBonificacion += bon;
    //            }

    //            double pagoTotal = pagoBasico + totalBonificacion;
    //            Console.WriteLine($"Empleado {e}: ventas <=300k: {cnt_menorIgual300}, entre 300k y 800k: {cnt_entre300y800}, >=800k: {cnt_mayorIgual800}");
    //            Console.WriteLine($"Total ventas: {totalVentasEmpleado}");
    //            Console.WriteLine($"Bonificaciones: {totalBonificacion}");
    //            Console.WriteLine($"Pago total (básico + bonificaciones): {pagoTotal}");
    //        }
    //    }
    //}

    //ejercicio 7  
    //class Accidentes
    //{
    //    static void Main()
    //    {
    //        Console.Write("Número de conductores registrados: ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int menores30 = 0, hombres = 0, mujeres = 0, hombres12a30 = 0, fueraBogota = 0;

    //        int actual = DateTime.Now.Year;

    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.Write($"Conductor #{i + 1} - Año de nacimiento: ");
    //            int ano = Convert.ToInt32(Console.ReadLine());
    //            Console.Write("Sexo (1-Femenino, 2-Masculino): ");
    //            int sexo = Convert.ToInt32(Console.ReadLine());
    //            Console.Write("Registro carro (1-Bogotá, 2-Otras ciudades): ");
    //            int reg = Convert.ToInt32(Console.ReadLine());

    //            int edad = actual - ano;
    //            if (edad < 30) menores30++;
    //            if (sexo == 2)
    //            {
    //                hombres++;
    //                if (edad >= 12 && edad <= 30) hombres12a30++;
    //            }
    //            else if (sexo == 1) mujeres++;
    //            if (reg == 2) fueraBogota++;
    //        }

    //        double total = n > 0 ? n : 1;
    //        Console.WriteLine($"% conductores menores de 30: {menores30 * 100.0 / total:F2}%");
    //        Console.WriteLine($"% sexo masculino: {hombres * 100.0 / total:F2}%  sexo femenino: {mujeres * 100.0 / total:F2}%");
    //        Console.WriteLine($"% conductores masculinos entre 12 y 30: {hombres12a30 * 100.0 / total:F2}%");
    //        Console.WriteLine($"% carros registrados fuera de Bogotá: {fueraBogota * 100.0 / total:F2}%");
    //    }
    //}

    //ejercicio 8
    //class TikTokBonos
    //{
    //    static void Main()
    //    {
    //        Console.Write("Número de empleados a registrar: ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int hoy = DateTime.Now.Year;
    //        int totalElegibles = 0;
    //        int sumaEdades = 0;
    //        int[] porMes = new int[13];
    //        const int bono = 150000;

    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.Write($"Empleado #{i + 1} - Fecha de nacimiento (yyyy-mm-dd): ");
    //            DateTime fn = DateTime.Parse(Console.ReadLine());
    //            int edad = hoy - fn.Year;
    //            if (DateTime.Now < new DateTime(hoy, fn.Month, fn.Day)) edad--;

    //            if (edad > 18 && edad < 50)
    //            {
    //                totalElegibles++;
    //                sumaEdades += edad;
    //                porMes[fn.Month]++;
    //            }
    //        }

    //        Console.WriteLine($"Empleados elegibles (18<edad<50): {totalElegibles}");
    //        if (totalElegibles > 0)
    //            Console.WriteLine($"Promedio de edades (elegibles): {(sumaEdades * 1.0 / totalElegibles):F2}");

    //        Console.WriteLine("\nDesglose por meses (empleados y dinero en bonos):");
    //        int totalDinero = 0;
    //        for (int m = 1; m <= 12; m++)
    //        {
    //            int empleadosMes = porMes[m];
    //            int dineroMes = empleadosMes * bono;
    //            totalDinero += dineroMes;
    //            Console.WriteLine($"{m} - Empleados: {empleadosMes}  Dinero en bonos: {dineroMes}");
    //        }
    //        Console.WriteLine("Total dinero para bonificaciones: " + totalDinero);
    //    }
    //}

    //ejercicio 9
    class CargaQuimicos
    {
        static void Main()
        {
            const int maxCamiones = 20;
            int camionesDespachados = 0;

            while (camionesDespachados < maxCamiones)
            {
                Console.WriteLine($"\nCamión #{camionesDespachados + 1}:");
                Console.Write("Ingrese capacidad del camión (litros): ");
                int cap = Convert.ToInt32(Console.ReadLine());
                int cargado = 0;

                while (true)
                {
                    Console.Write("Ingrese volumen de la saca (3000-9000) o 0 para terminar este camión: ");
                    int saca = Convert.ToInt32(Console.ReadLine());

                    if (saca == 0)
                    {
                        Console.WriteLine("Operario decidió terminar este camión.");
                        break;
                    }

                    if (saca < 3000 || saca > 9000)
                    {
                        Console.WriteLine("Volumen fuera del rango (3000-9000). Intente otra vez.");
                        continue;
                    }

                    if (cargado + saca > cap)
                    {
                        Console.WriteLine("Si carga esta saca se excede la capacidad. Despachar camión y pasar al siguiente.");
                        break;
                    }
                    else
                    {
                        cargado += saca;
                        Console.WriteLine("Saca cargada. Total cargado: " + cargado);
                    }
                }

                Console.WriteLine($"Camión #{camionesDespachados + 1} despachado con {cargado} litros.");
                camionesDespachados++;
                Console.Write("¿Desea continuar con otro camión? (S/N): ");
                char r = Convert.ToChar(Console.ReadLine().ToUpper());
                if (r != 'S') break;
            }

            Console.WriteLine($"Proceso terminado. Camiones despachados: {camionesDespachados}");
        }
    }
}
