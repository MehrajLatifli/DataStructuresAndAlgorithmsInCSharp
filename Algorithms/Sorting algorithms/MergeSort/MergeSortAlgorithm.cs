﻿using Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSortAlgorithm<T> where T : IItem
    {
        public static async Task<List<T>> Sorting(List<T> items)
        {
            await Task.Run(async () =>
            {
               await MergeSort(items);
            });

            return items;
        }

        static async Task MergeSort(List<T> items)
        {
            int n = items.Count;

            if (n > 1)
            {
                int mid = n / 2;

                List<T> left = items.GetRange(0, mid);
                List<T> right = items.GetRange(mid, n - mid);

                await Task.WhenAll(
                    MergeSort(left),
                    MergeSort(right)
                );

                await Merge(items, left, right);


            }
        }

        static async Task Merge(List<T> items, List<T> left, List<T> right)
        {
            int i = 0, j = 0, k = 0;
            int leftCount = left.Count;
            int rightCount = right.Count;

            while (i < leftCount && j < rightCount)
            {
                if (left[i].Id < right[j].Id)
                {
                    items[k] = left[i];
                    i++;
                }
                else
                {
                    items[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftCount)
            {
                items[k] = left[i];
                i++;
                k++;
            }

            while (j < rightCount)
            {
                items[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
