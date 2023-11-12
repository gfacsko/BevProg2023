/*/
 * Valtozok: Változók bemutatása
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2023
 * 
 * */
/*int a = 10;
int b = 3;

a = 20;

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

if (a == 10)
    Console.WriteLine("Az a változó értéke 10.");
else
    Console.WriteLine("Az a változó értéke nem 10, hanem " + a);
*/

/*if (a % 2 == 0)
    Console.WriteLine("Az a változó páros.");*/


//double c = a + b;

//b = "Próba";

/*Console.WriteLine("a + b = " + (a + b));
Console.WriteLine("a - b = " + (a - b));
Console.WriteLine("a * b = " + (a * b));
Console.WriteLine("a / b = " + (a / b));
Console.WriteLine("a % b = " + (a % b));
*/
/*
 bool l = true;

Console.WriteLine("l = " + l);

char k = 'K';

Console.WriteLine(k);

string s = "Példa";

Console.WriteLine(s[2]);
*/

/*
bool m = true;
bool n = true;*/


/*Console.WriteLine("m = " + m);
Console.WriteLine("n = " + n);
*/

/*
 *  m   n   m && n
 *  0   0   0
 *  0   1   0
 *  1   0   0
 *  1   1   1
 */

/*
Console.Write("m && n = ");

if (m && n)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
*/

/*
 *  m   n   m  || n
 *  0   0   0
 *  0   1   1
 *  1   0   1
 *  1   1   1
 */

/*
Console.Write("m || n = ");

if (m || n)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
*/

/*
 *  m  !m 
 *  0  1 
 *  1  0 
 */


/*
Console.Write("!m = ");

if (!m)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
*/


/*
 *  m   n   m ^ n
 *  0   0   0
 *  0   1   1
 *  1   0   1
 *  1   1   0
 */

/*
Console.Write("m ^ n = ");

if (m ^ n)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
*/


// A páros számok kiírása
/*int N = 20;

for (int i = 0; i < N; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);*/

// Az első N szám összege
/*int N = 100;
int s = 0;

for (int i = 1; i <= N; i++)
    s += i; // s = s + i;

Console.WriteLine("Az első " + N + " egésszám összege " + s);*/

// Az első N páros, páratlan és 13-mal osztható szám összege
int N = 100;
int sParos = 0;
int sParatlan = 0;
int s13 = 0;

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
        sParos += i;

    if (i % 2 == 1)
        sParatlan += i;

    if (i % 13 == 0)
        s13 += i;
}

Console.WriteLine("Az első " + N + " páros szám összege: " + sParos);
Console.WriteLine("Az első " + N + " páratlan szám összege: " + sParatlan);
Console.WriteLine("Az első " + N + " 13-mal osztható szám összege: " + s13);