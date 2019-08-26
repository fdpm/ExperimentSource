using System;
using System.Collections.Generic;
using System.Text;

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

        public void statusDown(int[] x, int[] y)
        {
            int n = x.length;
            int m = y.length;

            for (int i = 0; i < x.length; i++) {
                x[i] = n--;
                y[i] = m--;
            }
        }
    }
}
