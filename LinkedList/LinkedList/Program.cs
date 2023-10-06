using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListInfo listInfo = new LinkedListInfo();
            listInfo.Add(56);
            listInfo.Add(57);
            listInfo.Add(58);
            listInfo.Display();
            Console.ReadLine();
        }
    }
}
