using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList();
            ArrayList al3 = new ArrayList();
            for (int v = 0; v < 5; v++)
            {
                Console.WriteLine("Insira um valor:");
                int val1 = int.Parse(Console.ReadLine());
                al1.Add(val1);
                Console.WriteLine("Insira um valor:");
                int val2 = int.Parse(Console.ReadLine());
                al2.Add(val2);
            }


            for (int v = 0; v < al1.Count; v++)
                al3.Add(Convert.ToInt16(al1[v]) + Convert.ToInt16(al2[v]));

            foreach (var ar in al3)
                Console.Write("   {0}", ar);
            Console.ReadLine();
        }
    }
}
