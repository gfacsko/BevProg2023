/*
 * Függvények segédprogram
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 */


/*
// A Hello World program általános alakja
void helloWorld(string text)
{ 
    Console.WriteLine(text);
}

// Itt hívom meg.
helloWorld("Szia Világ!");

// Itt többször hívom meg.
string[] sokSzoveg = {"Szia!", "Privjet!", "Moi!",
    "Terve!", "Hei!", "Hallo!", "Hi!" };
foreach (string s in sokSzoveg)
{
    helloWorld(s);
}
*/

/*
int osszeadas(int a, int b)
{
    return (a + b);
}


int a = 2;
int b = 3;
*/

/*int osszeg = 0;

osszeg = osszeadas(a, b);

Console.WriteLine("Az a = " + a + " és b = " + b + 
    " számok összege: " + osszeg);
*/

/*
Console.WriteLine("Az a = " + a + " és b = " + b +
    " számok összege: " + osszeadas(a,b));
*/

/*
// Nem lehet felüldefiniálni a függvényt
double osszeadas(double a, double b)
{
    return (a + b);
}

double e = 2.71;
double p = 3.14;

Console.WriteLine("Az e = " + e + " és p = " + p +
    " számok összege: " + osszeadas(e, p));
*/

/*
// Faktoriális számítás rekurzióval
long faktor(long n)
{
    if (n == 0)
        { return 1; }
    if (n>0) 
        { return (n * faktor(n-1)); }

    return -1;
}

// Ennek a faktoriálisát számítjuk ki
const long N = 25;

Console.WriteLine(N + "! = " + faktor(N));
*/

/*
// Feltöti véletlenszámokkal a tömböt
int[] tombFeltoltés(int n, int max)
{
    // A tömb létrehozása
    int[] array = new int[n];
        
    // Véletlen számokkal feltöltöm
    Random r = new Random();

    for (int i = 0; i < n; i++)
        array[i] = r.Next(max);

    return array;
}

void tombKiiras(int[] array)
{
    Console.Write("A tömb elemei: ");
    foreach (int a in array)
    {
        
        Console.Write(a + " ");
    }
    // Új sor
    Console.WriteLine();
}

// Maximum keresés, tömböt vár és visszaadja a maximum
// indexét, illetve a maximum értékét
int[] maxKereses(int[] a)
{
    int[] result = { -1, -1 };

    int iMax = 0;
    int vMax = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > vMax)
        {
            iMax = i;
            vMax = a[i];
        }
    }

    result[0] = iMax;
    result[1] = vMax;

    return result;
}

// A tömb elemeinek a száma
const int N = 20;
// A tömb elemeinek maximális értéke
const int Max = 256;

for (int j = 0; j < 5; j++)
{
    // Definálok egy tömböt
    //int[] a = new int[N];
    int[] a = tombFeltoltés(N, Max);

    tombKiiras(a);

    int[] max = maxKereses(a);

    Console.WriteLine("A tömb maximális értéke: " + max[1]);
    Console.WriteLine("Amely a(z) " + max[0] + ". elem");
}
*/

// Ternális operátor
int a = 42;
int b = 3;

string str = (a < b) ? "Az a a kisebb" : "A b a kisebb";

Console.WriteLine(str);
