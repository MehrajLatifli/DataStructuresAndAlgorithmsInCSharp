using Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSortAlgorithm
    {
        public static async Task<List<Item>> Sorting(List<Item> items)
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
                            Item temp = items[j];
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
