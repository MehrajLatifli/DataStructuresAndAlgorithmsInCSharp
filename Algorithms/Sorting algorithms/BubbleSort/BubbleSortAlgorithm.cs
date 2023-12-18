using Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            await Task.Run(() =>
            {
                int n = items.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (items[j].Id > items[j + 1].Id)
                        {
                            T temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                }
            });

            return items;
        }
    }
}
