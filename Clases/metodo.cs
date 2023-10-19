using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBuscar_JSVE.Clases
{
    internal class metodo
    {
        public void Actv1()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Ingrese el número a buscar:");
            int NumeroBuscar = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (NumeroBuscar == num[i])
                {
                    Console.WriteLine($"El número {NumeroBuscar} se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {NumeroBuscar} no se encuentra en la lista.");
            }
        }

        public void Actv2()
        {
            string[] cadena = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };

            Console.WriteLine("A continuacion ingresaras números del Uno al Cinco pero con letra");
            Console.WriteLine("Ingrese la cadena a buscar:");
            string cadenaBuscar = Console.ReadLine();

            bool encontrada = false;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadenaBuscar == cadena[i])
                {
                    Console.WriteLine($"La cadena '{cadenaBuscar}' se encuentra en la posición {i}.");
                    encontrada = true;
                    break;
                }
            }

            if (!encontrada)
            {
                Console.WriteLine($"La cadena '{cadenaBuscar}' no se encuentra en la lista.");
            }


        }

        public void Actv3()
        {
            int[] arreglo = { 2, 5, 7, 8, 12, 15, 21, 24 };

            int posicionpar = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    posicionpar = i;
                    break;
                }
            }

            if (posicionpar != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {posicionpar}.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }

        public void Actv4()
        {
            int[] num = { 3, 7, 1, 4, 8, 2, 6, 9, 10, 4 };

            Console.WriteLine("Posiciones de números pares en la matriz:");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par {num[i]} en la posición {i}.");
                }
            }
        }

        public void Actv5()
        {
            int[] orden = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Poner el número a buscar:");
            int numeroBuscar = Convert.ToInt32(Console.ReadLine());

            int inicio = 0;
            int fin = orden.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (orden[medio] == numeroBuscar)
                {
                    posicion = medio;
                    break;
                }
                else if (orden[medio] < numeroBuscar)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El numero {numeroBuscar} se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"El numero {numeroBuscar} no se encuentra en el arreglo.");
            }
        }

        public void Actv6()
        {
            string[] cadena = { "Manzana", "Naranja", "Pera", "Uva", "Zanahoria" };

            Console.WriteLine("Ingrese la cadena a buscar:");
            string encontrar = Console.ReadLine();

            int inicio = 0;
            int fin = cadena.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (cadena[medio] == encontrar)
                {
                    posicion = medio;
                    break;
                }
                else if (string.Compare(cadena[medio], encontrar) < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"La cadena '{encontrar}' se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"La cadena '{encontrar}' no se encuentra en el arreglo.");
            }

        }

        public void Actv7()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int inicio = 0;
            int fin = num.Length - 1;
            int numPar = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (num[medio] % 2 == 0)
                {
                    if (medio == 0 || num[medio - 1] % 2 != 0)
                    {
                        numPar = medio;
                        break;
                    }
                    else
                    {
                        fin = medio - 1; 
                    }
                }
                else
                {
                    inicio = medio + 1; 
                }
            }

            if (numPar != -1)
            {
                Console.WriteLine("La posición del primer número par es: " + numPar);
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }
    }
}
