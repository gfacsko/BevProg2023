/*
 * Programozási tételek, segédprogram
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 * 
 */

// Inicializálás, azaz véletlen számokból álló N elemű tömb létrehozása
const int N = 20;
// A tömb elemeinek maximális értéke
const int aMax = 256;
// A tömb létrehozása
int[] a = new int[N];

// A tömb feltöltése véletlen számokkal és a számok kiírása
Random r = new Random();

Console.WriteLine("A generált tömb elemei: ");
for (int i = 0; i < N; i++) // a.Length
{
    // Véletlen szám generálása
    a[i] = r.Next(aMax);
    // A tömb elemeinek kiírása
    Console.Write(a[i] + " ");
}

// Új sor a kiírás végén
Console.WriteLine();

/*
// A tömb elemeinek az összegzése --------------------------------------------------------------------
int s = a[0];
for (int i = 1; i < N; i++) // a.Length
{
    s += a[i];
}

Console.WriteLine("A tömb elemeinek összege: " + s);
*/

/*
// A tömb maximális elemének és az indexének megkeresése ----------------------------------------------
// A maximális elem indexe a tömbben
int iMax = 0;
// Maximum értéke
int Max = a[0];

for (int i = 1; i < N; i++) // a.Length
{
    if (a[i] > Max)
    { 
        Max = a[i];
        iMax = i;
    }
}

Console.WriteLine("A tömb maximális értéke: " + Max + " a(z) " + iMax + " helyen.");
*/

/*
// A tömbből bizonyos tulajdonságú elemek megszámlálása ----------------------------------------------
// Az adott tulajdonságú elemek száma
int nT = 0;

for (int i = 0; i < N; i++)
{
    if (a[i] > 128)
    {
        nT++;
    }
}

Console.WriteLine("A tömbben  " + nT + " 128-nál nagyobb elem található.");
*/

/*
// A tömbből bizonyos tulajdonságú elemek kiválogatása képernyőre való kiírással --------------------

for (int i = 0; i < N; i++)
{
    if (a[i] > 128)
    {
        Console.WriteLine("A(z) " + (i + 1) + ". elem, a(z) " + a[i] + " értéke nagyobb 128-nál.");
    }
}
*/

/*
// A tömbből bizonyos tulajdonságú elemek kiválogatása tömbbe --------------------------------------
int nT = 0;
// Segédtömb az eredményeknek
int[] b = new int[1];

for (int i = 0; i < N; i++)
{
    if (a[i] > 128)
    {
        if (b.Length == 1 && b[0] == 0)
        {
            b[0] = a[i];
        }
        else
        {
            b = b.Append(a[i]).ToArray();
        }
        nT += 1;
    }
}

if (nT > 0)
{
    Console.WriteLine("Az adott tulajdonságú elemek a tömbben: ");
    for (int j = 0; j < b.Length; j++)
    {
        Console.Write(b[j] + " ");
    }
}
else 
{
    Console.WriteLine("Nincs ilyen  tulajdonságú elem a tömbben.");
}
*/

/*
// Gyorsrendezés ----------------------------------------------------------------------------
for (int i = 0; i < N - 1; i++)
{
    for (int j = i + 1; j < N; j++)
    {
        if (a[i] > a[j])
        { 
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}

Console.WriteLine("A rendezett tömb elemei: ");
for (int i = 0; i < N; i++)
{
    Console.Write(a[i] + " ");
}
*/

/*
for (int i = N - 1; i >= 1; i--)
{
    for (int j = 0; j <= i - 1; j++)
    {
        if (a[j] > a[j + 1])
        {
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
        }
    }
}
*/

/*
// Beépített rendezés
Array.Sort(a);

Console.WriteLine("A rendezett tömb elemei: ");
for (int i = 0; i < N; i++)
{
    Console.Write(a[i] + " ");
}
*/