using System;

namespace Data
{
    public class CustomLinkedList<T> where T : IComparable<T>
    {
        private Node head;

        public void AddItem(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void RemoveItem(T data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous == null)
                    {
               
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

         
                }

                previous = current;
                current = current.Next;
            }
        }

        public T Search(T data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return data;
                }

                current = current.Next;
            }

            return data;
        }

        public void Sort()
        {
            head = MergeSort(head);
        }

        public void Clear()
        {
            head = null;
        }

        private Node MergeSort(Node start)
        {
            if (start == null || start.Next == null)
                return start;

            Node middle = GetMiddle(start);
            Node nextOfMiddle = middle.Next;
            middle.Next = null;

            Node left = MergeSort(start);
            Node right = MergeSort(nextOfMiddle);

            return Merge(left, right);
        }

        private Node Merge(Node left, Node right)
        {
            Node result = null;

            if (left == null)
                return right;
            if (right == null)
                return left;

            if (left.Data.CompareTo(right.Data) <= 0)
            {
                result = left;
                result.Next = Merge(left.Next, right);
            }
            else
            {
                result = right;
                result.Next = Merge(left, right.Next);
            }

            return result;
        }

        public void DisplayList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        private class Node
        {
            public T Data { get; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node GetMiddle(Node start)
        {
            if (start == null)
                return start;

            Node slow = start;
            Node fast = start;

            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
