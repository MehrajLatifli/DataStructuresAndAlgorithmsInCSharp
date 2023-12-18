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
            await Task.Run( async() =>
            {
                 await  QuickSort(items, 0, items.Count - 1); // Wait for the asynchronous sorting to complete.
            });

            return items;
        }

        static async Task QuickSort(List<T> items, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(items, low, high).Result;

                Task.WaitAll(
                    Task.Run(() => QuickSort(items, low, partitionIndex - 1)),
                    Task.Run(() => QuickSort(items, partitionIndex + 1, high))
                );
            }
        }

        static async Task<int> Partition(List<T> items, int low, int high)
        {
            T pivot = items[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (items[j].Id < pivot.Id)
                {
                    i++;
                    await Swap(items, i, j);
                }
            }

            await Swap(items, i + 1, high);
            return i + 1;
        }

        static async Task Swap(List<T> items, int i, int j)
        {
            await Task.Run(() =>
            {
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            });
        }

    }
}
