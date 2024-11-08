// Rakendus küsib kasutaja sugu (m/f)
using System.Data;

Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist andmeid string formaadis

// Rakendus küsib kasutaja perekonnanime
Console.WriteLine("Please enter your last name");
string userLastName = Console.ReadLine();

// Rakendus tervitab kasutajat, lähtuvalt kasutaja valikutest
if(userGender == 'm')
{Console.WriteLine($"Welcome, Mr. {userLastName}!");} // Kui on sisestatud "m"
else if(userGender == 'f')
{Console.WriteLine($"Welcome, Ms. {userLastName}!");} // Kui on sisestatud "f"
else
{Console.WriteLine($"Welcome, {userLastName}!");} // Kui on sisestatud mingi muu täht
