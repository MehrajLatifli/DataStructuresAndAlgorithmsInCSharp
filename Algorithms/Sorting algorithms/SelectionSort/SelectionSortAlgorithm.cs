using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelectionSort
{
    public static class SelectionSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            await Task.Run(() =>
            {
                int n = items.Count;

                for (int i = 0; i < n - 1; i++)
                {
            
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (items[j].Id < items[minIndex].Id)
                        {
                            minIndex = j;
                        }
                    }

                
                    T temp = items[minIndex];
                    items[minIndex] = items[i];
                    items[i] = temp;
                }
            });

            return items;
        }
    }
}
