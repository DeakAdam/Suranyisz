using System.ComponentModel;

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
            double terulet=(r*r)*Math.PI;
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
        static void F15()
        {
            Console.Write("Adj megy egy számot: ");
            int szam= int.Parse(Console.ReadLine());

            for(int i = 0; i <=szam; i++)
            {
                Console.Write(i);
                if(i<szam)
                {
                    Console.Write(" ");
                }
            }
        }

        static void F16()
        {
            Console.Write("Adj megy egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i);
                
            }

        }

        static void F17()
        {
            Console.Write("Adj megy egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A {szam} ósztói:");

            for (int i = 1; i < szam; i++)
            {
                
                if (szam % i==0)
                {
                    Console.Write(i + " ");
                }

            }
        }
        static void F18()
        {
            Console.Write("Adj megy egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A {szam} ósztóinak összege:");

            for (int i = 1; i < szam; i++)
            {

                if (szam % i == 0)
                {
                    Console.Write(szam+=i);
                }

            }
        }

        static void F19()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int osszeg = 0;

            
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg == szam)
            {
                Console.WriteLine("Ez egy tökéletes szám");
            }
            else
            {
                Console.WriteLine("Ez nem egy tökéletes szám");
            }
        }
        static void F20()
        {
            Console.Write("Add meg a hatványalapot: ");
            int hatvanyalap = int.Parse(Console.ReadLine());
            Console.Write("Add meg a hatvány kitebőjét: ");
            int hatvanykitevo = int.Parse(Console.ReadLine());
            int hatvanyertek = 1;
            for (int i = 1; i <= hatvanykitevo; i++)
            {
                hatvanyertek *= hatvanyalap;
            }

            Console.WriteLine("Hatványérték: " + hatvanyertek);
        }
        
        static void F21()
        {
            int szam;

            do
            {
                Console.Write("Adj meg egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine());

                if (szam <= 0)
                {
                    Console.WriteLine("Hiba: csak pozitív számot adhatsz meg!");
                }

            } while (szam <= 0);

            Console.WriteLine($"A megadott szám: {szam}");
        }
        static void F22()
        {
            int szam;
            do
            {
                Console.Write("Adj meg 10-nél kissebb számokat: ");
                szam = int.Parse(Console.ReadLine());


            } while (szam < 10);
            Console.WriteLine("A szám nagyobb volt mint 10");
        }

        static void F23()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            int eredeti = szam;
            string felbontas = "";

            
            while (szam % 2 == 0)
            {
                felbontas += "2*";
                szam /= 2;
            }

            
            felbontas += szam;

            Console.WriteLine($"{eredeti} = {felbontas}");
        }
        static void F24()
        {
            string szo;
            do
            {
                Console.WriteLine("Kérlek, írd be az 'alma' szót:");

                szo = Console.ReadLine();
            }
            while (szo != "alma");
            Console.WriteLine("Az alma gyümölcs");
        }
        static void F25()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int eredmeny = szam;

            int hanyados = 0;
            while (eredmeny >= 3)
            {
                eredmeny -= 3;
                hanyados++;
            }

            Console.WriteLine($"{szam} = {hanyados}*3 + {eredmeny}");
        }
        static void F26()
        {
            Console.Write("Adj meg egy prím számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 2)
            {
                Console.WriteLine("nem prim");
            }
            else
            {
                bool prim = true;
                for (int i = 2; i <= Math.Sqrt(szam); i++)
                {
                    if (szam % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    Console.WriteLine("Ez a szám egy prímszám");
                }
                else
                {
                    Console.WriteLine("Ez nem egy prímszám");
                }
            }
        }

        static void F27()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 2)
            {
                Console.WriteLine("nem prim");
            }
            else
            {

                for (int i = 2; i <= szam; i++)
                {
                    bool prim = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            prim = false;
                            break;
                        }
                    }
                    if (prim)
                    {
                        Console.Write($"{i} ");
                    }

                }
            }
        }

        static void F28()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 2; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    bool prim = true;

                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            prim = false; break;
                        }
                    }
                    if (prim)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
        static void F29()
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int eredeti = szam;
            bool elso = true;
            for (int i = 2; i <= szam; i++)
            {
                while (szam % i == 0)
                {
                    if (!elso)
                    {
                        Console.Write("*");
                    }
                    Console.Write(i);
                    szam /= i;
                    elso = false;
                }
            }
        }
        static void F30()
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());

            while (b > 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            Console.WriteLine("LNKO: " + a);
        }
        static void F31()
        {
            Console.Write("Első szám: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int y = int.Parse(Console.ReadLine());
            int a = x; int b = y;
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine($"A {x}-nak/nek és a {y}-nak/nek a legnagyobb közös osztója a(z) {a}");
        }

        static void Main(string[] args)
        {
            F31();
        }
    }
}
