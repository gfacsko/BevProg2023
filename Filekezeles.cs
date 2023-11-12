/*
 * Fájlkezelő programok
 * 
 * Developed by Gabor FACSKO (facsko.gabor@uni-milton.hu)
 * Milton Friedman University, Budapest, Hungary, 2022 
 * 
 * */

/*
// StreamReader, StreamWriter


//Writing
StreamWriter sw = new StreamWriter(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\aa.txt");
// C:\Users\HL3E5Y\source\repos\FajlKezeles
sw.WriteLine("Üdv.");
sw.WriteLine("Ez C# példa");
sw.Close();

//Reading
StreamReader sr = new StreamReader(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\aa.txt");
Console.WriteLine(sr.ReadLine());
Console.WriteLine(sr.ReadLine());
sr.Close();
*/

// BinaryReader, BinaryWriter
/*
//Writing
Stream sin = new FileStream(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\bb.dat", FileMode.Create);
BinaryWriter bw = new BinaryWriter(sin);
bw.Write(124);
bw.Write("Gabor");
bw.Close();
sin.Close();

//Reading
Stream sout = new FileStream(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\bb.dat", FileMode.Open);
BinaryReader br = new BinaryReader(sout);
Console.WriteLine(br.ReadInt32());
Console.WriteLine(br.ReadString());
br.Close();
sout.Close();
*/


// Próbálgatás (játék)

// Csatorna létrehozása
StreamWriter sw = new StreamWriter(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt2.txt",true);

// Állomány írása
sw.WriteLine("Üdv!");

// Állomány lezárása
sw.Close();

// Olvasó csatorna létrehozása
StreamReader sr = new StreamReader(@"C:\Users\HL3E5Y\source\repos\FajlKezeles\teszt2.txt");

// Állomány olvasása
while (sr.EndOfStream == false)
{
    Console.WriteLine(sr.ReadLine());
}

// Állomány lezárása
sr.Close();
