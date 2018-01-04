using Calculator;
using System;
using System.Collections.Generic;

namespace Operacije
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uneti mnogo brojeva razmaknutih zarezom");
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

          //  List<float> brojevi2 = new List<float>();
            Console.WriteLine("brojevi u obrnutom redosledu");
            String odgovor = "" ;
            for (int i = niz.Length-1; i >=0; i--)
            {
                // Console.WriteLine(niz[i]);
                //  brojevi2.Add(float.Parse(niz[i]));
                odgovor += niz[i] + ",";
          
            }
            Console.WriteLine(odgovor.TrimEnd(','));

            Console.WriteLine("Brojevi sortirani");
            String odgovor2 = "";
            for (int i = 0; i < niz.Length; i++)
            {
                Array.Sort(niz, (i1, i2) => i2.CompareTo(i1));
                odgovor2 += niz[i] + ",";
            }
            Console.WriteLine(odgovor2);
            //  Console.WriteLine(brojevi2.);
       //5,6.3,2,1
            //float second;
            //float first;
            //bool firstConv = float.TryParse(niz[0], out first);
            //bool secondConv = float.TryParse(niz[1], out second);
            //brojevi.Add(first); brojevi.Add(second);



            while (true)
            {
                Console.WriteLine("izaberi +, -, * ili !");
                String x = Console.ReadLine();
                Oprerations o = new Oprerations(brojevi);
                if (x == "+")
                {

                    Console.WriteLine("suma");
                    float sum = o.sabiranje();
                    Console.WriteLine(sum);
                }

                else if (x == "!")
                {
                    Console.WriteLine("Faktorial prvog broja u nizu");
                   int faktorijel = o.faktorijal(int.Parse(niz[0]));

                   Console.WriteLine(faktorijel);
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
