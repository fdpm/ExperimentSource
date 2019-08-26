using System;
using System.Collections.Generic;
using System.Text;

namespace Taller4.NewFolder
{
    class Merge
    {
        public void merge(int[] list, int l, int m, int r)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            int n1 = m - l + 1;
            int n2 = r - m;

            int[] A = new int[n1];
            int[] B = new int[n2];

            for (i = 0; i < n1; i++) {
                A[i] = list[l + i];
            }
            for (j = 0; j < n2; j++){
                B[j] = list[m + 1 + j];
            }

            i = 0;
            j = 0;
            k = l;

            while (i < n1 && j < n2)
            {
                if (A[i] <= B[j])
                {
                    list[k] = A[i];
                    i++;
                }
                else
                {
                    list[k] = B[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                list[k] = A[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                list[k] = B[j];
                j++;
                k++;
            }

        }

        public void mergeSort(int[] list, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                mergeSort(list, l, m);
                mergeSort(list, m + 1, r);

                merge(list, l, m, r);
            }
        }
    }
}
