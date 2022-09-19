// See https://aka.ms/new-console-template for more information
//Console.WriteLine("czvoj4o");
//Console.WriteLine("Hello from Rider");

/*
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace VyvojAplikaciS2
{
    internal class program
    {
        static void Main(string[] args)
        {
            


        }
    }
}


//32bit cela cislo = int
int stranaA = 10;
int stranaB = 15;
int result;

//64bit cela cislo = long
long dlouheCislo = 42L;

//3,4 * 10^-38 - 3,4 * 10^38
float desetinneCislo = 3.14F;

//3,4 * 10^-380 - 3,4 * 10^380
double desetinneCisloPresnejsi = 3.14;

decimal penize = 0.42M;

string jmeno = "David";
// NELZE string jmeno2 = 'Petr';
char pismeno = 'A';

bool pravda = true;
bool nepravda = false;

var promenna = "";





Console.Write("Delka strany A ->");
string strana1 = Console.ReadLine();
Console.Write("Delka strany B ->");
string strana2 = Console.ReadLine();

stranaA = Int32.Parse(strana1);
stranaB = Int32.Parse(strana2);

        
int obvod = (stranaA + stranaB) * 2;
int obsah = stranaA * stranaB;
//string textResult = result.ToString() + "cm";

Console.Write("Obvod je: ");
Console.Write(obvod.ToString());
Console.WriteLine("cm");

Console.WriteLine("Obsah je: " + obsah.ToString() + "cm^2");
//Console.WriteLine($"Obsah je: {obsah.ToString()} cm^2");

Console.WriteLine($"Moje jméno je: {jmeno}");

*/

//const double pi = 3.14;


/*
x == y
x < y
x <= y
x > y
x >= y
x != y

x = true
y = false

x => true
y => false 
!x => false
!y => true
x && y => false
x || y => true

 


int cislo = Int32.Parse(Console.ReadLine());
if (cislo > 0)
{
    Console.WriteLine("Jedna se o prirozene cislo");
}
else if (cislo >= 0)
{
    Console.WriteLine("Je to cislo vetsi nez nula");
}
else
{
    Console.WriteLine(
        "vubec netusim co je to"
        + " za cislo ale je mensi nez nula"
        );
}



Console.WriteLine("Kolik mas penez?");
int mojePenize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Kolik stoji pizza?");
int cenaPizzy = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ma pizzerie otevreno?");
string pizzeriaOtevreno = Console.ReadLine();


if (pizzeriaOtevreno == "ano")
{
    if (mojePenize >= cenaPizzy)
    {
        Console.WriteLine("Vse OK");
    }
    else if (mojePenize < cenaPizzy)
    {
        Console.WriteLine("Nemas dostatek penez");
    }
}
else
{
    Console.WriteLine("Pizzerie nema otevreno");
}


if ((pizzeriaOtevreno == "ano") && (mojePenize >= cenaPizzy))
{
  
   Console.WriteLine("Vse OK");
    
}
else if (mojePenize < cenaPizzy)
{
    Console.WriteLine("Nemas penize");
}
else
{
    Console.WriteLine("Pizzerie nema otevreno");
}


int volba = Int32.Parse(Console.ReadLine());


switch (volba)
{
    case 0:
            Console.WriteLine(
                "Jedna se o cislo: "
                + volba.ToString()
                );
        break;

    case 1:
        Console.WriteLine(
                "Jedna se o cislo: "
                + volba.ToString()
                );
        break;

    case 2:
        Console.WriteLine(
                "Jedna se o cislo: "
                + volba.ToString()
                );
        break;

    case 3:
        Console.WriteLine(
                "Jedna se o cislo: "
                + volba.ToString()
                );
        break;

    default:
        Console.WriteLine("nezname cislo");
        break;
    

}

if (volba == 1)
{
}
else if (volba == 2)
{ 
}


int a = 0;
while (a >= 0)
{

}
*/

//string vstup;
int vystup;
Console.Write("=> ");
while(!Int32.TryParse(Console.ReadLine(), out vystup))
{

}

int vystup2 = vystup;

while(vystup > 0)
{
    Console.WriteLine(vystup.ToString());
    //vystup = vystup - 1;
    //vystup++;
    vystup--;
}

do
{
    Console.WriteLine(vystup2.ToString());
    //vystup = vystup - 1;
    //vystup++;
    vystup2--;
} while (vystup2 > 0);
//do-while

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

int[] pole = new int[3];
pole[0] = 1;
pole[1] = 2;
pole[2] = 3;

foreach (int cislo in pole)
{
    Console.WriteLine(cislo);
}
for (int b = 0; b < pole.Length; b++)
{
    Console.WriteLine(pole[b]);
}
/*
 Pouze cela prirozena cisla 
1 - soucet
2 - pocet
3 - prumer
4 - maxCislo
5 - minCislo

OVERIT VSTUP
 */

Console.WriteLine();
Console.Write("Pro ukončení stiskni enter..");
Console.ReadLine();

