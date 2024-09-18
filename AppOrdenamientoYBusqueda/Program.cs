using System;

namespace AppOrdenamientoYBusqueda
{
    internal class Program
    {
        // Método Merge Sort principal
        public static void MergeSort(int[] arr, int izq, int der)
        {
            if (izq < der)
            {
                // Encuentra el punto medio del arreglo
                int medio = (izq + der) / 2;

                // Ordena la primera y la segunda mitad
                MergeSort(arr, izq, medio);
                MergeSort(arr, medio + 1, der);

                // Fusiona las mitades ordenadas
                Merge(arr, izq, medio, der);
            }
        }

        // Método que realiza la fusión
        public static void Merge(int[] arr, int izq, int medio, int der)
        {
            int n1 = medio - izq + 1;
            int n2 = der - medio;

            // Arreglos temporales
            int[] IzqArr = new int[n1];
            int[] DerArr = new int[n2];

            // Copiar los datos a los arreglos temporales
            for (int i = 0; i < n1; i++)
                IzqArr[i] = arr[izq + i];
            for (int j = 0; j < n2; j++)
                DerArr[j] = arr[medio + 1 + j];

            // Fusionar los arreglos temporales
            int iIndex = 0, jIndex = 0;
            int k = izq;
            while (iIndex < n1 && jIndex < n2)
            {
                if (IzqArr[iIndex] <= DerArr[jIndex])
                {
                    arr[k] = IzqArr[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[k] = DerArr[jIndex];
                    jIndex++;
                }
                k++;
            }

            // Copiar los elementos restantes de IzqArr si los hay
            while (iIndex < n1)
            {
                arr[k] = IzqArr[iIndex];
                iIndex++;
                k++;
            }

            // Copiar los elementos restantes de DerArr si los hay
            while (jIndex < n2)
            {
                arr[k] = DerArr[jIndex];
                jIndex++;
                k++;
            }
        }

        public static void Mostrar(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82 }; // Ejemplo de 6 elementos

            Console.WriteLine("Arreglo original:");
            Mostrar(arr);

            // Ordenar el arreglo con Merge Sort
            MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Arreglo ordenado:");
            Mostrar(arr);

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
