int number = 1;
do
{
    number *= 2;
    Console.WriteLine(number);


} while (number < 100);





Random randomNumbergenerator = new Random();

int knighthealth;
Console.Write("enter the knight's health:  ");
string input = Console.ReadLine();  

bool isvalidnumber = int.TryParse(input, out knighthealth);
if(isvalidnumber == true)
{ 
    if(knighthealth <= 0  || knighthealth > 100)
    {
        //ongeldige waarde ingegeven, waarde 100 gebruiken< 

        Console.WriteLine("Number must be between 0 and 100, default value 100 is used.");
        knighthealth = 100;
    }



}
else
{
    //ongeldige getal ingegegeven, standaard waarde 100 gebruiken
    Console.WriteLine("invalid input, default value 100 is used.");
    knighthealth = 100;

}

            int goblinhealth = randomNumbergenerator.Next(1, 30);

for (int attempt = 1; attempt <= 4; attempt++)
{

    Console.WriteLine($"Knighthealth: {knighthealth}");
    Console.WriteLine($"goblinhealth: {goblinhealth}");



    Console.WriteLine("available actions:");
    Console.WriteLine("1 attack");
    Console.WriteLine("2 heal");
    Console.Write("please select an action: ");
    string action = Console.ReadLine();

    int knightattack = 10;
    int goblinattack = 10;


    switch (action)
    {

        case "1":
            goblinhealth -= knightattack;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You attacked the goblin for <{knightattack}");
            Console.ResetColor();

            break;

        case "2":
            knighthealth += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You healed yourself for 10 health points");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"invalid move Please choose a valid action");
            Console.ResetColor();

            break;
    }

    if ( goblinhealth > 0 )
    {
        knighthealth -= goblinattack;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"you were killed by the goblin");
        Console.ResetColor();

    }

    if (knighthealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lost, the knight died");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"Knighthealth: {knighthealth}");

    }

    if (goblinhealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win, the goblin died");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"goblinhealth: {goblinhealth}");
    }

    Console.WriteLine();
}while (goblinhealth > 0 && knighthealth > 0) ;

           












/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */


/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
