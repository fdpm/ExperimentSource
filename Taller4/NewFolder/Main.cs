using System;

namespace Taller4.NewFolder
{
    class Main
    {
        private int timeM;
        private int timeI;
        private int[] merge;
        private int[] insertion;

        public Main(int size)
        {
            merge = new int[size];
            insertion = new int[size];
        }

        private void shuffle(int[] list)
        {
            Random r = new Random();
            for (int i = list.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = list[j];
                list[j] = list[i - 1];
                list[i - 1] = k;
            }
        }



        public void statusDown(int[] x, int[] y)
        {
            int n = x.Length;
            int m = y.Length;

            for (int i = 0; i < x.Length; i++) {
                x[i] = n--;
                y[i] = m--;
            }
        }

        public void orderUpward(int[] array, int[] array2)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                array2[i] = i;
            }
        }

    }
}
