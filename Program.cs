using EjercicioBuscar_JSVE.Clases;

namespace EjercicioBuscar_JSVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; 

            Console.Write("Ingresa un número a buscar: ");
            int numeroABuscar = Convert.ToInt32(Console.ReadLine());

            int posicion = metodo.BuscarNumero(numeros, numeroABuscar);

            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroABuscar} se encuentra en la posición {posicion} de la lista.");
            }
            else
            {
                Console.WriteLine($"El número {numeroABuscar} no se encuentra en la lista.");
            }

            string[] cadenas = { "Manzana", "Banana", "Cereza", "Damasco", "Fresa" }; 

            Console.Write("Ingresa una cadena a buscar: ");
            string cadenaABuscar = Console.ReadLine();

            int indice = metodo.BuscarCadena(cadenas, cadenaABuscar);

            if (indice != -1)
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' se encuentra en el índice {indice} del arreglo.");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' no se encuentra en el arreglo.");
            }

            int[] numeros2 = { 3, 5, 7, 8, 11, 14, 9, 2, 6, 1 }; 

            int indice2 = metodo.EncontrarPrimerNumeroPar(numeros2);

            if (indice != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {indice2} del arreglo.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún número par en el arreglo.");
            }
           
            static void Main(string[] args)
            {
                int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

                metodo.EncontrarNumerosPares(matriz);
            }
        }
    }
}