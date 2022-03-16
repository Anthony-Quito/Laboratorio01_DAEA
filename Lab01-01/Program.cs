using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] 10 primeros números primos");
                Console.WriteLine("[7] Conversión a C°");
                Console.WriteLine("[8] Conversión a F°");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multi(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", g, h, Divi(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando primos...");
                        Primo();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en F° : ");
                        int i= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión de {0} °F a grados Celsius es {1} °C",i , Centigrados(i));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en C° : ");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión de {0} °C a grados Farenheit es {1} °F", j, Farenheit(j));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }


        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Función para calcular la multiplicación de 2 números enteros
        static int Multi(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la división de 2 números enteros
        static int Divi(int a, int b)
        {
            return a / b;
        }



        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Procedimiento que imprime los 10 primeros números primos
        static void Primo() 
        {
            int number = 2, divisible = 0;
            while (number <= 32)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisible++;
                    }
                    if (divisible > 2)
                    {
                        break;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("{0} es primo.", number);
                }
                divisible = 0;
                number++;
            }
        }

        //Función para calcular la temperatura en °C
        static int Centigrados(int a)
        {
            return (5*(a-32))/9;
        }


        //Función para calcular la temperatura en °F
        static int Farenheit(int a)
        {
            return ((9 * a) / 5) + 32;
        }

    }
}
