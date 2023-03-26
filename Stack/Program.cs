using Stack.Services;
using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Command> undo = new Stack<Command>();
            Stack<Command> redo = new Stack<Command>();
            string line;
            while (true)
            {
                Console.Write("Url ('exit' to quit):");
                line = Console.ReadLine().ToLower();
                if (line == "exit")
                {
                    break;
                }
                else if (line == "back")
                {
                    //If User Click back button so pop this element but push it to forward 
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        redo.Push(item);

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    //If User Click back button so pop this element but push it to forward 
                    if (undo.Count > 0)
                    {
                        var item = redo.Pop();
                        undo.Push(item);

                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    //User enter new url
                    //So We Will Add It To undo list
                    undo.Push(new Command(line));
                }
                Console.Clear();
                Print("Back", undo);
                Print("Forward", redo);

            }//End Of While
        }//End Of Main
        static void Print(string name, Stack<Command> commands)
        {
            Console.WriteLine($"{name} History");
            Console.BackgroundColor = name.ToLower()  == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var item in commands)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
