using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSortAlgorithm
    {
        public static async Task<List<Item>> Sorting(List<Item> items)
        {
            await Task.Run(() =>
            {
                QuickSort(items, 0, items.Count - 1);
            });

            return items;
        }

        static void QuickSort(List<Item> items, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(items, low, high);

                QuickSort(items, low, partitionIndex - 1);
                QuickSort(items, partitionIndex + 1, high);
            }
        }

        static int Partition(List<Item> items, int low, int high)
        {
            Item pivot = items[high];
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

        static void Swap(List<Item> items, int i, int j)
        {
            Item temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
