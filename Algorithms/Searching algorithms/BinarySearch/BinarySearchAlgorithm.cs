using Data;
using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public static class BinarySearchAlgorithm
    {
        public static int Search(List<Item> items, int x)
        {
            return BinarySearchRecursive(items, x, 0, items.Count - 1);
        }

        private static int BinarySearchRecursive(List<Item> items, int target, int left, int right)
        {

            if (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (items[middle].Id == target)
                {
                    return middle;
                }
                else if (items[middle].Id < target)
                {
                    return BinarySearchRecursive(items, target, middle + 1, right);
                }
                else
                {
                    return BinarySearchRecursive(items, target, left, middle - 1);
                }
            }

            return -1;
        }
    }
}
