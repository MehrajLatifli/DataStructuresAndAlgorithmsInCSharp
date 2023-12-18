using Data;

namespace TernarySearch
{
    public class TernarySearchAlgorithm<T> where T : IItem
    {
        public static async Task<int> Search(List<T> items, int left, int right, int targetId)
        {
            if (left <= right)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;

                if (items[mid1].Id == targetId)
                {
                    return mid1;
                }
                if (items[mid2].Id == targetId)
                {
                    return mid2;
                }

                if (targetId < items[mid1].Id)
                {
                    return await Search(items, left, mid1 - 1, targetId);
                }
                else if (targetId > items[mid2].Id)
                {
                    return await Search(items, mid2 + 1, right, targetId);
                }
                else
                {
                    return await Search(items, mid1 + 1, mid2 - 1, targetId);
                }
            }

            return -1; // Not found
        }
    }
}
