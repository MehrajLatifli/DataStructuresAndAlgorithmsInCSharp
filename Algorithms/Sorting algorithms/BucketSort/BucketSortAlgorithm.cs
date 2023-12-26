using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;

namespace BucketSort
{


    public static class BucketSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            if (items == null || items.Count <= 1)
                return items;

           
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            foreach (var item in items)
            {
                maxValue = Math.Max(maxValue, item.Id);
                minValue = Math.Min(minValue, item.Id);
            }

            int bucketCount = items.Count;


            List<T>[] buckets = new List<T>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<T>();
            }

      
            foreach (var item in items)
            {
                int value = item.Id;
                int index = (int)((value - minValue) / (maxValue - minValue) * (bucketCount - 1));
                buckets[index].Add(item);
            }

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i].Sort((x, y) => x.Id.CompareTo(y.Id));
            }

            items.Clear();
            foreach (var bucket in buckets)
            {
                items.AddRange(bucket);
            }

            return items;
        }
    }
}
