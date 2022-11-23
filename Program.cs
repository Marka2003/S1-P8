using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _S1_P8
{
    internal class Program
    {
        static void Main(string[] rgs)
        {
            // P1();
            // P2();
            // P3();
            // P4();
            // P5();
            // P6();
            // P7();
            // P8();
            // P9();
            // P10();
            // P11();
            // P12();
            // P13();
            // P14();
            // P15();
            // P16();
            // P17();
            // P18();
            // P20();
            // P21();

        }
        static void P1()
        {
            Console.WriteLine("Scrieti doua numere!");
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            Console.WriteLine(-b / a);
            Console.ReadKey();
        }


        static void P2()
        {
            Console.WriteLine("Scrie trei numere!");
            string[] t = Console.ReadLine().Split();
            float a = float.Parse(t[0]);
            float b = float.Parse(t[1]);
            float c = float.Parse(t[2]);
            float d = b * b + 4 * a * c;
            if (d >= 0)
            {
                float x1 = (-b - (float)Math.Sqrt(d) / (2 * a));
                float x2 = (-b + (float)Math.Sqrt(d) / (2 * a));
                Console.WriteLine(x1 + " " + x2);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }
            Console.ReadKey();

        }
        static void P3()
        {
            Console.WriteLine("Scrie doua numere!");
            string[] t = Console.ReadLine().Split();
            float n = float.Parse(t[0]);
            float k = float.Parse(t[1]);
            if (n % k == 0)
            {
                Console.WriteLine("{0} divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine(n + "nu se divide cu" + k);
            }
            Console.ReadKey();

        }
        static void P4()
        {
            Console.WriteLine("Verifica daca anul este bisect");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0 && y % 4 == 0) || (y % 100 != 0))
            {
                Console.WriteLine(y + "Este an bisect");
            }
            else
            {
                Console.WriteLine(y + "Nu este an bisect");
            }
            Console.ReadKey();
        }
        static void P5()
        {
            Console.WriteLine("Scrie un numar format macar din doua cifre!");
            int a = int.Parse(Console.ReadLine());
            int k = a % 10;
            if (a % 10 == k)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
        static void P6()
        {
            Console.WriteLine("Scrie trei numere intregi, pozitive!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("{0},{1} si {2} pot fi laturiile unui triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0},{1} si {2} nu pot fi laturiile unui triunghi", a, b, c);
            }
            Console.ReadKey();
        }
        static void P7()
        {
            Console.WriteLine("Scrie doua numere!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a != b)
            {
                int c = a;
                a = b;
                b = c;

            }
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();
        }
        static void P8()
        {
            Console.WriteLine("Scrie doua numere!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a != b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();
        }
        static void P9()
        {
            Console.WriteLine("Scrie un numar!");
            int n = int.Parse(Console.ReadLine());
            for (int d = 1; d <= n; d++)
                if (n % d == 0)
                    Console.Write(d + " ");
            Console.ReadKey();
        }
        static void P10()
        {
            Console.WriteLine("Scrie un numar!");
            int n = int.Parse(Console.ReadLine());
            int d;
            for (d = 2; d <= n / 2; d++) ;
            if (n % d == 0)
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            {
                Console.WriteLine("Numarul nu este prim");
            }
            Console.ReadKey();
        }
        static void P11()
        {
            Console.WriteLine("Scrie un numar!");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int m = n % 10;
                n /= 10;
                Console.Write(m);
            }
            Console.ReadKey();
        }
        static void P12()
        {
            Console.WriteLine("Scrie trei numere!");
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int n = int.Parse(t[2]);
            int i, cate = 0;
            for (i = a; i <= b; i++)
            {
                if (i % n == 0)
                    cate++;
            }
            Console.Write(cate + " ");
            Console.ReadKey();
        }
        static void P13()
        {
            Console.WriteLine(" Scrie ");
            string[] t = Console.ReadLine().Split(' ');
            int y1 = int.Parse(t[0]);
            int y2 = int.Parse(t[1]);
            int n;
            int cati = 0;
            for (n = y1; n <= y2; n++)
            {
                if ((n % 400 == 0 && n % 4 == 0) || (n % 100 != 0))
                    cati++;
            }
            Console.WriteLine(cati + " ");
            Console.ReadKey();

        }
        static void P14()
        {
            Console.WriteLine("Scrie un numar palindrom!");
            int n, pc, uc = 0;
            n = int.Parse(Console.ReadLine());
            uc = n;
            pc = 0;
            while (n != 0)
            {
                pc = pc * 10 + n % 10;
                n = n / 10;
            }
            if (pc == uc)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }
            Console.ReadKey();
        }
        static void P15()
        {
            Console.WriteLine("Scrie trei numere!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            if (a > b) { d = a; a = b; b = d; }
            if (a > c) { d = a; a = c; c = d; }
            if (b > c) { d = b; b = c; c = d; }
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Console.ReadKey();
        }
        static void P16()
        {
            Console.WriteLine("Scrie cinci numere!");
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            int d = int.Parse(t[3]);
            int e = int.Parse(t[4]);
            int aux = 0;
            if (a > b) { aux = a; a = b; b = c; c = d; d = e; e = aux; }
            if (a > c) { aux = a; a = c; b = d; c = e; d = aux; e = b; }
            if (a > d) { aux = a; a = d; b = c; c = aux; d = b; e = c; }
            if (a > e) { aux = a; a = e; b = aux; c = b; d = c; e = d; }
            if (b > c) { aux = b; b = c; c = d; d = e; e = aux; a = a; }
            if (b > d) { aux = b; b = d; c = e; d = aux; e = a; a = c; }
            if (b > e) { aux = b; b = e; c = aux; d = a; e = c; a = d; }
            if (c > d) { aux = c; c = d; d = e; e = aux; a = a; b = b; }
            if (c > e) { aux = c; c = e; d = aux; e = a; a = b; b = d; }
            if (d > e) { aux = d; d = e; e = aux; a = a; b = b; c = c; }
            Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
            Console.ReadKey();
        }
        static void P17()
        {
            Console.WriteLine("Scrie doua numere!");
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int r, p;
            while (m != 0)
            {
                r = n % m;
                n = m;
                m = r;
                Console.WriteLine(n);

            }
            r = n % m; p = n * m;
            while (r != 0)
            {
                n = m;
                m = r;
                r = n % m;
                Console.WriteLine(p / m);
            }

            Console.ReadKey();
        }
        static void P18()
        {
            Console.WriteLine("Scrie un numar!");
            int n = int.Parse(Console.ReadLine());
            int d, p;
            d = 2;
            while (n != 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    n = n / d;
                    p++;
                }
                if (p > 0)
                    Console.WriteLine($"{d}^{p} ");
                d = d + 1;
            }
            Console.ReadKey();
        }
       
        static void P20()
        {
            float m = 13;
            float n = 30;
            Console.WriteLine("m/n");
            Console.ReadKey();
        }
        static void P21()
        {
            Console.WriteLine("Scrie un numar intre 1 si 1024!");
            Random sol = new Random();
            int solutie = sol.Next(1024);
            int x;
            do
            {
                Console.Write("Dati un numar intre 1 si 1024: ");
                x = int.Parse(Console.ReadLine());
                if (x < solutie)
                    Console.WriteLine("Numarul este prea mic!");
                else if (x == solutie)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bravo! Ai ghicit!");
                }
                else
                    Console.WriteLine("Numarul  prea mare!");
            }
            while (x != solutie);
            Console.ReadKey();
        }
    }
 
    
}
    
