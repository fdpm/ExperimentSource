using System;

namespace Taller4.NewFolder
{
    class Main
    {
        private int timeM;
        private int timeI;
        private int[] Merge;
        private int[] insertion;

        public Main(int size)
        {
            Merge = new int[size];
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

    }
}
