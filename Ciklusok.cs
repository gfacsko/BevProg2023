/*
 * Cilusok, elágazások, hibakezelés
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 * 
 */

/*
// Ciklus index változója
int i = 0;
// Konstand
int N = 100;
// Kiírja a számokat 0 és N-1 között
Console.Write("A számok " + (N-1) + "-ig: ");
while (i < N)
{
    Console.Write(" " + i);
    i += 1;
}
*/

/*
// Ciklus index változója
int i = 0;
// Konstans
int N = 100;
// Kiírja a számokat 0 és N-1 között
Console.Write("A számok " + (N-1) + "-ig: ");
do
{
    Console.Write(" " + i);
    i += 1;
} while (i < N);
*/

/*
// Konstans
int N = 100;
// Kiírja a számokat 0 és N-1 között
Console.Write("A számok " + (N-1) + "-ig: ");
for (int i = 0; i < N; i++)
{
    Console.Write(" " + i);
};
*/

/*
// Egy szám bekérése
//string nStr = "";
Console.WriteLine("Írjon be egy egészszámot!");
//nStr = Console.ReadLine();
string nStr = Console.ReadLine();
Console.WriteLine("A beírt szám: " + nStr);
// Átkonvertáljuk a szöveget egészszámmá
int n = int.Parse(nStr);
// Kiírjuk az eredményt
Console.WriteLine("Az átkonvertált szám: " + n);
// Kiírja a számokat 0 és n-1 között
Console.Write("A számok " + (n-1) + "-ig: ");
for (int i = 0; i < n; i++)
{
    Console.Write(" " + i);
};
*/

/*

// Másodfokú egyenlet megoldása
Console.WriteLine("A másodfokú egyenlet általános alakja: a * x^2 + b * x + c = 0");
// Bekérem a konstansokat
Console.Write("a = ");
string aStr = Console.ReadLine();
Console.Write("b = ");
string bStr = Console.ReadLine();
Console.Write("c = ");
string cStr = Console.ReadLine();

// A szöveg konvertálása számmá
double a = double.Parse(aStr);
double b = double.Parse(bStr);
double c = double.Parse(cStr);

// Ellenőrzés
Console.WriteLine(a + "* x^2 + " + b + " * x + " + c + " = 0");

// A másodfokú egyenlet megoldóképlete
double d = Math.Pow(b,2) - 4 * a * c;
Console.WriteLine("A diszkrimináns értéke: " + d);

*/

/*
if (d == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("Egy megoldás van. x = " + x);
}

if (d > 0)
{
    double x1 = (-b - Math.Sqrt(d))/ (2 * a);
    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("Két megoldás van. x1 = " + x1 + " x2 = " + x2);
}

if (d < 0)
{
    Console.WriteLine("Nincs megoldás a valós számok halmazán.");
}
*/

/*
switch (Math.Sign(d))
{
    case 0:
        double x = -b / (2 * a);
        Console.WriteLine("Egy megoldás van. x = " + x);
        break;
    case 1:
        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.WriteLine("Két megoldás van. x1 = " + x1 + " x2 = " + x2);
        break;
    default:
        Console.WriteLine("Nincs megoldás a valós számok halmazán.");
        break;
}
*/

/*
// Goto utasítás. Ne használják!
cimke:
        Console.WriteLine("Ugrás");
        goto cimke;
*/     