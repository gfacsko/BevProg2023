/*
 * A 2023. november 27-én írt zh megoldása.
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 */


// (14)	Maldenbrot halmaznak 							
// (a) Hozzon létre kettős ciklussal olyan számpárokat, amelyek első száma -2 és +1.5, második száma -1.5 és 1.5 között változik 0.1-es lépésekkel.		

// Konstans
const int N = 20;

// Elmentem a számokat
double[] komplexRange = new double[N];
// Komplex számok
for (int i = 0; i < N; i++)
{
    komplexRange[i] = -2.0 + (double)i * 4.0 / (double)N;
    for (int j = 0; j < N; j++)
        Console.Write((-2 + (double)i * 4 / (double)N) + "," + (-2 + (double)j * 4 / (double)N) + " ");
};

// (b) Valósítsa meg a fenti transzformációt megvalósító függvényt.

double[] iter(double x1, double x2, double c1, double c2)
{
    double[] result = new double[2] { 0.0, 0.0 };

    x1 = x1 * x1 - x2 * x2 + c1;
    x2 = x1 * x2 + x2 * x1 + c2;

    result[0] = x1;
    result[1] = x2;

    return result;
};


// (c) Menjen végig az (a)-ban létrehozott számpárokon és vizsgálja meg, hogy 80 iteráció hatására végtelenné válnak-a. 									
// (d) Írja ki a (c)-beli vizsgálat eredményét úgy, hogy szóközöket és „*”-ot ír ki a képernyőre. A „*” a Maldenbrot halmaz része. 

// Iterációk maximális száma
const int M = 80;
// A maximális érték, amíg nem divergens az elem
const double vMax = 2.0;

// Képzetes tengely - Megcserélem, hogy vizszintes legyen a Maldenbrot halmaz.
foreach (double c2 in komplexRange)
{
    // A Maldenbrot halmaz karakteres megjelenítése
    string line = " ";
    // Valós tengely
    foreach (double c1 in komplexRange)
    {
        int i = 0;
        double x1 = c1;
        double x2 = c2;
        // Iterációk
        while ((Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2)) < vMax) && i < M)
        {
            i += 1;
            double[] z = iter(x1, x2, c1, c2);
            x1 = z[0];
            x2 = z[1];
            //x1 = x1 * x1 - x2 * x2 + c1;
            //x2 = x1 * x2 + x2 * x1 + c2;
        }
        if (i < M)
            line = line + " ";
        else
            line = line + ".";
    }
    Console.WriteLine(line);
    line = " ";
};