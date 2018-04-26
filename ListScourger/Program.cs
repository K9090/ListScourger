using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListScourger
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> almostIntactList = new List<int>();

            int j = 0;

            for (int i = 1; i < 101; i++)
            {
                almostIntactList.Add(i);
            }

            almostIntactList.RemoveAt(rnd.Next(0, 100));

            Console.Write("| ");
            foreach (int item in almostIntactList)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();

            foreach (int item in almostIntactList)
            {
                j++;
                if (item != j)
                {
                    Console.WriteLine("The missing link: " + (item - 1));
                    j++;
                }
            }
        }
    }
}
