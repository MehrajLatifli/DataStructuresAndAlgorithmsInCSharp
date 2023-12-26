```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Item : IItem, IComparable<Item>
    {
        public Item()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}  ";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Item other = (Item)obj;
            return Id == other.Id && string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ (Name ?? "").GetHashCode(StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(Item? other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}


</br>
</br>

<img src="/cover.jpg" alt="Data Structures & Algorithms"/> 

</br>
</br>

<h2> Searching 🔎 </h2>

<ul style="list-style-type:circle">
 <li> <a href="/Algorithms/Searching%20algorithms/LinearSearch/LinearSearchAlgorithm.cs"> Linear Search </a> </li>
 <li> <a href="/Algorithms/Searching%20algorithms/BinarySearch/BinarySearchAlgorithm.cs"> Binary Search </a> </li>
 <li> <a href="/Algorithms/Searching%20algorithms/TernarySearch/TernarySearchAlgorithm.cs">Ternary Search </a> </li>
 <li> <a href="/Algorithms/Searching%20algorithms/JumpSearch/JumpSearchAlgorithm.cs"> Jump Search </a> </li>
 <li> <a href="/Algorithms/Searching%20algorithms/FibonacciSearch/FibonacciSearchAlgorithm.cs"> Fibonacci Search </a> </li>
</ul>

</br>
</br>

<h2> Sorting ▲▼ </h2>

<ul style="list-style-type:circle">
 <li> <a href="/Algorithms/Sorting%20algorithms/InsertionSort/InsertionSortAlgorithm.cs"> Insertion Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/SelectionSort/SelectionSortAlgorithm.cs"> Selection Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/MergeSort/MergeSortAlgorithm.cs"> Merge Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/QuickSort/QuickSortAlgorithm.cs"> Quick Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/BubbleSort/BubbleSortAlgorithm.cs"> Bubble Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/PancakeSort/PancakeSortAlgorithm.cs"> Pancake Sort </a> </li>
 <li> <a href="/Algorithms/Sorting%20algorithms/BucketSort/BucketSortAlgorithm.cs"> Bucket Sort </a> </li>
</ul>

</br>
</br>

<h2> Abstract data types ✵ </h2>

<ul style="list-style-type:circle">
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/Graph/CustomGraph.cs"> Graph </a> </li>
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/Stack/CustomStack.cs"> Stack </a> </li>
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/Queue/CustomQueue.cs">Queue </a> </li>
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/ArrayList/CustomArrayList.cs"> ArrayList </a> </li>
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/HashSet/CustomHashSet.cs"> HashSet </a> </li>
 <li> <a href="/Algorithms/Custom%20Abstract%20data%20types%20algorithms/LinkedList/CustomLinkedList.cs"> LinkedList </a> </li>
</ul>