/*Bevezetés a programozásba példaprogramok C#-ban
 * MicroSoft Visual Studio fejlesztőkörnyezettel
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 *Milton Friedman University, Budapest, Hungary, 2022
 */

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

elsoFuggveny("END OF LINE");
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

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("A " + i + " szám négyzete: " + masodikFuggveny(i));
}

*/

/*
// Szavak kiírása függvénnyel

// Új függvény deklarációja
void szavakKiirasa(string[] s)
{
    // Megállapítom a tömb hosszát
    int N = s.Length;
    // Szavak kiíratása ciklussal
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine(s[i]);
    }
}

// ----------------------------------------------------------------- 

// Tömb deklarációja az eljárás teszteléséhez
string[] szavak = new string[] { "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc", "tíz" };

szavakKiirasa(szavak);

string[] masszavak = { "yksi", "kaksi", "kolme", "neilja", "viisi", "kuusi" };

szavakKiirasa(masszavak);
*/

/*
// Párosság vizsgálat, logokai operátorok ---------------------------------
bool oszthatoE(int n, int m)
{
    return (n % m == 0);
}

// Kiértékelés
void kiertekel(bool l)
{
    // Kiértékelés
    if (l)
    {
        // Több utasítást is végrehajt
        Console.WriteLine("Igen. :)");
    }
    else
    {
        Console.WriteLine("Nem. :(");
    }
}

// ---

// Teszt értékek
int n = 137;
int m = 2;

// Ellenőrzés
Console.WriteLine("A " + n + " osztható-e a(z) " + m + " számmal?");


// Oszthatóság vizsgálata
bool lOszthato = oszthatoE(m, n);

// Kiértékelés
kiertekel(lOszthato);

// Egyben a kettő.
kiertekel(oszthatoE(m, n));
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

// ---

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

// A tömb maximális elemének a meghatározása
int tombMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        /*if (max < array[i])
        {
            max = array[i];
        }*/
        max = (max < array[i]) ? array[i] : max;
    }

    return max;
}

// -------------------------------------------------------------------------

// A tömb eleminek a száma
const int N = 20;

for (int j = 0; j < 5; j++)
{
    // Feltöltöm a tömböt véletlenszámokkal
    int[] array = tombFeltoltes(N);

    // A tömb elemeinek a kiírása
    tombKiiras(array);

    // A tömb elemeinek az összegének a meghatározása és kiírása
    Console.WriteLine("\nA tömb elemeinek összege: " + tombOsszege(array));

    // A tömb elemeinek a maximumának a meghatározása és kiírása
    Console.WriteLine("A tömb elemeinek maximuma: " + tombMax(array) + "\n");
}


/*
int a = 2;
int b = 3;

string str = (a < b) ? "b" : "a";

Console.WriteLine(str);
*/