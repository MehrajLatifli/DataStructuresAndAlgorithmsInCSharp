using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSortAlgorithm
    {
        public static async Task<List<Item>> Sorting(List<Item> items)
        {
            await Task.Run(() =>
            {
                MergeSort(items);
            });

            return items;
        }

        static void MergeSort(List<Item> items)
        {
            int n = items.Count;

            if (n > 1)
            {
                int mid = n / 2;

                List<Item> left = items.GetRange(0, mid);
                List<Item> right = items.GetRange(mid, n - mid);

                MergeSort(left);
                MergeSort(right);

                Merge(items, left, right);
            }
        }

        static void Merge(List<Item> items, List<Item> left, List<Item> right)
        {
            int i = 0, j = 0, k = 0;
            int leftCount = left.Count;
            int rightCount = right.Count;

            while (i < leftCount && j < rightCount)
            {
                // Compare and merge
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

            // Copy the remaining elements of left, if any
            while (i < leftCount)
            {
                items[k] = left[i];
                i++;
                k++;
            }

            // Copy the remaining elements of right, if any
            while (j < rightCount)
            {
                items[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
