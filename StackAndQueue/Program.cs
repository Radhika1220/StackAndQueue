using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Stack Operations-------------");
            string flag = "Y";
            while (flag == "Y" || flag=="y")
            {
                Console.WriteLine("***1.Push Operation***");
                Console.WriteLine("***2.Peek And Pop Operation");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                Stack stack = new Stack();
                switch (num)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Pop();
                        stack.Display();
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag=Console.ReadLine();
            }
        }
    }
}