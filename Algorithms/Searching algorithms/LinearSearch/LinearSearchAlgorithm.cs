using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public static class LinearSearchAlgorithm
    {

        public static int Search(List<Item> items, int x)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == x)
                    return i;
            }
            return -1;
        }


    }
}
