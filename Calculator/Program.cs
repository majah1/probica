using Calculator;
using System;

namespace Operacije
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uneti prvi i drugi broj");
            String a = Console.ReadLine();
            // a = 3,4,5,6
            // string [] niz = a.spilt(',')
            // proci kroz niz
            // float [] brojevi.  bro
            String b = Console.ReadLine();
            String str = a + "," + b;
            //float first;
            //float second;
            float third;
            bool thirdConv = float.TryParse(str, out third);
            //bool firstConv = float.TryParse(a,out first);
            //bool secondConv = float.TryParse(b, out second);

            //if (!firstConv || !secondConv)
            if (!thirdConv)
            {
                Console.WriteLine("ne moze");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                Console.WriteLine("izaberi +, -, * ili /");
                String x = Console.ReadLine();
                //Oprerations o = new Oprerations(first, second);
                Oprerations 
                if (x == "+")
                {

                    Console.WriteLine("suma");
                    float sum = o.sabiranje();
                    Console.WriteLine(sum);
                }

                else if (x == "/")
                {
                    Console.WriteLine("deljenje");
                    float del = o.deljenje();

                    Console.WriteLine(del);
                }

                else if (x == "*")
                {
                    Console.WriteLine("mnozenje");
                    float mno = o.mnozenje();
                    Console.WriteLine(mno);

                }

                else if (x=="-")
                {
                    Console.WriteLine("oduzimanje");
                    float odu = o.oduzimanje();
                    Console.WriteLine(odu);
                }
                else
                {
                    Console.WriteLine("nista");
                }
            }

            Console.ReadLine();

        }
    }
}
