/*
 * A 2023. november 27-én írt zh megoldása.
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 */

/*
 * (14)	Kérjen be egy pozitív egészszámot, majd generáljon le egy számsort, amelyben 0 és 255 közötti számok vannak.
 * Írja ki a számokat sorban egymás mellé szóközzel elválasztva. A kód csakis pozitív egész számot fogadjon el, 
 * különben adjon hibaüzenetet és kérje be újra a számot.*/

// Kiírja a menüt és bekér egy számjegyet
int printMenu()
{
    // Inicializálás 
    int m = 0;
    // Szám bekérése
    Console.WriteLine("\n(1) Maximum kiválasztás\n(2) Összegzés\n(3) Sorba rendezés\n(4) Kilépés.");
    
    do
    {
        Console.Write("\nKérem válasszon egy számot (1-4)!\n");
        string strM = Console.ReadLine();

        try
        {
            m = int.Parse(strM);
        }
        catch (FormatException e)
        {

            Console.WriteLine("Valami hiba történt: {0}", e.Message);
            Console.WriteLine("Ez nem (1-4) közötti szám! Kárem adjon meg egy (1-4) közötti számot! ");
        }
    } while (m<1 || m>4);

    return m;
}

// A tömb elemeinek a kiírása
void tombKiiras(int[] a)
{   
    // Kiírja az elemeket
    foreach (int e in a) Console.Write(e + " ");
    // Új sor
    Console.WriteLine();
}

// A tömb hossza
int n = 0;

do
{
    // Hibakezelés negatív számra
    if (n < 0) { Console.WriteLine("Ne adjon meg negatív számot! "); }

    // Adat bekése
    Console.Write("Kérem adjam meg a tömb méretét, egy pozitív egész számot! ");
    string strN = Console.ReadLine();

    try
    {
        n = int.Parse(strN);
    }
    catch (FormatException e)
    {
        Console.WriteLine("Valami hiba történt: {0}", e.Message);
        Console.WriteLine("Ez nem egy pozitív egész szám! Kérem adjon meg egy pozitív egész számot! ");
    }
} while (n < 1);

// Létrehozok egy n hosszúságú tömböt
int[] a = new int[n];

// Véletlenszámokkal feltöltöm

Random r = new Random();
for (int i = 0; i < n; i++) a[i]= r.Next(256);

Console.Write("A generált tömb elemei: ");
tombKiiras(a);


// Új sor
Console.WriteLine();


/* (a) Írja ki egymás alá, hogy (1) Maximum kiválasztás, (2) Összegzés (3) Sorba rendezés (4) Kilépés. Kérjen be 
 * egy számot egy és négy között. A kód csak ezt a négy számot fogadja el. A (4)-es számot beadva érjen véget 
 * a program futása.*/

int m = 0;

// A program addig fut, amíg ki nem lépeünk belőle. 
do
{
    // Ld. függvényt fent
    m = printMenu();

    switch (m)
    {
        case 1:
            // (b) Valósítsa meg a maximum kiválasztást és írja ki a maximális elemet!
            Console.WriteLine("A tömb maximális eleme: " + a.Max());
            break;
        case 2:
            // (c) Valósítsa meg az összegzést és írja ki az összeget
            Console.WriteLine("A tömb elemeinek az összege:" + a.Sum());
            break;
        case 3:
            // (d)	Valósítsa meg a rendezést és írja ki a rendezett tömböt egymás mellé
            Array.Sort(a);
            Console.Write("A rendezett tömb elemei: ");
            tombKiiras(a);
            break;
        default:
            Console.WriteLine("A program kilép.");
            m = -1;
            break;
    }
} while (m > 0);