using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimento.modelo
{
    public class ExpPrincipal
    {
        public int[] arregloOrdenar { get; set; }
        public Merge merge { get; set; }
        public Insertion insertion { get; set; }

        public ExpPrincipal(int size) {
            arregloOrdenar = new int[size];
            merge = new Merge();
            insertion = new Insertion();
        }

        public void shuffle(int[] list)
        {
            int n = list.Length;
            Random r = new Random();
            for (int i = n-1; i > 0; i--)
            {
                int num = r.Next(0,(n+1));
                list[i] = num;
            }
        }

        public void statusDown(int[] x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                x[i] = n-i;
            }
        }

        public void orderUpward(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

    }
}
