using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListInfo linkedListInfo = new LinkedListInfo();
            linkedListInfo.Add(56);
            linkedListInfo.Add(30);
            linkedListInfo.Add(70);
            linkedListInfo.Display();
            Console.ReadLine();
        }
    }
}
