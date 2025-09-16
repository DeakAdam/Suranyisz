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
            string felhasznaloNev = Console.ReadLine();
            Console.WriteLine($"Szia {felhasznaloNev}!");
        }
        static void F3()
        {
            Console.Write("Adj meg egy egész számot: ");
            int eredetiSzam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A megadott szám kétszerese: {eredetiSzam * 2}");
        }

        static void F4()
        {
            Console.Write("Add meg az első számot: ");
            int elsoSzam = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int masodikSzam = int.Parse(Console.ReadLine());

            Console.WriteLine($"Összeg: {elsoSzam + masodikSzam}");
            Console.WriteLine($"Különbség: {elsoSzam - masodikSzam}");
            Console.WriteLine($"Szorzat: {elsoSzam * masodikSzam}");
            if (masodikSzam != 0)
            {
                Console.WriteLine($"Hányados: {elsoSzam / masodikSzam}");
            }
            else
            {
                Console.WriteLine("Nullával nem lehet osztani!");
            }
        }
        static void F5()
        {
            Console.Write("Add meg az első számot: ");
            int elsoSzam = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int masodikSzam = int.Parse(Console.ReadLine());

            if (elsoSzam > masodikSzam)
            {
                Console.WriteLine($"A nagyobbik szám: {elsoSzam}");
            }
            else if (masodikSzam > elsoSzam)
            {
                Console.WriteLine($"A nagyobbik szám: {masodikSzam}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő.");
            }
        }

        static void F6()
        {
            Console.Write("add meg az első számot: ");
            int elsoSzam =int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int masodikSzam =int.Parse(Console.ReadLine());
            Console.Write("Add meg a harmadik számot: ");
            int harmadikSzam =int.Parse(Console.ReadLine());

            int legkisebb = elsoSzam;

            if (masodikSzam <legkisebb)legkisebb =masodikSzam;
            if (harmadikSzam <legkisebb)legkisebb =harmadikSzam;

            Console.WriteLine($"A legkisebb szám: {legkisebb}");
        }
        static void F7()
        {
            Console.Write("Add meg az első oldalt: ");
            int oldal1 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második oldalt: ");
            int oldal2 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a hamradik oldalt: ");
            int oldal3 = int.Parse(Console.ReadLine());

            if (oldal1+oldal2>oldal3&&oldal1+oldal3>oldal2&&oldal2+oldal3>oldal1)
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }
        }
        static void F8()
        {
         
            Console.Write("Add meg az első számot: ");
            int elsoszam=int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int masodikszam= int.Parse(Console.ReadLine());

            Console.WriteLine($"A két szám számtani közepe: {(elsoszam+masodikszam)/2}, mértani közepe: {Math.Sqrt(elsoszam*masodikszam)}") ;
        }

        static void F9()
        {
            Console.Write("Add meg az a értékét: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg a b értékét: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Add meg a c értékét: ");
            int c = int.Parse(Console.ReadLine());
            int diszkriminans= b * b - 4 * a * c;

            if (diszkriminans> 0 && diszkriminans==0)
            {
                Console.WriteLine("Van megolds.");
            }
            else
            {
                Console.WriteLine("Nincs megoldás.");
            }
        }
        
        static void F10()
        {
            Console.Write("Add meg az a értékét: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Add meg a b értékét: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Add meg a c értékét: ");
            double c = double.Parse(Console.ReadLine());

            double diszkriminans = b * b - 4 * a * c;

            if (diszkriminans > 0)
            {
                double x1 = (-b + Math.Sqrt(diszkriminans))/ (2 * a);
                double x2 = (-b - Math.Sqrt(diszkriminans))/ (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (diszkriminans == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Nincs megoldás");
            }
        }
        static void F11()
        {
            Console.Write("Add meg az egyik befogót: ");
            double befogo1= double.Parse(Console.ReadLine());
            Console.Write("Add meg a másik befogót: ");
            double befogo2= double.Parse(Console.ReadLine());
            double atfogo= Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);

            Console.WriteLine($"Az átfogó hossza: {atfogo:F2}");
        }
        static void F12()
        {
            Console.Write("Add meg az egyik él hosszát: ");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a második él hosszát: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Add meg a harmadik él hosszát: ");
            double c = double.Parse(Console.ReadLine());
            double felszin=2*(a*b+a*c+b*c);
            double terfogat=a*b*c;
            Console.WriteLine($"A téglatest térfogat: {terfogat} cm a felszíne: {felszin} cm");


        }

        static void F13()
        {
            Console.Write("Add meg a kör sugarát: ");
            double r=double.Parse(Console.ReadLine());
            double terulet=(r*r)*Math.PI/;
            double kerulet=2*Math.PI*r;
            Console.WriteLine($"A kör területe: {terulet} cm a kerülete: {kerulet} cm");
        }

        static void F14()
        {
            Console.Write("Add meg a körív sugarát: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Add meg a körív közééponti szögét: ");
            double alpha= double.Parse(Console.ReadLine());
            double alphaRad = alpha * Math.PI / 180;
            double ivHossz = r * alphaRad;
            double terulet = (r * r * alphaRad) / 2;
            Console.WriteLine($"Határoló ív hossza: {ivHossz} cm körív területe: {terulet} cm");
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
            F8();
            F9();
            F10();
            F11();
            F12();
            F13();
            F14();
        }
    }
}
