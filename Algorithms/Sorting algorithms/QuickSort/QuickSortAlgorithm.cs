using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            await Task.Run(() =>
            {
                QuickSort(items, 0, items.Count - 1);
            });

            return items;
        }

        static void QuickSort(List<T> items, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(items, low, high);

                QuickSort(items, low, partitionIndex - 1);
                QuickSort(items, partitionIndex + 1, high);
            }
        }

        static int Partition(List<T> items, int low, int high)
        {
            T pivot = items[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (items[j].Id < pivot.Id)
                {
                    i++;
                    Swap(items, i, j);
                }
            }

            Swap(items, i + 1, high);
            return i + 1;
        }

        static void Swap(List<T> items, int i, int j)
        {
            T temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
