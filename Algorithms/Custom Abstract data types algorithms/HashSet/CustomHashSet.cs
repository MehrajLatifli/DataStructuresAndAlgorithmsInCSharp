using System;

namespace HashSet
{
    public class CustomHashSet<T> 
    {
        private const int DefaultCapacity = 16;
        private T[] items;
        public int count;

        public CustomHashSet()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }


        public bool Add(T item)
        {
            if (Contains(item))
            {
                return false;
            }

            if (count == items.Length)
            {
                ResizeArray();
            }

            items[count] = item;
            count++;

            return true;
        }

        public bool Remove(T item)
        {
            int index = Array.FindIndex(items, i => EqualityComparer<T>.Default.Equals(i, item));

            if (index >= 0)
            {
                // Shift elements to fill the gap
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                items[count - 1] = default(T); // Clear the last element
                count--; // Update count after removing an item

                return true;
            }

            return false;
        }








        public bool Contains(T item)
        {
            return Array.IndexOf(items, item, 0, count) >= 0;
        }

        public void Clear()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }


        public void DisplayAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($" {items[i]} ");
            }
            Console.WriteLine();
        }

        private void ResizeArray()
        {
            int newCapacity = items.Length * 2;
            Array.Resize(ref items, newCapacity);
        }
    }
}
