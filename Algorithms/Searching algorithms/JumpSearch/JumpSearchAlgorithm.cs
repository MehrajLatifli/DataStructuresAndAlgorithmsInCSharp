using Data;

namespace JumpSearch
{
    public static class JumpSearchAlgorithm<T> where T : IItem
    {
        public static  async Task<int> Search(List<T> items, int targetId)
        {
            int n = items.Count;
            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (items[Math.Min(step, n) - 1].Id < targetId)
            {
                prev = step;
                step += (int)Math.Sqrt(n);

                if (prev >= n)
                {
                    return -1; 
                }
            }

            while (items[prev].Id < targetId)
            {
                prev++;

                if (prev == Math.Min(step, n))
                {
                    return -1; 
                }
            }

            if (items[prev].Id == targetId)
            {
                return prev;
            }

            return -1;
        }
    }
}
