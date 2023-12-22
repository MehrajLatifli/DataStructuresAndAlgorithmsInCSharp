namespace ArrayList
{
    public class CustomArrayList<T>
    {
        private T[] array;

        public CustomArrayList()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > array.Length)
            {
                //throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                Console.WriteLine(" Index is out of range.");
            }
            else
            {
                Array.Resize(ref array, array.Length + 1);
                Array.Copy(array, index, array, index + 1, array.Length - index - 1);
                array[index] = item;

            }

        }


        public void RemoveAt(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine(" Index is out of range.");
            }
            else
            {
                Array.Copy(array, index + 1, array, index, array.Length - index - 1);
                Array.Resize(ref array, array.Length - 1);
            }
        }

        public void Remove(T item)
        {
            int index = IndexOf(item, EqualityComparer<T>.Default);

            if (index != -1)
            {
                RemoveAt(index);
            }
            else
            {
                Console.WriteLine($" {item} not found in the list.");
            }
        }

        private int IndexOf(T item, IEqualityComparer<T> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (comparer.Equals(array[i], item))
                {
                    return i;
                }
            }

            return -1;
        }



        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(array, item) != -1;
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(array, item);
        }

        public void Clear()
        {
            array = new T[0];
        }

        public void Display()
        {
            foreach (T item in array)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
