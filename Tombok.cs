/*
 * Tombok példaprogram
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 * 
 * */

/*
// Hasznos parancsok
// Csipogás
Console.Beep();
// Háttér és szöveg színének beállítása. Csak egy törléssel működik
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Clear();

// A kurzor pozíciójának a beállítása
Console.SetCursorPosition(10, 12);

// A Console alkalmazás ablakának a neve
Console.Title = "Példaprogram";

// Eltüntetem a kurzort
Console.WriteLine("Nyomjon be egy billentyűt és eltűnik a kurzor!");
Console.ReadKey();
Console.CursorVisible = false;

// Átméretezem egy módszerrel az ablakot
Console.WriteLine("Nyomjon be egy billentyűt és kisebb lesz az ablak");
Console.ReadKey();
Console.WindowHeight = 20;
Console.WindowWidth = 40;

// Másik módszerrel átméretezem az ablakot
Console.WriteLine("Nyomjon be egy billentyűt és nagyobb lesz az ablak");
Console.ReadKey();
Console.SetWindowSize(80, 30);

// Visszaállítom az alapbeállítások- Ez is képernyőtörléssel működik
Console.WriteLine("Nyomjon be egy billentyűt és visszavált fekete-fehérre.");
Console.ReadKey();
Console.ResetColor();
Console.Clear();

*/


/*
// Kivételkezelés
try
{
    Console.Write("Írjon be egy számot! ");
    string line = Console.ReadLine();
    int szam = Convert.ToInt32(line);
    Console.WriteLine(szam);
}
catch (FormatException ex)
{
    Console.WriteLine("Valami hiba történt: {0}", ex.Message);
}
catch (Exception ex) // Kék halál
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Általános védelmi hiba!");
}
*/


/*
// Példa hibakezelésre
int szam = -1;

// Addig kér be számot, amíg 42-t írunk be. Ha kivételt dob, akkor újra kéri a számot
do
{    
    Console.Write("Írjon be egy egészszámot! ");
    string line = Console.ReadLine();

    try
    {
        szam = Convert.ToInt32(line);        
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Valami hiba történt: {0}", ex.Message);
    }

    Console.WriteLine(szam);

} while (szam != 42);
*/


/*
// Példa hibakezelésre
int szam = -1;

// Addig kér be számot, amíg 42-t írunk be. Ha kivételt dob, akkor újra kéri a számot
while (szam != 42)
{
    Console.Write("Írjon be egy egészszámot! ");
    string line = Console.ReadLine();

    try
    {
        szam = Convert.ToInt32(line);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Valami hiba történt: {0}", ex.Message);
    }

    Console.WriteLine(szam);

}
*/


/*
// Tömbök

// A tömb hossza
const int N = 5;

// Tömbdeklaráció
int[] a = new int[N];

// A tömb elemeinek kiírása ciklussal
for (int i=0;i<a.Length;i++)
    Console.Write(a[i] + " ");
*/

/*
// A tömb elemeenek feltöltése
for (int i = 0; i < a.Length; i++)
    a[i] = 3;
*/

/*
// A tömb elemeenek feltöltése véletlen számokkal
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(256);

// A tömb elemeinek kiírása ciklussal
Console.WriteLine("\nA feltöltött tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");
*/

/*
 
// Példa többszörös ciklusra: szorzótábkla kiírása
const int N = 10;

Console.WriteLine("Szorzótábla kiírása.");


for(int i=1;i<=N;i++)
{        
    for (int j = 1; j <= N; j++)
    {
        if (j == 1)
            Console.Write("\n" + i + "\t");
        //Console.Write(j + "\t");
        Console.Write(i*j + "\t");
    }
}
*/

/*
// Tömb elemeinek összegzése
// Tömb hossza
using System.Runtime.ExceptionServices;

const int N = 20;
// Tömb deklaráció
int[] a = new int[N];
// A tömb elemeinek feltöltése véletlen számokkal
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(256);

// A tömb elemeinek kiírása ciklussal
Console.WriteLine("A feltöltött tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");

int sum = 0;

for (int i=0; i < a.Length; i++)
    sum += a[i];

Console.WriteLine("\n\nA tömb elemeinek összege: " + sum + "\n");

//Console.WriteLine("A tömb elemeinek összege a beépített metódussal: " + a.Sum());  
*/

/*
// Maximum kiválasztás tétele
// Tömb hossza
const int N = 20;
// Tömb deklaráció
int[] a = new int[N];
// A tömb elemeinek feltöltése véletlen számokkal
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(256);

// A tömb elemeinek kiírása ciklussal
Console.WriteLine("A feltöltött tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");

int max = a[0];
int iMax = 0;

for (int i = 0; i < a.Length; i++)
{
    if (max < a[i])
    { 
        max = a[i];
        iMax = i;
    }
}

Console.WriteLine("\n\nA tömb legnagyobb eleme: " + max + ", ami a " + iMax + ". elem a tömbben.");

Console.WriteLine("A tömb legnagyobb eleme a beépített metódussal: " + a.Max());
Console.WriteLine("Amely a " + Array.IndexOf(a, a.Max()) + ". elem.");
*/

/*
// Megszámlálás tétele
// Tömb hossza
const int N = 20;
// Tömb deklaráció
int[] a = new int[N];
// Kiválogatás tömbje
int[] b = new int[1];
// A tömb elemeinek feltöltése véletlen számokkal
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(256);

// A tömb elemeinek kiírása ciklussal
Console.WriteLine("A feltöltött tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");

// Tulajdonság
const int limit = 128;
// Hány ilyen tulajdonságú elem van?
int nLimit = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] < limit)
    {
        nLimit += 1;
        // Képernyőre írja a kiválasztott elemeket
        Console.WriteLine("A(z) " + a[i] + " elem a " + i + ". helyen " + limit + "-nél kisebb.");
        // Eltárolja tömbbe a kiválasztott elemeket
        if (b.Length == 1 && b[0] == 0)
            b[0] = a[i];
        else
            b=b.Append(a[i]).ToArray();
    }
}

Console.WriteLine("\n" + nLimit + " darab " + limit + "-nél kisebb elem található a tömbben.");
// Kiválaszott elemek
Console.Write("Ezek az elemek: ");
for (int i = 0; i < b.Length; i++)
    Console.Write(b[i] + " ");

*/

// Rendezés
// Tömb hossza
const int N = 20;
// Tömb deklaráció
int[] a = new int[N];
// A tömb elemeinek feltöltése véletlen számokkal
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(256);

// A tömb elemeinek kiírása ciklussal
Console.Write("A feltöltött tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");

/*
// Rendezés
for (int i = 0; i < a.Length - 1; i++)
{
    for (int j = i + 1; j < a.Length; j++)
    {
        if (a[i] > a[j])
        { 
            int temp = a[i];
            a[i] = a[j];
            a[j]= temp;
        }
    }
}
*/
// Buborékrendezés
for (int i = a.Length - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (a[j] > a[j + 1])
        { 
            int temp = a[j];
            a[j] = a[j+1];
            a[j+1] = temp;
        }
    }
}

//Array.Sort(a);



Console.Write("\nA rendezett tömb: ");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");