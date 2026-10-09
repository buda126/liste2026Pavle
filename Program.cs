using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste2026Pavle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] x;
            x = new int[5];

            //Console.WriteLine(x[4]);

            //niz,matrica,lista,stek,red

            int[,] y = new int[3, 4];

            //lista
            List<int> z = new List<int>();
            z.Add(5);
            z.Add(10);
            z.Add(20);
            //Console.WriteLine(z[2]);

            //stek
            Stack<int> stek = new Stack<int>();
            stek.Push(5);
            stek.Push(10);
            stek.Push(20);
            int u = stek.Pop();
            //Console.WriteLine(u);


            //red
            Queue<string> red = new Queue<string>();
            red.Enqueue("Andrej");
            red.Enqueue("Aleksa");
            red.Enqueue("Jaksa goat");
            string sledeci = red.Dequeue();
            //Console.WriteLine(sledeci);





            /* 
             * ovo
             * je
             * komentar
             */






        }
    }
}
