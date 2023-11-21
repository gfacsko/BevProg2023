/*
 * Függvények
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022 -2023
 * 
 * */

/*
// Első függvény deklaráció: szöveg kiírás
void elsoFuggveny(string s)
{
    // Kiírja a paraméterként kapott szöveget
    Console.WriteLine(s);
}

// A függvény meghívása
elsoFuggveny("Teszt.");
elsoFuggveny("Még egy teszt.");
*/

/*
// Második függvény deklaráció: négyzetre emelés
int masodikFuggveny(int x)
{
    x = x * x;

    return x;
}

// Megadok egy változót
int x = 42;

// A változó értékének kiírása
Console.WriteLine("A bemeneti érték: " + x);

// A függvény eredményének kiírása
Console.WriteLine("A kimeneti érték: " + masodikFuggveny(x));
*/

/*
// Szavak kiírása függvénnyel

// Új függvény deklarációja
void szavakKiirasa(string[] s)
{
    int N = s.Length;
    // Szavak kiíratása ciklussal egymás mellé
    for (int i = 0; i < N; i++)
    {
        Console.Write(s[i] + " ");
    }
    // Új sor
    Console.WriteLine();
}

// Tömb deklarációja az eljárás teszteléséhez
string[] szamok = new string[] { "egy", "kettő", "három", "négy",
    "öt", "hat", "hét", "nyolc", "kilenc", "tíz" };

szavakKiirasa(szamok);

string[] finnszamok = {"yksi", "kaksi", "kolme", "neilja", "viisi",
    "kuusi" };

szavakKiirasa(finnszamok);


// Párosság vizsgálat, logikai operátorok ---------------------------------
bool oszthatoE(int n, int m)
{
    //bool l = (n % m == 0);
    //return (l);
    return (n % m == 0);
}

// Kiértékelés
void kiertekel(bool l)
{
    // Kiértékelés
    if (l)
    {
        // Több utasítást is végrehajt
        Console.WriteLine("Igen. .)");
    }
    else
    {
        Console.WriteLine("Nem. :(");
    }
}

// Teszt értékek
int n = 137;
int m = 2;

// Ellenőrzés
Console.WriteLine("A " + n + " osztható-e a(z) " + 
    m + " számmal?");


// Oszthatóság vizsgálata
bool lOszthato = oszthatoE(m, n);

// Kiértékelés tömörebben
kiertekel(lOszthato);


// Egyben a kettő.
//kiertekel(oszthatoE(m, n));

*/

/*
// Másodfokú egyenletet megoldó program

// Beolvas egy racionális számot
double readDouble()
{
    // Beolvas egy sort
    string line = Console.ReadLine();
    // Átalakítja törté és visszaadja a számot
    return Convert.ToDouble(line);
}

// Kiszámolja a diszkriminánst
double diszkriminans(double a, double b, double c)
{ 
    return Math.Pow(b, 2) - 4 * a * c;
}

// A másodfokú egyelet megoldása
void masodfokuEgyenlet(double a, double b, double c)
{
    // Diszkrimináns számítása
    double d = diszkriminans(a, b, c);
    Console.WriteLine("A diszkrimináns: " + d);

    // Kiértékelés a diszkrimináns alapján
    switch (d)
    {
        case > 0:
            Console.WriteLine("D > 0, az egyenletnek így két megoldása van.");
            double x1 = (-1 * b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-1 * b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Az egyenlet megoldásai: x1 = " + x1 + " x2 = " + x2);
            break;
        case < 0:
            Console.WriteLine("Az egyenletnek nincsen megoldása a valós számok körében.");
            break;
        default:
            Console.WriteLine("D = 0, az egyenletnek így csak egy megoldása van.");
            double x = (-1 * b) / (2 * a);
            Console.WriteLine("Az egyenlet megoldása: x = " + x);
            break;
    }
}

// Állandók bekérése
Console.WriteLine("A másodfokú egyenlet általános alakja: a x^2 + b x + c = 0 ");
// a állandó
Console.Write("a = ");
double a = readDouble();
// b állandó
Console.Write("b = ");
double b = readDouble();
// c állandó
Console.Write("c = ");
double c = readDouble();

// Ellenőrzés
Console.WriteLine("A megadott egyenlet: " + a + " x^2 + " + b + " x + " + c);

// Megoldja a másodfokú egyenletet
masodfokuEgyenlet(a, b, c);
*/

/*
// Összegző program

// Véletlen számokkal feltöltötte tömb elemeinek összege

// Véletlen számok generálása függvény
int[] tombFeltoltes(int n) // n: a tömb elemeinek a száma
{
    // Tömb
    int[] array = new int[n];
    // Véletlen szám
    Random rnd = new Random();
    // Tömb feltöltése véletlen számokkal
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(0, 255);
    }

    return array;
}

// A tömb elemeinek a kiírása
void tombKiiras(int[] array)
{
    Console.Write("A tömb elemei: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    // Új sor
    Console.WriteLine();
}


// A tömb elemeinek az összegének a meghatározása
int tombOsszege(int[] array)
{
    int osszeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        osszeg += array[i];
    }

    return osszeg;
}

// -------------------------------------------------------------------------

// A tömb elemeinek a száma
const int N = 20;

// Feltölötöm a tömböt véletlenszámokkal
int[] a = tombFeltoltes(N);


// A tömb elemeinek a kiírása
tombKiiras(a);

// A tömb elemeinek az összegének a meghatározása és kiírása
Console.WriteLine("\nA tömb elemeinek összege: " + tombOsszege(a));
*/



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
double d = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine("A diszkrimináns értéke: " + d);



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