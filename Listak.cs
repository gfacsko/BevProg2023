/*
 * Listák segédprogram
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, 2023
 */

using System.Collections;

void arrayListaKiiras(ArrayList alista)
{
    if (alista.Count == 0)
        Console.WriteLine("Az ArrayList üres.");
    else
    {
        Console.Write("A lista elemei: ");
        foreach (var al in alista)
            Console.Write(al + " ");
        // Új sor
        Console.WriteLine();
    }
}


List<int> li = new List<int>();


/*
listaKiiras(li);
Console.WriteLine(li.Capacity);
Console.WriteLine(li.Count);

li.Add(11);

listaKiiras(li);
Console.WriteLine(li.Capacity);
Console.WriteLine(li.Count);

li.Add(3);

listaKiiras(li);
Console.WriteLine(li.Capacity);
Console.WriteLine(li.Count);

li.Add(5);
li.Add(7);

listaKiiras(li);
Console.WriteLine(li.Capacity);
Console.WriteLine(li.Count);

li.Add(2);

listaKiiras(li); 
Console.WriteLine(li.Capacity);
Console.WriteLine(li.Count);

// Sorbarendezés
li.Sort();
listaKiiras(li);

// Megfordítás
li.Reverse();
listaKiiras(li);

Console.WriteLine(li[2]);
*/

/*
List<double> ld = new List<double>();

ld.Add(2.71);
ld.Add(3.14);

listaKiiras(ld);


string[] allatok = { "Láma", "Tehén", "Elefánt" };
List<string> ls = new List<string>(allatok);

listaKiiras(ls);
*/
ArrayList arlist = new ArrayList();
// or 
//var arlist = new ArrayList(); // recommended 

// adding elements using ArrayList.Add() method
/*var arlist1 = new ArrayList();
arlist1.Add(1);
arlist1.Add("Bill");
arlist1.Add(" ");
arlist1.Add(true);
arlist1.Add(4.5);
arlist1.Add(null);*/


// adding elements using object initializer syntax
var arlist1 = new ArrayList() { 2, "Bill", 3,7,8, 4};
arrayListaKiiras(arlist1);

//arlist1.Sort();
arrayListaKiiras(arlist1);

//Elemek eltávolítása
arlist1.Remove("Bill");
arrayListaKiiras(arlist1);
//Elemek eltávolítása adott helyen
//arlist1.RemoveAt(2);
//arrayListaKiiras(arlist1);
arlist1.Sort();

//Több elem eltávolítása
//arlist1.RemoveRange(1,2);
arrayListaKiiras(arlist1);




