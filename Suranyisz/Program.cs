namespace Suranyisz
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello world!");
        }

        static void F2()
        {
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}");
        }

        static void F3()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(szam * 2);
        }

        static void F4()
        {
            Console.Write("Adj meg egy számot: ");
            int beolv_szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int beolv_szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Összegük: {beolv_szam1 + beolv_szam2}");
            Console.WriteLine($"Különbségük: {beolv_szam1 - beolv_szam2}");
            Console.WriteLine($"Szorzatuk: {beolv_szam1 * beolv_szam2}");

            if (beolv_szam2 != 0 && beolv_szam1 >= beolv_szam2)
            {
                Console.WriteLine($"Hányados: {beolv_szam1 / beolv_szam2}");
            }
            else
            {
                Console.WriteLine("A művelet nem lehetséges");
            }
        }

        static void F5()
        {
            Console.Write("Adj meg egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobbik szám: {szam1}");
            }
            else if (szam2 > szam1)
            {
                Console.WriteLine($"A nagyobbik szám: {szam2}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő");
            }
        }

        static void F6()
        {
            Console.Write("Adj meg egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szam3 = int.Parse(Console.ReadLine());

            int legkissebb = szam1;

            if (szam2 < legkissebb) legkissebb = szam2;
            if (szam3 < legkissebb) legkissebb = szam3;

            Console.WriteLine($"A legkisebb szám: {legkissebb}");
        }

        static void F7()
        {
            Console.Write("Add meg az első oldalt: ");
            int oldal1 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második oldalt: ");
            int oldal2 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a harmadik oldalt: ");
            int oldal3 = int.Parse(Console.ReadLine());

            if (oldal1 + oldal2 > oldal3 &&
                oldal1 + oldal3 > oldal2 &&
                oldal2 + oldal3 > oldal1)
            {
                Console.WriteLine("A háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető.");
            }
        }

        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
        }
    }
}
