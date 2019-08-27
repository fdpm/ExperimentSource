using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimento.modelo
{
    public class Insertion
    {
        public void insertionSort(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] > key)
                {
                    arreglo[j + 1] = arreglo[j];
                    j = j - 1;
                }
                arreglo[j + 1] = key;
            }
        }
    }
}
