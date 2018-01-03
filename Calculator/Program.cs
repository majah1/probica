using Calculator;
using System;
using System.Collections.Generic;

namespace Operacije
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uneti prvi i drugi broj razmaknute zarezom");
            //String a = Console.ReadLine();
            //a = 3,4,5,6
            string[] niz = Console.ReadLine().Split(',');
            // proci kroz niz
            List<float> brojevi = new List<float>();
            //String b = Console.ReadLine();
            // 2,3,,b,9
            for (int i = 0; i < niz.Length; i++) {
                float first;
                bool firstConv = float.TryParse(niz[i], out first);

                if (!firstConv)
                {
                    Console.WriteLine("ne moze");
                    Console.ReadLine();
                    return;
                }
                brojevi.Add(first);
            }
            
            //float second;
            //float first;
            //bool firstConv = float.TryParse(niz[0], out first);
            //bool secondConv = float.TryParse(niz[1], out second);
            //brojevi.Add(first); brojevi.Add(second);

            

            while (true)
            {
                Console.WriteLine("izaberi +, -, * ili /");
                String x = Console.ReadLine();
                Oprerations o = new Oprerations(brojevi);
                if (x == "+")
                {

                    Console.WriteLine("suma");
                    float sum = o.sabiranje();
                    Console.WriteLine(sum);
                }

                else if (x == "/")
                {
                    Console.WriteLine("deljenje");
                 //   float del = o.deljenje();

                //    Console.WriteLine(del);
                }

                else if (x == "*")
                {
                    Console.WriteLine("mnozenje");
                 //   float mno = o.mnozenje();
                 //   Console.WriteLine(mno);

                }

                else if (x=="-")
                {
                    Console.WriteLine("oduzimanje");
                //    float odu = o.oduzimanje();
                  //  Console.WriteLine(odu);
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
