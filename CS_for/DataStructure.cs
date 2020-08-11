using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DataStructure
{
    class DataStructure
    {
        static void Main(string[] args)
        {
            LinkedList<string> vs = new LinkedList<string>();
            vs.AddFirst("wot fuck");
            Console.WriteLine(vs.First());

            HashSet<string> vs1 = new HashSet<string>();
            vs1.Add("i love you");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i*3);
            }

            Console.ReadLine();

        }
    }
}
