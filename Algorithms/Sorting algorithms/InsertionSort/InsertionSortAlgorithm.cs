using Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSortAlgorithm
    {
        public static async Task<List<Item>> Sorting(List<Item> items)
        {
            await Task.Run(() =>
            {
                int n = items.Count;

                for (int i = 1; i < n; i++)
                {
                    Item key = items[i];
                    int j = i - 1;

                    while (j >= 0 && items[j].Id > key.Id)
                    {
                        items[j + 1] = items[j];
                        j = j - 1;
                    }

                    items[j + 1] = key;
                }
            });

            return items;
        }
    }
}
