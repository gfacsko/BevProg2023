/*
 * Stringkezelő programok
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022 
 * 
 * */


/*
 * Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab "a" betű van!
*/

/*
// Bekérünk egy mondatot
string str = "";

Console.Write("Írjon be egy mondatot! ");
str = Console.ReadLine();

// A bekért mondat ellenőrzése
Console.WriteLine("A beírt mondat: " + str);

// Az "a" betűk megszámlálása
// Az "a" betűk száma
int nSample = 0;
for (int i = 0; i < str.Length; i++) // A "Length" tulajdonság a string hossza
{ 
    if (str[i] == 'a')
        nSample++; // nSample += 1; // nSample = nSample + 1;
}

// Az eredmény kiíratása
Console.WriteLine("A beírt mondatban " + nSample + " a betű taláható.");
*/

/*
 * Írjon programot, mely megszámolja, hogy a beírt mondatban hány darab megadott
 * betű van!
*/

/*
// Bekérünk egy mondatot
string str = ""; // A mondat

Console.Write("Írjon be egy mondatot! ");
str = Console.ReadLine();

// Bekérünk egy mintát
string strSample = "";

Console.Write("Írja be a keresendő mintát (egy karakter)! ");
strSample = Console.ReadLine();

char sample = (char)strSample[0];

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat: " + str);
Console.WriteLine("A beírt minta: " + sample);

// Az minta megszámlálása
// Az minta száma
int nSample = 0;
for (int i = 0; i < str.Length; i++) // A "Length" tulajdonság a string hossza
{ 
    if (str[i] == sample)
        nSample++; // nSample += 1; // nSample = nSample + 1;
}

// Az eredmény kiíratása
Console.WriteLine("A beírt mondatban " + nSample + " " + sample + " taláható.");
*/

/*
 * Az input szövegből távolítsa el a szóközöket!
 */


/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string str = Console.ReadLine();

// Itt tárolom el az eredményeket
string result = "";
for (int i = 0;i<str.Length;i++)
    if (str[i] != ' ')
        result += str[i];

// Kiírom az eredményt
Console.WriteLine("A szóköz nélküli szöveg: !" + result +"!");
*/

/*
 * Olvasson be egy mondatot és egy szót! Mondja meg, hogy a szó szerepel-e a mondatban!
*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

// Bekérünk egy mintát
Console.Write("Írja be a keresendő szót! ");
string word = Console.ReadLine();

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat:!" + sentence + "!");
Console.WriteLine("A beírt szó:!" + word + "!");

// Annak eldöntése, hogy szerepel-e benne a szó
if (sentence.Contains(word)) // Mintát az Contains metódussal lehet keresni
    Console.WriteLine("Az adott szó szerepel a mondatban.");
else
    Console.WriteLine("Az adott szó nem szerepel a mondatban.");
*/

/*
 * A beolvasott mondatok kisbetűit alakítsa nagybetűsre, a nagybetűs karaktereket pedig kisbetűsre!
*/

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence = Console.ReadLine();

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] >= 'a' && sentence[i] <= 'z')// ( || (sentence[i] >= 223))
        Console.Write(sentence[i].ToString().ToUpperInvariant());
    else
        Console.Write(sentence[i].ToString().ToLowerInvariant());
}
*/

/*
 * Két mondatról döntse el, hogy azonosak-e! Ha a kis és nagybetűk különböznek,
 * a programnak akkor is megoldást kell adnia!
 * 
 */

/*
// Bekérünk egy mondatot
Console.Write("Írjon be egy mondatot! ");
string sentence1 = Console.ReadLine().ToLower();

// Bekérünk még egy mondatot
Console.Write("Írjon be még egy mondatot! ");
string sentence2 = Console.ReadLine().ToLower();

// A bekért mondat és minta ellenőrzése
Console.WriteLine("A beírt mondat: " + sentence1);
Console.WriteLine("A beírt másik mondat: " + sentence2);

// Ez jelzi, hogy azonos-e a két mondat
bool isSame = true;
// Ha nem azonos a hosszuk, akkor nem is kell vizsgálni tovább.
if (sentence1.Length == sentence2.Length)
{
    // Van-e különböző karakter
    for (int i = 0; i < sentence1.Length - 1; i++)
    {
        if(sentence1[i] != sentence2[i])
        {
            isSame = false;
        }
    }
}
else 
{
    isSame = false;
}

if (isSame)
{
    Console.WriteLine("A két mondat azonos!");
}
else
{
    Console.WriteLine("A két mondat nem azonos!");
}
*/

/*
 * Az inputként beolvasott szövegben cserélje ki az összes szóközt # karakterre, 
 * majd az így kapott szöveget írja ki a képernyőre!
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string str = Console.ReadLine();

// Itt tárolom el az eredményeket
string result = str.Replace(' ', '#');

// Kiírom az eredményt
Console.WriteLine("A szóköz nélküli szöveg: " + result);
*/

/*
 * Állapítsa meg, hogy az input szövegben szerepelnek-e számok! * 
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy mondatot! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Ez jelzi, hogy van-e szám a szövegben
bool isNumber = false;

// Megvizsgálunk minden karaktert
for (int i = 0; i < str.Length - 1; i++)
{
    // Ha van benn szám, akkor jelzi
    if('0' <= str[i] && str[i]<='9')
    {
        isNumber = true;
    }
}

if (isNumber)
{
    Console.WriteLine("Van szám a szövegben.");
}
else
{
    Console.WriteLine("Nincs szám a szövegben.");
}
*/

/*
 * Kérjen be egy stringet, és írassa ki betűnként, mindegyiket új sorba!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Kiírja soronként
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}
*/

/*
 * Kérjen be egy stringet, és írassa ki visszafelé!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Kiírja visszafelé
for (int i = str.Length-1; i >= 0; i--)
{
    Console.Write(str[i]);
}

Console.WriteLine(str);

// Új sor
Console.WriteLine();
*/


/*
 * Kérjen be egy stringet, és írassa ki minden második betűjét
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Kiírja a szöveg minden második betűjét
for (int i = 1; i < str.Length; i += 2)
{
    Console.Write(str[i]);
}
// Új sor
Console.WriteLine();
*/

/*
 * Kérjen be egy stringet, és írassa ki úgy külön sorokba, hogy az i. sorban 
 * az első i darab betűje van!
 */

/*
// Bekérünk egy szöveget
Console.Write("Írjon be valamit! ");
string str = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt szöveg: " + str);

// Ez az i. sor
for (int i = 0; i < str.Length; i++)
{
    // Kiírja a szöveg első i. karakterét
    for (int j = 0; j <= i; j++)
    {
        Console.Write(str[j]);
    }
    Console.WriteLine();
}
*/

/*
 * Kérjen be egy állomány nevet, és írassa ki, hogy program-e 
 * (".com", ".exe", ".bat" az utolsó 4 karaktere)
*/

/*
// Bekérünk egy állomány nevet
Console.Write("Írjon be egy állománynevet! ");
string fileName = Console.ReadLine();

// A bekért szöveg ellenőrzése
Console.WriteLine("A beírt állománynév: " + fileName);

// Indikátor változó
// Az EndWith("minta") megadja, hogy az adott minta megtalálható-e a szövegben.
bool isProgram = (fileName.EndsWith(".com") ||  fileName.EndsWith(".exe") || fileName.EndsWith(".bat"));

if (isProgram)
{
    Console.WriteLine("Program.");
}
else
{
    Console.WriteLine("Nem program.");
}
*/

/*
 * Kérjen be két stringet, állapítsa meg, hogy része-e a második az elsőnek, s ha igen, 
 * akkor hányadik pozíción kezdődik benne!
*/

/*
// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string text = Console.ReadLine();

// Bekérünk egy mintát
Console.Write("Írja be a keresendő mintát! ");
string sample = Console.ReadLine();

// A bekért szöveg és minta ellenőrzése
Console.WriteLine("A beírt szöveg: " + text);
Console.WriteLine("A beírt minta: " + sample);

// Az IndexOf() metódus adja meg a minta helyét a szövegben.
int iSample = text.IndexOf(sample);
if (iSample == -1)
{
    Console.WriteLine("A keresett minta nem szerepel a szövegben.");
}
else
{
    Console.WriteLine("A keresett minta a szövegben a " + (iSample + 1) + ". helyen kezdődik.");
}
*/

/*
 * Kérjen be egy szöveget, s minden benne lévő nagy betűt alakítson át kis betűre, 
 * majd írassa ki!
*/


// Bekérünk egy szöveget
Console.Write("Írjon be egy szöveget! ");
string text = Console.ReadLine().ToLower();

// Az átalakított szöveg
Console.WriteLine("A kisbetűs szöveg: " + text);


/*
* Kérjen be egy számot, majd írassa ki úgy, hogy minden számjegye 2-vel nagyobb! 
* (8 ---0, 9---1).
*/

/*
// Bekérünk egy számot
Console.Write("Írjon be egy számot! ");
string number = Console.ReadLine();

// A beírt szám
Console.WriteLine("A beírt szám: " + number);

// Az átalakított szám
Console.WriteLine();

// Átalakítjuk a számot karaktertömbbé
char[] charNumberArray = number.ToCharArray();

// Végigmegyünk a szövegen
for (int i = 0; i < charNumberArray.Length; i++)
{
    switch (charNumberArray[i])
    {
        // Számjegyek cseréje 0-8 között
        case < '8':
            charNumberArray[i]++;
            charNumberArray[i]++;
            break;
        case '8':
            charNumberArray[i] = '0';
            break;
        case '9':
            charNumberArray[i] = '1';
            break;
    }
}

// Visszaalakítom a karektertömböt stringé
number = string.Join("", charNumberArray);

// Az átalakított szám
Console.WriteLine("Az átalakított szám: " + number);
*/

/*
 * A beolvasott mondatról döntse el, hogy az visszafelé is ugyanazt jelenti-e! 
 * (Az "Indul a görög aludni", vagy a "Géza kék az ég" visszafelé olvasva is 
 * ugyanazt jelenti.) Ügyeljen a mondatvégi írásjelekre, mivel azok a mondat 
 * elején nem szerepelnek.
*/

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