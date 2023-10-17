using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBuscar_JSVE.Clases
{
    internal class metodo
    {
        public static int BuscarNumero(int[] array, int numero)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BuscarCadena(string[] array, string cadena)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == cadena)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int EncontrarPrimerNumeroPar(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void EncontrarNumerosPares(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("Posiciones de números pares en la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        Console.WriteLine($"Fila {i}, Columna {j}: {matriz[i, j]}");
                    }
                }
            }
        }
    }
}
