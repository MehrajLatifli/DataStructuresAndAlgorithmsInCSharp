using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FibonacciSearch
{
    public static class FibonacciSearchAlgorithm<T> where T : IItem
    {
        public static async Task<int> Search(List<T> items, int x)
        {
            int n = items.Count;

      
            int fibM_minus_2 = 0;
            int fibM_minus_1 = 1;
            int fibM = fibM_minus_1 + fibM_minus_2;

            while (fibM < n)
            {
                fibM_minus_2 = fibM_minus_1;
                fibM_minus_1 = fibM;
                fibM = fibM_minus_1 + fibM_minus_2;
            }

      
            int offset = -1;

   
            while (fibM > 1)
            {
  
                int i = Math.Min(offset + fibM_minus_2, n - 1);

               
                if (items[i].Id < x)
                {
                    fibM = fibM_minus_1;
                    fibM_minus_1 = fibM_minus_2;
                    fibM_minus_2 = fibM - fibM_minus_1;
                    offset = i;
                }
                
                else if (items[i].Id > x)
                {
                    fibM = fibM_minus_2;
                    fibM_minus_1 -= fibM_minus_2;
                    fibM_minus_2 = fibM - fibM_minus_1;
                }
   
                else
                {
                    return i;
                }
            }

   
            if (fibM_minus_1 == 1 && items[offset + 1].Id == x)
            {
                return offset + 1;
            }

   
            return -1;
        }
    }
}
