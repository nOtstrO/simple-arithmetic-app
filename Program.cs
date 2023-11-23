using System;

namespace fhahgh
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int c;

            Console.WriteLine("molq vuvedete stoinost na b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("molq vuvedete stoinost na b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("molq vuvedete stoinost na a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("molq vuvedete stoinost na c");
            c = Convert.ToInt32(Console.ReadLine());

            int D = (b * b - 4 * a * c);
            Console.WriteLine("diskriminaciqta e: " + D + "%");

            if (D <= 0)
            {
                Console.WriteLine("nqma koreni");
            }
            else
            {
                Console.WriteLine("ima koreni");
            }
               
        }
    }
}
