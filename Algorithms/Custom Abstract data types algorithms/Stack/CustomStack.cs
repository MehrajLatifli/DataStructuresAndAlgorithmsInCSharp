namespace Stack
{
    public class CustomStack<T>
    {
     
        private const int SIZE = 5;


        private int top;

        private T[] st = new T[SIZE];


        public CustomStack()
        {
            top = -1;
        }


        public void Push(T k)
        {
  
            if (IsFull())
            {
      
                Console.WriteLine(" Stack is full");
                return;
            }


            Console.WriteLine($" Inserted element {k}");


            top = top + 1;

            st[top] = k;
        }


        public bool IsEmpty()
        {
            return top == -1;
        }


        public bool IsFull()
        {

            return top == (SIZE - 1);
        }


        public T Pop()
        {

            T poppedElement = st[top];


            top--;


            return poppedElement;
        }

        public T TopElement()
        {

            T topElement = st[top];

      
            return topElement;
        }

        public void DisplayAll()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" Stack is empty");
                return;
            }

            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($" " +
                    $" Index: {i}, Element: {st[i]}");
            }
        }

    }
}
