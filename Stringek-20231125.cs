/*
 * Stringkezelés segédprogram
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

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

for (int i = 0; i < sentence.Length; i++)
{    
    if (sentence[i] >= 'a' && sentence[i] <= 'z') //|| sentence[i]=='á' || sentence[i] == 'é' 
        //|| sentence[i] == 'ö' || sentence[i] == 'ő' || sentence[i] == 'ü' || sentence[i] == 'ű' 
        //|| sentence[i] == 'í')// ( || (sentence[i] >= 223))
        Console.Write(sentence[i].ToString().ToUpperInvariant());
    else
        Console.Write(sentence[i].ToString().ToLowerInvariant());
}
*/

/* Az inputként beolvasott szövegben cserélje ki az összes szóközt # karakterre, majd az így kapott
   szöveget írja ki a képernyőre!*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

//sentence = sentence.Replace(' ', '#');

// Helyben cseréljük a karaktereket a "Replace" methódussal és ábrázoljuk is
Console.WriteLine(sentence.Replace(' ', '#'));

// Az eredeti szöveg nem változik
//Console.WriteLine(sentence);

*/

/* Állapítsa meg, hogy az input szövegben szerepelnek-e számok!*/
/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

bool vanSzam  = false;

for (int i = 0; i < sentence.Length; i++)
{ 
    if (sentence[i] >= '0' && sentence[i] <= '9')
    {
        vanSzam = true;
    }
}

if (vanSzam)
    Console.WriteLine("Van szám a mondatban.");
else
    Console.WriteLine("Nincs szám a mondatban.");
*/

/* Kérjen be egy stringet, és írasd ki betűnként, mindegyiket új sorba! */
/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

//foreach (char c in sentence)
//    Console.WriteLine(c);

for (int i = 0; i < sentence.Length; i++)
    Console.WriteLine(sentence[i]);
*/

/* Kérjen be egy stringet, és írassa ki visszafelé */

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();
*/
/*
char[] cSentence = sentence.ToCharArray();

Array.Reverse(cSentence);

Console.WriteLine(cSentence);
*/

/*
for (int i = sentence.Length - 1; 0 <= i; i--)
    Console.Write(sentence[i]);
*/

/* Kérjen be egy stringet, és írasd ki minden második betűjét */

// Bekérünk egy mondatot
/*Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();*/

/*
int i = 1;
do
{
    Console.Write(sentence[i]);
    i += 2; ;
} while (i < sentence.Length);
*/

/*for (int i = 1;i<sentence.Length;i += 2)
    Console.Write(sentence[i]);*/

/* Kérjen be egy stringet, és írassa ki úgy külön sorokba, hogy az i. sorban az első i darab betűje van! */

/*
// Bekérünk egy stringet
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

for (int i = 0; i < sentence.Length; i++)
{
    for (int j=0; j <= i; j++)
        Console.Write(sentence[j]);
    // Új sor
    Console.WriteLine();
}
*/

/* Kérjen be egy állomány nevet, és írassa ki, hogy program-e (".com", ".exe", ".bat" az utolsó 4 karaktere) */

/*
// Bekérünk egy állomány nevet
Console.Write("Írjon be egy állomány nevet! ");
string fileName = Console.ReadLine();

if (fileName.Contains(".exe") || fileName.Contains(".com") || fileName.Contains(".bat"))
    Console.WriteLine("Ez egy futtatható állomány. ");
else
    Console.WriteLine("Ez nem egy futtatható állomány. ");
*/

/* Kérjen be 2 stringet, állapítsa meg, hogy része-e a második az elsőnek, s ha igen, 
 * hányadik pozíción kezdődik benne!*/

/*
// Bekérünk két szöveget
Console.Write("Írjon be egy szöveget! ");
string str1 = Console.ReadLine();
Console.Write("Írjon be még egy szöveget! ");
string str2 = Console.ReadLine();

int pos = str1.IndexOf(str2);

if (pos == -1)
    Console.WriteLine("Nem szerepel a " + str2 + " szöveg a " + str1 + " szövegben.");
else
    Console.WriteLine(" A " + str2 + " szöveg a " + (pos+1) + ". helyen szerepel a " + str1 + " szövegben.");
*/

/* Kérjen be egy szöveget, s minden benne lévő nagy betűt alakítson át kis betűre, majd írassa ki! */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string str = Console.ReadLine();

Console.WriteLine(str.ToLower());

*/

/* Kérjen be egy számot, majd írassa ki úgy, hogy minden számjegye 2-vel nagyobb! (8 ---0, 9---1). */
/*
// Bekérünk egy számot
Console.Write("Írjon be egy számot! ");
string szam = Console.ReadLine();

char[] ujSzam = szam.ToCharArray();

for (int i=0;i<ujSzam.Length;i++)
{
    switch (ujSzam[i])
    { 
        case < '8':
            ujSzam[i]++;
            ujSzam[i]++;
            break;       
        case '8':
            ujSzam[i] = '0';
            break;
        case '9':
            ujSzam[i] = '1';
            break;       
    }
}

Console.WriteLine(ujSzam);

*/

// File kezelés

/*
using static System.Net.Mime.MediaTypeNames;

StreamWriter sw = new StreamWriter(@"x:\a.txt");
sw.WriteLine("Teszt...");
sw.WriteLine("Teszt2");
sw.Close();*/

//Reading
StreamReader sr = new StreamReader(@"x:\a.txt");
Console.WriteLine(sr.ReadLine());
Console.WriteLine(sr.ReadLine());
sr.Close();
