using System;
using System.Collections.Generic;
using System.Collections;

namespace StacksQueuesLists
{
    class Program
    {
        static void Main(string[] args)
        {
                Stack<int> stack = new Stack<int>();
                List<int> list = new List<int>();
                Queue<int> queue = new Queue<int>();
                
                while (true)
                {
                    Console.WriteLine("Enter the number");

                    string anotherNumber = "";
                    bool parse = int.TryParse(Console.ReadLine(), out int number);

                    if (parse)
                    {
                        stack.Push(number);
                        list.Add(number);
                        queue.Enqueue(number);
                        
                        Console.WriteLine("Press Y to add another number");
                        anotherNumber = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Press Y to add another number");
                        anotherNumber = Console.ReadLine();
                    }

                    if (anotherNumber.ToLower() != "y")
                    {
                        break;
                    }
                        
                }

                stack = StackTransforming(stack);

                PrintCollection(stack);
                PrintCollection(list);
                PrintCollection(queue);
                
        }

            static void PrintCollection(IEnumerable collection)
            {
                foreach (object item in collection)
                {
                    Console.WriteLine(item);
                }
            }

            static Stack<int> StackTransforming(Stack<int> st)
            {
                Stack<int> tempStack = new Stack<int>();
                foreach (int item in st)
                {
                    tempStack.Push(item);
                }
                return tempStack;
            }
        }
    }