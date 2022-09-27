using System;
System.Console.WriteLine("Hej! Välkommen till min frågesport!");
System.Console.WriteLine("Du kommer få en fråga med 3 alternativ. a, b eller c");
System.Console.WriteLine("Tryck på ENTER för att börja");
System.Console.ReadLine();

System.Console.WriteLine("Vilket land är världens minsta?");
System.Console.WriteLine("a=Lichtenstein  b=Monaco  c=Vatikanstaten");
string svar1 = System.Console.ReadLine();
if (svar1 == "c")
{
    System.Console.WriteLine("Rätt svar! Vi går till nästa fråga!");
    System.Console.WriteLine("Tryck på ENTER för att börja nästa fråga");
    System.Console.ReadLine();
    System.Console.WriteLine("Vart bor Leo?");
    System.Console.WriteLine("a=Södermalm  b=Haninge  c=Solna");
    string svar2 = System.Console.ReadLine();
    if (svar2 == "b")
    {
        System.Console.WriteLine("Rätt svar! Vi går till nästa fråga!");
        System.Console.WriteLine("Tryck på ENTER för att börja nästa fråga");
        System.Console.ReadLine();
        System.Console.WriteLine("Hur många fingrar har den genomsnittliga människan?");
        System.Console.WriteLine("a=10  b=11  c=9.5");
        string svar3 = Console.ReadLine();
        if (svar3 == "a")
        {
            System.Console.WriteLine("Rätt svar! Du vann!");
            System.Console.WriteLine("Tryck på ENTER för att avsluta");
        }
        if (svar3 != "a")
        {
            System.Console.WriteLine("Fel svar. Frågesporten är över...");
            System.Console.WriteLine("Tryck på ENTER för att avsluta");
        }

    }
    if (svar2 != "b")
    {
        System.Console.WriteLine("Fel svar. Frågesporten är över...");
        System.Console.WriteLine("Tryck på ENTER för att avsluta");
    }
}
if (svar1 != "c")
{
    System.Console.WriteLine("Fel svar. Frågesporten är över...");
    System.Console.WriteLine("Tryck på ENTER för att avsluta");

}







System.Console.ReadLine();

