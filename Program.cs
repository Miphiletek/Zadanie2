using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по вычислению параметра математического ожидания на примере пробы зерна");
            Console.WriteLine("Введите 1 если хотите ввести первичные параметры сами или 2 если хотите вычислить параметр с параметрами по умолчанию ");
            int usl = Convert.ToInt32(Console.ReadLine());
            if(usl==1)
            {
                int y = 2;
                int mass;

                Console.WriteLine("Введите число элементов первого столба");
                mass = Convert.ToInt16(Console.ReadLine());
                
                int[] kek = new int [mass];
                int k = 0;
                while (k < mass)
                {
                    Console.WriteLine("Введите элемент столба таблицы");

                    kek[k] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    k++;
                }
                int mass2;

                Console.WriteLine("Введите число элементов второго столба");
                mass2 = Convert.ToInt16(Console.ReadLine());

                int[] lol = new int[mass2];
                int l = 0;
                while (l < mass)
                {
                    Console.WriteLine("Введите элемент столба таблицы");

                    lol[l] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    k++;
                }





                Console.WriteLine("Введите количество проб зерна");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("данные приведены в таблице ");
                
                foreach (int s in kek) Console.Write("x "+ s + " ");
                Console.ReadLine();
                foreach (int s in lol) Console.Write("n "+ s + " ");
                Console.ReadLine();
                int sum = 0;
                int sum2 = 0;
                for (int i = 0; i < 6 ; i++)
                {
                    sum += lol[i] ;
                }
                for(int i=0; i<kek.Length;i++)
                {
                   sum2 +=   kek[i] * lol[i];
                }
                double rez = 1 / sum * sum2;
                double rezultat = Math.Round(rez, y);
                Console.WriteLine("параметр математического ожидания первичного момента равен {0}", rezultat);
                
            }
            if(usl==2)
            {
                int y = 2;
                int[] x = new int[] {0,1,2,3,4,5 };
                int[] n = new int[] { 9, 39, 40, 24, 11, 7 };
                Console.WriteLine("Введите количество проб зерна");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("данные приведены в таблице ");
                
                foreach (int s in x) Console.Write("x "+ s + " ");
                Console.ReadLine();
                foreach (int s in n) Console.Write("n "+ s + " ");
                Console.ReadLine();
                int sum = 0;
                int sum2 = 0;
                for (int i = 0; i < 6 ; i++)
                {
                    sum += n[i] ;
                }
                for(int i=0; i<x.Length;i++)
                {
                   sum2 +=   x[i] * n[i];
                }
                double rez = 1 / sum * sum2;
                double rezultat = Math.Round(rez, y);
                Console.WriteLine("параметр математического ожидания первичного момента равен {0}", rezultat);

            }
            else
            {
                return;
            }
            
        }
    }
}
