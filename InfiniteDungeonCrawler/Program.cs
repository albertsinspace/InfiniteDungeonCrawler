bool isMainGameLoopActive = true;
bool isGameLoopActive = true;

while (isMainGameLoopActive)
{
    Console.Clear();
    Console.WriteLine("Enter the TEXTGEON");
    Console.WriteLine();
    Console.WriteLine("1. Play");
    Console.WriteLine("2. How to play");
    Console.WriteLine("3. Quit");
    Console.WriteLine();
    Console.WriteLine("Enter your choice... ");

    var userMenuChoice = Console.ReadLine();

    if (userMenuChoice == "1")
    {
        Console.Clear();
        Console.WriteLine("Let's play");
        Console.ReadLine();
    }

    else if (userMenuChoice == "2")
    {
        Console.Clear();
        Console.WriteLine("You start with nothing and as you progress through the dungeon levels you will collect loot which you can choose to keep or sell to the shopkeeper.\nYou can choose to just keep the loot as well if you'd like and simply continue on until you want to sell to the shopkeeper, all of it will stay in your inventory.");
        Console.WriteLine();
        Console.Write("Press any key to go back...");
        Console.ReadLine();
    }

    else if (userMenuChoice == "3")
    {
        Console.Clear();
        Console.WriteLine("Goodbye");
        isMainGameLoopActive = false;
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Incorrect input, please choose from the menu");
        Console.ReadLine();
    }
}