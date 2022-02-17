using System;

namespace Generics_övn1
{
    class Program
    {
        static void Main(string[] args)
        {
            LghCollection L1 = new LghCollection();
            L1.Add(new Lägenhet(1, 1001, 5));
            L1.Add(new Lägenhet(2, 1002, 2));
            L1.Add(new Lägenhet(3, 1003, 1));
            L1.Add(new Lägenhet(4, 1004, 10));
            L1.Add(new Lägenhet(5, 1005, 3));

            L1.Add(new Lägenhet(5, 1005, 3));
            Display(L1);

            
            Console.WriteLine("Finns objektet i listan? " + L1.Contains(new Lägenhet(4, 1004, 10)));
        }
        public static void Display(LghCollection lägenhets)
        {
            Console.WriteLine("\nID\tLghnr\tAntal pers\tHashcode");
            foreach (Lägenhet item in lägenhets)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}",
                    item.ID, item.LghNum, item.AntalPers, item.GetHashCode());
            }
        }
    }
}
