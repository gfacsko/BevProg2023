/* 
 * Változók példaprogram
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Miltgon Friedman University, Budapest, Hungary, 2023
 * 
 */


/*

// Példák különféle típusú változókra.

// Egész
byte m = 2;
int n = 2147483647;
long o = 9223372036854775807;

Console.WriteLine((long)Math.Pow(2, 63) - 1);

// Lebegőpontos
double m2 = 2.71;

Console.WriteLine(m + " " + n + " " + o);

double r = 3.14;

Console.WriteLine(r);

// Típus kényszerítés
m = (int)2.5;

Console.WriteLine(m);

// Szöveg típus
string str = "Valami";

Console.WriteLine(str);

// Karakter
char c = 'a';

Console.WriteLine(c);

Console.WriteLine(str[2]);

// Logikai
bool l = true;

Console.WriteLine(l);
*/

/*

// Műveletek 
int a = 2;
int b = 3;
int c = 47;

Console.WriteLine("a+b= " + (a+b));
Console.WriteLine("a-b= " + (a-b));
Console.WriteLine("a*b= " + (a*b));
Console.WriteLine("a/b= " + ((float)a/(float)b));

// Maradékos osztás
Console.WriteLine("c mod b = " + (c % b));

// Logikai műveletek
bool l = a != b;

Console.WriteLine(l);
*/

// AND/ÉS művelet

/*
 * a  b  a && b
 * h  h  h
 * h  i  h
 * i  h  h
 * i  i  i
 * 
 * */

/*
bool a = true;
bool b = false;

Console.WriteLine("a && b = " + (a && b));
*/

// VAGY/OR művelet

/*
 * a  b  a || b
 * h  h  h
 * h  i  i
 * i  h  i
 * i  i  i
 * 
 * */

/*
a = true;
b = false;

Console.WriteLine("a || b = " + (a || b));
*/

// KIZÁRÓ VAGY/XOR művelet

/*
 * a  b  a ^ b
 * h  h  h
 * h  i  i
 * i  h  i
 * i  i  h
 * 
 * */

/*
a = true;
b = true;

Console.WriteLine("a ^ b = " + (a ^ b));
*/

// Negáció

/*
 * a  !a
 * h  i
 * i  h  
 * 
 * */

/*
a = true;

Console.WriteLine("!a = " + (!a));
*/

/*

// Binális műveletek
int a = 128;
int b = 64;
string aStr = "01000000";
string bStr = "00100000";

Console.WriteLine(aStr + "\n & \n" + bStr + " = " + (a & b));
Console.WriteLine(aStr + "\n | \n" + bStr + " = " + (a | b));
Console.WriteLine(aStr + "\n ^ \n" + bStr + " = " + (a ^ b));
Console.WriteLine("~" + aStr + " = " + (~a));
*/

/*

// Elágazás
int a = 137;

if (a == 42)
    Console.WriteLine("A szam 42.");
else
    Console.WriteLine("A szam nem 42.");

// Többszörös elágazás
switch (a) 
{
    case 42:
        Console.WriteLine("A szam 42.");
        break;
    case 137:
        Console.WriteLine("A szam 137.");
        break;
    default:
        Console.WriteLine("A szam nem 42.");
        break;
}
*/



//int N = 1;

/*

// A for ciklus
for (int i=1;i<=N;i++)
{
    Console.Write(i + " ");
}

*/

/*

// Az elöl tesztelő/while ciklus
int j = 1;


while (j < N)
{
    Console.Write(j + " ");
    j += 1; // j = j + 1
}

int k = 1;

// Hátul tesztelő/do-while ciklus
do
{
    Console.Write(k + " ");
    k += 1; // k = k + 1
}  while (k < N);
*/

/*

// Adatbekérés billentyűzetről és hibakezelés
Console.Write("Írjon be egy számot! ");
string str = Console.ReadLine();

// Kivételkezelés
try
{
    int a = int.Parse(str);
    Console.WriteLine("A beírt szám: " + a);
}
catch (System.FormatException e)
{
    Console.WriteLine("Ez nem szám."); 
    Console.WriteLine(e.Message);
}

*/

/*

// Hasznos utasítások

// Háttérszín beállítása
Console.BackgroundColor = ConsoleColor.DarkBlue;
// Csipogás
Console.Beep();
// Képernyőtörlés
Console.Clear();
// Kurzos eltüntetése
Console.CursorVisible = false;
// Betűtípus beállítása
Console.ForegroundColor = ConsoleColor.Red;
// Szinek alapállításra állítása
Console.ResetColor();
// Kurzos pozíció beállítása
Console.SetCursorPosition (10,5);
// Az ablak cyme (csak felvillan)
Console.Title = "Cím";
// Az ablak magassága
Console.WindowHeight = 20;
// Az ablak szélessége
Console.WindowWidth = 90;
// Az ablak mérete
Console.SetWindowSize (20,15);
*/

const int M = 10;
const int N = 20;

/*

// Egymásba ágyazott ciklusok

for (int i = 1; i <= M; i++)
    for (int j = 1; j <= N; j++)
        Console.WriteLine(i + " * " + j + " = " + (i * j));
*/

// Tömb deklaráció
int[] a = new int[N];

// Véletlen számok generálása
Random r = new Random();

// Tömb feltöltése véletlen számokkal
for (int i = 0; i < N; i++)
{
    a[i] = r.Next(256);
    Console.Write(a[i] + " ");
}
