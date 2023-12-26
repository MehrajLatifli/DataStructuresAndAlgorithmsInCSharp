using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;

namespace PancakeSort
{
    public static class PancakeSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
        
            for (int currSize = items.Count; currSize > 1; --currSize)
            {
               
                int maxIndex = FindMaxIndex(items, currSize);

                if (maxIndex != currSize - 1)
                {
         
                    await FlipAsync(items, maxIndex);

                   
                    await FlipAsync(items, currSize - 1);
                }
            }

            return items;
        }


        private static int FindMaxIndex(List<T> items, int n)
        {
            int maxIndex = 0;
            for (int i = 0; i < n; ++i)
            {
                if (items[i].Id > items[maxIndex].Id)
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }


        private static async Task FlipAsync(List<T> items, int i)
        {
            int start = 0;
            while (start < i)
            {
  
                T temp = items[start];
                items[start] = items[i];
                items[i] = temp;

                start++;
                i--;
            }

            await Task.Delay(100);
        }
    }
}
