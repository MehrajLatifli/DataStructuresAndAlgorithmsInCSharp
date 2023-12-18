using BinarySearch;
using BubbleSort;
using Data;
using Graph;
using InsertionSort;
using LinearSearch;
using MergeSort;
using QuickSort;
using RandomData;
using SelectionSort;
using Stack;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {

        static async void Menu(List<Item> items, CustomGraph<Item> itemGraph, CustomStack<Item>  customStack, CustomQueue<Item>  customQueue)
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" 1.  Generate Random Items");
                Console.WriteLine(" 2.  Linear Seach");
                Console.WriteLine(" 3.  Binary Search");
                Console.WriteLine(" 4.  Bubble Sort");
                Console.WriteLine(" 5.  Insertion Sort ");
                Console.WriteLine(" 6.  Selection Sort ");
                Console.WriteLine(" 7.  Merge Sort ");
                Console.WriteLine(" 8.  Quick Sort ");
                Console.WriteLine(" 9.  Custom Graph");
                Console.WriteLine(" 10. Custom Srack");
                Console.WriteLine(" 11. Custom Queue");
                Console.WriteLine(" 0.  Exit");
                Console.Write("\n Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n");
                    switch (choice)
                    {
                        case 1:
                            items = RandomDataFilling.GenerateItems();

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 2:

                            if (items.Count() > 0)
                            {

                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }



                                Console.Write("\n Enter the ID to search: ");
                                if (int.TryParse(Console.ReadLine(), out int searchId))
                                {

                                    int linearSearchIndex = LinearSearchAlgorithm.Search(items, searchId);
                                    if (linearSearchIndex != -1)
                                    {
                                        Console.WriteLine($"\n Item with ID {searchId} found at index {linearSearchIndex}.");
                                        Console.WriteLine($" Id: {items[linearSearchIndex].Id}, Name: {items[linearSearchIndex].Name}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($" Item with ID {searchId} not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(" Invalid input for ID. Please enter a valid integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }
                            break;

                        case 3:

                            if (items.Count() > 0)
                            {
                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }


                                Console.Write("\n Enter the ID to search: ");
                                if (int.TryParse(Console.ReadLine(), out int searchId))
                                {

                                    var binarylist = new List<Item>();

                                    binarylist.AddRange(items);


                                    binarylist.Sort((item1, item2) => item1.Id.CompareTo(item2.Id));

                                    int binarySearchIndex = BinarySearchAlgorithm.Search(binarylist, searchId);

                                    if (binarySearchIndex != -1)
                                    {
                                        Console.WriteLine($"\n Item with ID {searchId} found at index {items.IndexOf(items.Where(i => i.Id == searchId).FirstOrDefault())}.");
                                        Console.WriteLine($" Id: {binarylist[binarySearchIndex].Id}, Name: {binarylist[binarySearchIndex].Name}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($" Item with ID {searchId} not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(" Invalid input for ID. Please enter a valid integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }
                            break;

                        case 4:

              

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var bubbleSortinglist = await BubbleSortAlgorithm.Sorting(items);

                                for (int i = 0; i < bubbleSortinglist.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 5:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var insertionSortinglist = await InsertionSortAlgorithm.Sorting(items);

                                for (int i = 0; i < insertionSortinglist.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 6:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var selectionSortinglist = await SelectionSortAlgorithm.Sorting(items);

                                for (int i = 0; i < selectionSortinglist.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 7:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var mergeSortinglist = await MergeSortAlgorithm.Sorting(items);

                                for (int i = 0; i < mergeSortinglist.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }


                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 8:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var quickSortinglist = await QuickSortAlgorithm.Sorting(items);

                                for (int i = 0; i < quickSortinglist.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }


                            }
                            else
                            {
                                Console.WriteLine($" Item list is null");
                            }

                            break;

                        case 9:

                            while (true)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine(" 1. Add Vertex");
                                Console.WriteLine(" 2. Add Edge");
                                Console.WriteLine(" 3. Remove Vertex");
                                Console.WriteLine(" 4. Remove Edge");
                                Console.WriteLine(" 5. Print Graph");
                                Console.WriteLine(" 6. <- ");
                                Console.Write("\n Enter your choice: ");

                                if (int.TryParse(Console.ReadLine(), out int choice2))
                                {
                                    switch (choice2)
                                    {
                                        case 1:

                                            Console.Write(" Enter Item Id: ");
                                            int itemId = int.Parse(Console.ReadLine());

                                            Console.Write(" Enter Item Name: ");
                                            string itemName = Console.ReadLine();

                                            Item newItem = new Item { Id = itemId, Name = itemName };
                                            itemGraph.AddVertex(newItem);

                                            break;

                                        case 2:
                                            Console.Write(" Enter Source Item Id: ");
                                            int sourceId = int.Parse(Console.ReadLine());

                                            Console.Write(" Enter Destination Item Id: ");
                                            int destinationId = int.Parse(Console.ReadLine());

                                            Data.Item sourceItem = itemGraph.GetVertices().Find(item => item.Id == sourceId);
                                            Data.Item destinationItem = itemGraph.GetVertices().Find(item => item.Id == destinationId);

                                            if (sourceItem != null && destinationItem != null)
                                            {
                                                itemGraph.AddEdge(sourceItem, destinationItem);
                                                Console.WriteLine($" Edge added between {sourceItem.Name} and {destinationItem.Name}.");
                                            }
                                            else
                                            {
                                                Console.WriteLine(" Invalid Item Id(s).");
                                            }
                                            break;

                                        case 3:
                                            Console.Write(" Enter Item Id to remove: ");
                                            int removeItemId = int.Parse(Console.ReadLine());

                                            Data.Item removeItem = itemGraph.GetVertices().Find(item => item.Id == removeItemId);

                                            if (removeItem != null)
                                            {
                                                itemGraph.RemoveVertex(removeItem);
                                                Console.WriteLine($" Vertex with ID {removeItem.Id} removed.");
                                            }
                                            else
                                            {
                                                Console.WriteLine(" Invalid Item Id.");
                                            }
                                            break;

                                        case 4:
                                            Console.Write(" Enter Source Item Id: ");
                                            int removeSourceId = int.Parse(Console.ReadLine());

                                            Console.Write(" Enter Destination Item Id: ");
                                            int removeDestinationId = int.Parse(Console.ReadLine());

                                            Data.Item removeSourceItem = itemGraph.GetVertices().Find(item => item.Id == removeSourceId);
                                            Data.Item removeDestinationItem = itemGraph.GetVertices().Find(item => item.Id == removeDestinationId);

                                            if (removeSourceItem != null && removeDestinationItem != null)
                                            {
                                                itemGraph.RemoveEdge(removeSourceItem, removeDestinationItem);
                                                Console.WriteLine($" Edge removed between {removeSourceItem.Name} and {removeDestinationItem.Name}.");
                                            }
                                            else
                                            {
                                                Console.WriteLine(" Invalid Item Id(s).");
                                            }
                                            break;


                                        case 5:
                                            Console.WriteLine(" Graph:");
                                            itemGraph.PrintGraph();
                                            break;

                                        case 6:

                                            Console.Clear();

                                            Menu(items, itemGraph, customStack, customQueue);
                                            break;
                                    }
                                }

                                Console.WriteLine("\n Press Enter to continue...");
                                Console.ReadKey();
                                Console.Clear();


                            }

                        case 10:

                            while (true)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine(" 1. Push");
                                Console.WriteLine(" 2. Pop");
                                Console.WriteLine(" 3. Top element");
                                Console.WriteLine(" 4. Print Stack");
                                Console.WriteLine(" 5. <- ");
                                Console.Write("\n Enter your choice: ");

                                if (int.TryParse(Console.ReadLine(), out int choice3))
                                {
                                    switch (choice3)
                                    {
                                        case 1:

                                            Console.Write(" Enter Item Id: ");
                                            int itemId = int.Parse(Console.ReadLine());

                                            Console.Write(" Enter Item Name: ");
                                            string itemName = Console.ReadLine();

                                            Item newItem = new Item { Id = itemId, Name = itemName };
                                            customStack.Push(newItem);

                                            break;


                                        case 2:

                                            Item removedItem = customStack.Pop();

                                            Console.WriteLine($" {removedItem} is removed from stack");

                                            break;


                                        case 3:

                                            Console.WriteLine($" Top item is {customStack.TopElement()}");

                                            break;

                                        case 4:
                                            Console.WriteLine("\n");
                                            customStack.DisplayAll();

                                            break;

                                        case 5:

                                            Console.Clear();

                                            Menu(items, itemGraph, customStack, customQueue);
                                            break;
                                    }
                                }

                                Console.WriteLine("\n Press Enter to continue...");
                                Console.ReadKey();
                                Console.Clear();


                            }

                        case 11:

                            while (true)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine(" 1. Enqueue");
                                Console.WriteLine(" 2. Dequeue");
                                Console.WriteLine(" 3. Peek");
                                Console.WriteLine(" 4. Print Queue");
                                Console.WriteLine(" 5. <- ");
                                Console.Write("\n Enter your choice: ");

                                if (int.TryParse(Console.ReadLine(), out int choice3))
                                {
                                    switch (choice3)
                                    {
                                        case 1:

                                            Console.Write(" Enter Item Id: ");
                                            int itemId = int.Parse(Console.ReadLine());

                                            Console.Write(" Enter Item Name: ");
                                            string itemName = Console.ReadLine();

                                            Item newItem = new Item { Id = itemId, Name = itemName };
                                            customQueue.Enqueue(newItem);

                                            break;


                                        case 2:

                                            Item removedItem = customQueue.Dequeue();

                                            Console.WriteLine($" {removedItem} is removed from queue");

                                            break;


                                        case 3:

                                            Console.WriteLine($" Top item is {customQueue.Peek()}");

                                            break;

                                        case 4:
                                            Console.WriteLine("\n");
                                            customQueue.DisplayAllItems();

                                            break;

                                        case 5:

                                            Console.Clear();

                                            Menu(items, itemGraph, customStack, customQueue);
                                            break;
                                    }
                                }

                                Console.WriteLine("\n Press Enter to continue...");
                                Console.ReadKey();
                                Console.Clear();


                            }

                        case 0:
                            Console.WriteLine(" Exiting the program. Goodbye!");
                            return;

                        default:
                            Console.WriteLine(" Invalid choice. Please enter a valid option (1-3).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" Invalid input. Please enter a valid integer.");
                    Console.ReadLine();
                }

                Console.WriteLine("\n Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();
            }


        }

        static async Task Main(string[] args)
        {
            List<Item> items = new List<Item>();
            CustomGraph<Item> itemGraph = new CustomGraph<Item>();
            CustomStack<Item> customStack = new CustomStack<Item>();
            CustomQueue<Item> customQueue = new CustomQueue<Item>();

            await Task.Run(() => Menu(items, itemGraph, customStack, customQueue));
        }
    }
}
