using Data;
using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public static class BinarySearchAlgorithm<T> where T : IItem
    {
        public static async Task <int> Search(List<T> items, int x)
        {
            return await BinarySearchRecursive(items, x, 0, items.Count - 1);
        }

        private static async Task <int> BinarySearchRecursive(List<T> items, int target, int left, int right)
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
                    return await BinarySearchRecursive(items, target, middle + 1, right);
                }
                else
                {
                    return await BinarySearchRecursive(items, target, left, middle - 1);
                }
            }

            return -1;
        }
    }
}
