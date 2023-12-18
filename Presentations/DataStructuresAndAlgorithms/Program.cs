using BinarySearch;
using BubbleSort;
using Data;
using Graph;
using InsertionSort;
using JumpSearch;
using LinearSearch;
using MergeSort;
using QuickSort;
using RandomData;
using SelectionSort;
using Stack;
using System.Collections.Generic;
using System.Linq;
using TernarySearch;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {

        static async Task Menu(List<Item> items, CustomGraph<Item> itemGraph, CustomStack<Item> customStack, CustomQueue<Item> customQueue)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("\n");
                Console.WriteLine(" 1.  Generate Random Items");
                Console.WriteLine(" 2.  Linear Seach");
                Console.WriteLine(" 3.  Binary Search");
                Console.WriteLine(" 4.  Ternary Search");
                Console.WriteLine(" 5.  Jump Search");
                Console.WriteLine(" 6.  Bubble Sort");
                Console.WriteLine(" 7.  Insertion Sort");
                Console.WriteLine(" 8.  Selection Sort");
                Console.WriteLine(" 9.  Merge Sort");
                Console.WriteLine(" 10. Quick Sort");
                Console.WriteLine(" 11. Custom Graph");
                Console.WriteLine(" 12. Custom Srack");
                Console.WriteLine(" 13. Custom Queue");
                Console.WriteLine(" 0.  Exit");
                Console.Write("\n Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n");
                    switch (choice)
                    {
                        case 1:
                            items = await RandomDataFilling.GenerateItems();

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

                            await Task.CompletedTask;
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

                                    int linearSearchIndex = await LinearSearchAlgorithm<Item>.Search(items, searchId);
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
                            await Task.CompletedTask;
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

                                    int binarySearchIndex = await BinarySearchAlgorithm<Item>.Search(binarylist, searchId);

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
                            await Task.CompletedTask;
                            break;

                        case 4:

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

                                    var ternarylist = new List<Item>();

                                    ternarylist.AddRange(items);


                                    ternarylist.Sort((item1, item2) => item1.Id.CompareTo(item2.Id));

                                    int ternarySearchIndex = await TernarySearchAlgorithm<Item>.Search(ternarylist, 0, items.Count - 1, searchId);

                                    if (ternarySearchIndex != -1)
                                    {
                                        Console.WriteLine($"\n Item with ID {searchId} found at index {items.IndexOf(items.Where(i => i.Id == searchId).FirstOrDefault())}.");
                                        Console.WriteLine($" Id: {ternarylist[ternarySearchIndex].Id}, Name: {ternarylist[ternarySearchIndex].Name}");
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
                            await Task.CompletedTask;
                            break;

                        case 5:

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

                                    var jumplist = new List<Item>();

                                    jumplist.AddRange(items);


                                    jumplist.Sort((item1, item2) => item1.Id.CompareTo(item2.Id));

                                    int jumpSearchIndex = await JumpSearchAlgorithm<Item>.Search(jumplist, searchId);

                                    if (jumpSearchIndex != -1)
                                    {
                                        Console.WriteLine($"\n Item with ID {searchId} found at index {items.IndexOf(items.Where(i => i.Id == searchId).FirstOrDefault())}.");
                                        Console.WriteLine($" Id: {jumplist[jumpSearchIndex].Id}, Name: {jumplist[jumpSearchIndex].Name}");
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
                            await Task.CompletedTask;
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

                                var bubbleSortinglist = await BubbleSortAlgorithm<Item>.Sorting(items);

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

                            await Task.CompletedTask;
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

                                var insertionSortinglist = await InsertionSortAlgorithm<Item>.Sorting(items);

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

                            await Task.CompletedTask;
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

                                var selectionSortinglist = await SelectionSortAlgorithm<Item>.Sorting(items);

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

                            await Task.CompletedTask;
                            break;

                        case 9:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var mergeSortinglist = await MergeSortAlgorithm<Item>.Sorting(items);

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

                            await Task.CompletedTask;
                            break;

                        case 10:

                            if (items.Count() > 0)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    var item = items[i];

                                    Console.WriteLine($" Index: {i} \t Id: {item.Id} \t Name: {item.Name}");
                                }

                                Console.WriteLine("\n");

                                var quickSortinglist = await QuickSortAlgorithm<Item>.Sorting(items);

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

                            await Task.CompletedTask;
                            break;

                        case 11:

                            while (true)
                            {
                                Console.Clear();
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
                                            if (int.TryParse(Console.ReadLine(), out int itemId))
                                            {

                                                Console.Write(" Enter Item Name: ");
                                                string itemName = Console.ReadLine();

                                                Item newItem = new Item { Id = itemId, Name = itemName };
                                                itemGraph.AddVertex(newItem);

                                                await Task.CompletedTask;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }
                                            break;

                                        case 2:
                                            Console.Write(" Enter Source Item Id: ");

                                            // Validate if the input is a valid integer
                                            if (int.TryParse(Console.ReadLine(), out int sourceId))
                                            {
                                                Console.Write(" Enter Destination Item Id: ");

                                                // Validate if the input is a valid integer
                                                if (int.TryParse(Console.ReadLine(), out int destinationId))
                                                {
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
                                                }
                                                else
                                                {
                                                    Console.Clear();

                                                    await Task.CompletedTask;
                                                    Console.WriteLine(" Invalid input for Destination Item Id. Please enter a valid integer.");
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Source Item Id. Please enter a valid integer.");
                                            }

                                            await Task.CompletedTask;
                                            break;


                                        case 3:
                                            Console.Write(" Enter Item Id to remove: ");

                                            // Validate if the input is a valid integer
                                            if (int.TryParse(Console.ReadLine(), out int removeItemId))
                                            {
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
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }

                                            await Task.CompletedTask;
                                            break;


                                        case 4:
                                            Console.Write(" Enter Source Item Id: ");

                                            // Validate if the input is a valid integer
                                            if (int.TryParse(Console.ReadLine(), out int removeSourceId))
                                            {
                                                Console.Write(" Enter Destination Item Id: ");

                                                // Validate if the input is a valid integer
                                                if (int.TryParse(Console.ReadLine(), out int removeDestinationId))
                                                {
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
                                                }
                                                else
                                                {
                                                    Console.Clear();

                                                    await Task.CompletedTask;
                                                    Console.WriteLine(" Invalid input for Destination Item Id. Please enter a valid integer.");
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Source Item Id. Please enter a valid integer.");
                                            }

                                            await Task.CompletedTask;
                                            break;



                                        case 5:
                                            Console.WriteLine(" Graph:");
                                            itemGraph.PrintGraph();
                                            await Task.CompletedTask;
                                            break;

                                        case 6:

                                            Console.Clear();

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue));
                                            task.Wait();

                                            await Task.CompletedTask;
                                            return;
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

                        case 12:

                            while (true)
                            {
                                Console.Clear();
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
                                            if (int.TryParse(Console.ReadLine(), out int itemId))
                                            {

                                                Console.Write(" Enter Item Name: ");
                                                string itemName = Console.ReadLine();

                                                Item newItem = new Item { Id = itemId, Name = itemName };
                                                customStack.Push(newItem);

                                                await Task.CompletedTask;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }
                                            break;


                                        case 2:

                                            Item removedItem = customStack.Pop();

                                            if (removedItem != null)
                                            {
                                                Console.WriteLine($" {removedItem} is removed from stack");
                                            }

                                            await Task.CompletedTask;
                                            break;


                                        case 3:

                                            Console.WriteLine($" Top item is {customStack.TopElement()}");

                                            await Task.CompletedTask;
                                            break;
                                        case 4:
                                            Console.WriteLine("\n");
                                            customStack.DisplayAll();

                                            await Task.CompletedTask;
                                            break;

                                        case 5:

                                            Console.Clear();

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue));
                                            task.Wait();

                                            await Task.CompletedTask;
                                            return;
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

                        case 13:

                            while (true)
                            {
                                Console.Clear();
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

                                            if (int.TryParse(Console.ReadLine(), out int itemId))
                                            {

                                                Console.Write(" Enter Item Name: ");
                                                string itemName = Console.ReadLine();

                                                Item newItem = new Item { Id = itemId, Name = itemName };
                                                customQueue.Enqueue(newItem);

                                                await Task.CompletedTask;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }
                                            break;


                                        case 2:

                                            Item removedItem = customQueue.Dequeue();

                                            if (removedItem != null)
                                            {
                                                Console.WriteLine($" {removedItem} is removed from queue");
                                            }
                                            await Task.CompletedTask;
                                            break;


                                        case 3:

                                            Console.WriteLine($" Top item is {customQueue.Peek()}");

                                            await Task.CompletedTask;
                                            break;

                                        case 4:
                                            Console.WriteLine("\n");
                                            customQueue.DisplayAllItems();

                                            await Task.CompletedTask;
                                            break;
                                        case 5:

                                            Console.Clear();

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue));
                                            task.Wait();

                                            await Task.CompletedTask;
                                            return;
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

                        case 0:
                            Console.WriteLine(" Exiting the program. Goodbye!");
                            await Task.CompletedTask;

                            return;

                        default:
                            Console.WriteLine(" Invalid choice. Please enter a valid option (1-3).");
                            await Task.CompletedTask;
                            break;
                    }
                }
                else
                {
                    Console.Clear();

                    await Task.CompletedTask;
                    Console.WriteLine(" Invalid input. Please enter a valid integer.");
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

            await Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue));
        }
    }
}
