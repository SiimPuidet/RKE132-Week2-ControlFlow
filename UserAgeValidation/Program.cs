// Rakendus küsib kasutaja vanust
Console.WriteLine("Enter your age");
string userAge = Console.ReadLine();
int userAgeNum = 0;
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum); // boolean - true/false
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

//int userAge = Int32.Parse(Console.ReadLine()); //"Int" sisestab vahemällu numbri, mis laseb järgmistes sammudes kasutada matemaatilisi lahendeid. "String" sisestaks sõna ja suurem/väiksem tehted ei toimiks.

// Kui vanus on sisestatud numbriliselt, antakse üks kahest väljundist:
if (isAgeNumber == true)
{
    // Kui kasutaja vanus on väehmalt 13, siis konsoolis kuvatakse: "Welcome to Instagram!".
    if (userAgeNum >= 13) { Console.WriteLine("Welcome to Instagram!"); }
    //if(userAge >= 13) {Console.WriteLine("Welcome to Instagram!");}
   
    // Muul juhul kuvatakse: "You are too young to use Instagram.".
    else { Console.WriteLine("You are too young to use Instagram."); }
    //else {Console.WriteLine("You are too young to use Instagram.");}
}
//Kui vanus on sisestatud muul kujul kui ainult numbrid, antakse kasutajale teada, et vanust ei õnnestunud tuvastada.
else { Console.WriteLine("Could not read your age."); }