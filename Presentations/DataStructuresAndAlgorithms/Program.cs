using ArrayList;
using BinarySearch;
using BubbleSort;
using Data;
using FibonacciSearch;
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

        static async Task Menu(List<Item> items, CustomGraph<Item> itemGraph, CustomStack<Item> customStack, CustomQueue<Item> customQueue, CustomArrayList<Item> customArrayList)
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
                Console.WriteLine(" 6.  Fibonacci Search");
                Console.WriteLine(" 7.  Bubble Sort");
                Console.WriteLine(" 8.  Insertion Sort");
                Console.WriteLine(" 9.  Selection Sort");
                Console.WriteLine(" 10. Merge Sort");
                Console.WriteLine(" 11. Quick Sort");
                Console.WriteLine(" 12. Custom Graph");
                Console.WriteLine(" 13. Custom Srack");
                Console.WriteLine(" 14. Custom Queue");
                Console.WriteLine(" 15. Custom ArrayList");
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


                                Console.Write("\n Enter the ID to search: ");
                                if (int.TryParse(Console.ReadLine(), out int searchId))
                                {

                                    var fibonaccilist = new List<Item>();

                                    fibonaccilist.AddRange(items);


                                    fibonaccilist.Sort((item1, item2) => item1.Id.CompareTo(item2.Id));

                                    int fibonacciSearchIndex = await FibonacciSearchAlgorithm<Item>.Search(fibonaccilist, searchId);

                                    if (fibonacciSearchIndex != -1)
                                    {
                                        Console.WriteLine($"\n Item with ID {searchId} found at index {items.IndexOf(items.Where(i => i.Id == searchId).FirstOrDefault())}.");
                                        Console.WriteLine($" Id: {fibonaccilist[fibonacciSearchIndex].Id}, Name: {fibonaccilist[fibonacciSearchIndex].Name}");
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

                        case 7:



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

                        case 8:

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

                        case 9:

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

                        case 10:

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

                        case 11:

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

                        case 12:

                            while (true)
                            {

                                itemGraph = new CustomGraph<Item>();

                                itemGraph.AddVertex(new Item { Id = 1, Name = "A" });
                                itemGraph.AddVertex(new Item { Id = 2, Name = "B" });
                                itemGraph.AddVertex(new Item { Id = 3, Name = "C" });
                                itemGraph.AddVertex(new Item { Id = 4, Name = "D" });
                                itemGraph.AddVertex(new Item { Id = 5, Name = "E" });
                                itemGraph.AddVertex(new Item { Id = 6, Name = "F" });
                                itemGraph.AddVertex(new Item { Id = 7, Name = "H" });
                                itemGraph.AddVertex(new Item { Id = 8, Name = "I" });


                                Item sourceItem_1 = itemGraph.GetVertices().Find(item => item.Id == 1);
                                Item destinationItem_1 = itemGraph.GetVertices().Find(item => item.Id == 8);
                                itemGraph.AddEdge(sourceItem_1, destinationItem_1);

                                Item sourceItem_2 = itemGraph.GetVertices().Find(item => item.Id == 1);
                                Item destinationItem_2 = itemGraph.GetVertices().Find(item => item.Id == 2);
                                itemGraph.AddEdge(sourceItem_2, destinationItem_2);

                                Item sourceItem_3 = itemGraph.GetVertices().Find(item => item.Id == 1);
                                Item destinationItem_3 = itemGraph.GetVertices().Find(item => item.Id == 5);
                                itemGraph.AddEdge(sourceItem_3, destinationItem_3);

                                Item sourceItem_4 = itemGraph.GetVertices().Find(item => item.Id == 2);
                                Item destinationItem_4 = itemGraph.GetVertices().Find(item => item.Id == 3);
                                itemGraph.AddEdge(sourceItem_4, destinationItem_4);

                                Item sourceItem_5 = itemGraph.GetVertices().Find(item => item.Id == 2);
                                Item destinationItem_5 = itemGraph.GetVertices().Find(item => item.Id == 4);
                                itemGraph.AddEdge(sourceItem_5, destinationItem_5);

                                Item sourceItem_6 = itemGraph.GetVertices().Find(item => item.Id == 3);
                                Item destinationItem_6 = itemGraph.GetVertices().Find(item => item.Id == 5);
                                itemGraph.AddEdge(sourceItem_6, destinationItem_6);

                                Item sourceItem_7 = itemGraph.GetVertices().Find(item => item.Id == 3);
                                Item destinationItem_7 = itemGraph.GetVertices().Find(item => item.Id == 7);
                                itemGraph.AddEdge(sourceItem_7, destinationItem_7);

                                Item sourceItem_8 = itemGraph.GetVertices().Find(item => item.Id == 5);
                                Item destinationItem_8 = itemGraph.GetVertices().Find(item => item.Id == 6);
                                itemGraph.AddEdge(sourceItem_8, destinationItem_8);

                                Item sourceItem_9 = itemGraph.GetVertices().Find(item => item.Id == 5);
                                Item destinationItem_9 = itemGraph.GetVertices().Find(item => item.Id == 7);
                                itemGraph.AddEdge(sourceItem_9, destinationItem_9);

                                Item sourceItem_10 = itemGraph.GetVertices().Find(item => item.Id == 6);
                                Item destinationItem_10 = itemGraph.GetVertices().Find(item => item.Id == 7);
                                itemGraph.AddEdge(sourceItem_10, destinationItem_10);



                                Console.Clear();
                                Console.WriteLine("\n");
                                Console.WriteLine(" 1. Add Vertex");
                                Console.WriteLine(" 2. Add Edge");
                                Console.WriteLine(" 3. Remove Vertex");
                                Console.WriteLine(" 4. Remove Edge");
                                Console.WriteLine(" 5. Print Graph");
                                Console.WriteLine(" 6. Depth First Search");
                                Console.WriteLine(" 7. Breadth First Search");
                                Console.WriteLine(" 8. <- ");
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
                                                    Item sourceItem = itemGraph.GetVertices().Find(item => item.Id == sourceId);
                                                    Item destinationItem = itemGraph.GetVertices().Find(item => item.Id == destinationId);

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
                                            Console.WriteLine("\n");
                                            itemGraph.PrintGraph();

                                            Console.WriteLine("\n");
                                            Console.WriteLine(" Depth First Search:");
                                      
                                            Console.WriteLine("\n");

                                            itemGraph.DepthFirstSearchTraversal(sourceItem_1);

                                            Console.WriteLine("\n");

                                            await Task.CompletedTask;
                                            break;

                                        case 7:
                                            Console.WriteLine("\n");
                                            itemGraph.PrintGraph();

                                            Console.WriteLine("\n");

                                            Console.WriteLine( " Breadth First Search:");

                                            Console.WriteLine("\n");

                                            itemGraph.BreadthFirstSearchTraversal(sourceItem_1);

                                            Console.WriteLine("\n");

                                            await Task.CompletedTask;
                                            break;

                                        case 8:

                                            Console.Clear();

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue, customArrayList));
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

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue, customArrayList));
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

                        case 14:

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

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue, customArrayList));
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

                        case 15:

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\n");
                                Console.WriteLine(" 1. Add");
                                Console.WriteLine(" 2. Insert");
                                Console.WriteLine(" 3. Remove");
                                Console.WriteLine(" 4. RemoveAt");
                                Console.WriteLine(" 5. Count");
                                Console.WriteLine(" 6. Clear");
                                Console.WriteLine(" 7. Display");
                                Console.WriteLine(" 8. <- ");
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
                                                customArrayList.Add(newItem);

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

                                            Console.Write(" Enter Item Id: ");

                                            if (int.TryParse(Console.ReadLine(), out int itemId2))
                                            {

                                                Console.Write(" Enter Item Name: ");
                                                string itemName2 = Console.ReadLine();

                                                Console.Write(" Enter Index: ");
                                                if (int.TryParse(Console.ReadLine(), out int index))
                                                {
                                                    Item newItem = new Item { Id = itemId2, Name = itemName2 };
                                                    customArrayList.Insert(index, newItem);
                                                }

                                                else
                                                {
                                                    Console.Clear();

                                                    await Task.CompletedTask;
                                                    Console.WriteLine(" Invalid input for Index. Please enter a valid integer.");
                                                }

                                                await Task.CompletedTask;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }
                                            break;


                                        case 3:

                                            Console.Write(" Enter Item Id: ");

                                            if (int.TryParse(Console.ReadLine(), out int itemId3))
                                            {

                                                Console.Write(" Enter Item Name: ");
                                                string itemName = Console.ReadLine();

                                                Item removeItem = new Item { Id = itemId3, Name = itemName };


                                                if(removeItem!=null)
                                                {
                                                    customArrayList.Remove(removeItem);
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" Invalid input for Item. Please enter a valid object.");
                                                }

                                                await Task.CompletedTask;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                await Task.CompletedTask;
                                                Console.WriteLine(" Invalid input for Item Id. Please enter a valid integer.");
                                            }
                                            break;


                                        case 4:

                                      
                                                Console.Write(" Enter Index: ");
                                                if (int.TryParse(Console.ReadLine(), out int index2))
                                                {
                                                  
                                                    customArrayList.RemoveAt(index2);
                                                }

                                                else
                                                {
                                                    Console.Clear();

                                                    await Task.CompletedTask;
                                                    Console.WriteLine(" Invalid input for Index. Please enter a valid integer.");
                                                }

                                                await Task.CompletedTask;
                                      
                                            break;

                                        case 5:
                                            Console.WriteLine(" Length of Arraylist: " + customArrayList.Count);

                                            await Task.CompletedTask;
                                            break;

                                        case 6:
                                            Console.WriteLine("\n");

                                            customArrayList.Clear();

                                            await Task.CompletedTask;
                                            break;

                                        case 7:
                                            Console.WriteLine("\n");

                                            customArrayList.Display();

                                            await Task.CompletedTask;
                                            break;

                                        case 8:

                                            Console.Clear();

                                            var task = Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue, customArrayList));
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
            CustomArrayList<Item> customArrayList  = new CustomArrayList<Item>();

            await Task.Run(async () => await Menu(items, itemGraph, customStack, customQueue, customArrayList));
        }
    }
}
