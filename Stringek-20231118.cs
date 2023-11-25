/*
 * String kezelés segédprogram
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 * 
 */

/*
// Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab "a" betű van!
int nA = 0;

Console.WriteLine("Írjon be egy szöveget!");
string s = Console.ReadLine(); 

Console.WriteLine("A beírt szöveg: \n" + s);



for (int i = 0; i < s.Length; i++)
{ 
    if (s[i] == 'a')
    { 
        nA++; 
    }
}

Console.WriteLine("A szövegben " + nA + " db a betű található.");
*/

/*
// Az előző programot alakítsa át úgy, hogy a számlálandó betűt is ön adhassa meg!
int nA = 0;

Console.WriteLine("Írjon be egy szöveget!");
string s = Console.ReadLine(); 

Console.WriteLine("Melyik betűre keressek rá? ");
string sample = Console.ReadLine();

char c = (char)sample[0];

Console.WriteLine("A beírt szöveg: \n" + s);
Console.WriteLine("A keresendő minta: " + c);


for (int i = 0; i < s.Length; i++)
{ 
    if (s[i] == c)
    { 
        nA++; 
    }
}

Console.WriteLine("A szövegben " + nA + " db " + c + " betű található.");
*/

/*
// Az input szövegből távolítsa el a szóközöket!
Console.WriteLine("Írjon be egy szöveget!");
string s = Console.ReadLine();

Console.WriteLine("A beírt szöveg: \n" + s);

string result = "";

for (int i=0;i<s.Length;i++)
{
    if (s[i] != ' ')
    { 
        result += s[i];
    }
}

Console.WriteLine("A beírt szöveg szóközök nélkül: \n" + result);
*/

/*
//Olvasson be egy mondatot és egy szót! Mondja meg, hogy a szó szerepel-e a mondatban!

// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

// Bekérünk egy mintát
Console.Write("Írja be a keresendő szót! ");
string word = Console.ReadLine();

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat: " + sentence);
Console.WriteLine("A beírt szó: " + word);

// Annak eldöntése, hogy szerepel-e benne a szó
if (sentence.Contains(word)) // Mintát az Contains metódussal lehet keresni
    Console.WriteLine("Az adott szó szerepel a mondatban.");
else
    Console.WriteLine("Az adott szó nem szerepel a mondatban.");
*/

// A beolvasott mondatról döntse el, hogy az visszafelé is ugyanazt jelenti-e!
// (Az "Indul a görög aludni", vagy a "Géza kék az ég" visszafelé olvasva is ugyanazt jelenti.)
// Ügyeljen a mondatvégi írásjelekre, mivel azok a mondat elején nem szerepelnek.

/*
// Bekérem a mondatot
Console.WriteLine("Kérem írjon be egy mondatot! ");
string mondat = Console.ReadLine().ToLower(); // Kis betűssé alakítja

// Ellenőrzésképpen kiírom a bekért mondatot
Console.WriteLine("\nA beírt mondat: " + mondat);

// El kell távolítani a szóközöket és az írásjeleket
// Ez fogja tárolni a feldolgozott mondatot
char[] ujMondat = new char[mondat.Length];
// Kiszűröm a szóközt és az írásjeleket
int iUjMondat = 0; // Ez adja majd meg az új mondat hosszát
for (int i = 0; i < mondat.Length; i++)
    if (mondat[i] != ' ' && mondat[i] != '.' && mondat[i] != ',' && mondat[i] != '!' && mondat[i] != '?')
        ujMondat[iUjMondat++] = mondat[i];

// Visszaalakítom a karektertömböt stringé
mondat = string.Join("", ujMondat);

// Ellenőrzésképpen kiírom a szűrt mondatot
Console.WriteLine("A szűrt mondat: " + mondat);

// Jelzi, hogy palindroma-e a szöveg
bool isPalindroma = true;

// Összehasonlítom a betűket a mondat elején és végén

for (int i = 0; i < iUjMondat; i++)
{
    if (mondat[i] != mondat[(iUjMondat - 1) - i])
    {
        isPalindroma = false;
    }
}
*/

/*
// Gyorsabb verzió
int iMondat = 0;
while (iMondat < iUjMondat && isPalindroma)
{
    if (mondat[iMondat] != mondat[(iUjMondat - 1) - iMondat])
        isPalindroma = false;
    iMondat++;
}
*/

/*
if (isPalindroma)
    Console.WriteLine("A mondat palindroma.");
else
    Console.WriteLine("A mondat nem palindroma.");
*/

//A beolvasott mondatok kisbetűit alakítsa nagybetűsre, a nagybetűs karaktereket pedig kisbetűsre!


// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] >= 'a' && sentence[i] <= 'z' || sentence[i]=='á' || sentence[i] == 'é' 
        || sentence[i] == 'ö' || sentence[i] == 'ő' || sentence[i] == 'ü' || sentence[i] == 'ű' 
        || sentence[i] == 'í')// ( || (sentence[i] >= 223))
        Console.Write(sentence[i].ToString().ToUpperInvariant());
    else
        Console.Write(sentence[i].ToString().ToLowerInvariant());
}
