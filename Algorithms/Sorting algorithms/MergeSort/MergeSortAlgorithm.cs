using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            await Task.Run(() =>
            {
                MergeSort(items);
            });

            return items;
        }

        static void MergeSort(List<T> items)
        {
            int n = items.Count;

            if (n > 1)
            {
                int mid = n / 2;

                List<T> left = items.GetRange(0, mid);
                List<T> right = items.GetRange(mid, n - mid);

                MergeSort(left);
                MergeSort(right);

                Merge(items, left, right);
            }
        }

        static void Merge(List<T> items, List<T> left, List<T> right)
        {
            int i = 0, j = 0, k = 0;
            int leftCount = left.Count;
            int rightCount = right.Count;

            while (i < leftCount && j < rightCount)
            {
               
                if (left[i].Id < right[j].Id)
                {
                    items[k] = left[i];
                    i++;
                }
                else
                {
                    items[k] = right[j];
                    j++;
                }
                k++;
            }

          
            while (i < leftCount)
            {
                items[k] = left[i];
                i++;
                k++;
            }

           
            while (j < rightCount)
            {
                items[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
