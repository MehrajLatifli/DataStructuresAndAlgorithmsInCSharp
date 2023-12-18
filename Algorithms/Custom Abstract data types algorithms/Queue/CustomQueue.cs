using System;

namespace Data
{
    public class CustomQueue<T>
    {
        private T[] queueArray;
        private int front;
        private int rear;

        public CustomQueue()
        {
            const int defaultCapacity = 4;
            queueArray = new T[defaultCapacity];
            front = rear = -1;
        }

        public void Enqueue(T item)
        {
            if (rear == queueArray.Length - 1)
            {

                Array.Resize(ref queueArray, queueArray.Length * 2);
            }

            if (IsEmpty)
            {
                front = 0;
            }

            queueArray[++rear] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                //throw new InvalidOperationException("Queue is empty");

                Console.WriteLine("\n Queue is empty");
                return default(T);
            }
            else
            {


                T item = queueArray[front];

                if (front == rear)
                {
                   
                    front = rear = -1;
                }
                else
                {
                    front++;
                }

                return item;
            }

        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return queueArray[front];
        }

        public void DisplayAllItems()
        {
            if (IsEmpty)
            {
                Console.WriteLine(" Queue is empty");
                return;
            }

            Console.WriteLine( "\n");

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine($" Index: {i}, Item: {queueArray[i]}");
            }
        }


        public int Count
        {
            get { return IsEmpty ? 0 : rear - front + 1; }
        }

        public bool IsEmpty
        {
            get { return front == -1; }
        }
    }
}
