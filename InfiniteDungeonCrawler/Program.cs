bool isMainGameLoopActive = true;

while (isMainGameLoopActive)
{
    Console.Clear();
    Console.WriteLine("Enter the TEXTGEON");
    Console.WriteLine();
    Console.WriteLine("1. Play");
    Console.WriteLine("2. How to play");
    Console.WriteLine("3. Quit");
    Console.WriteLine();
    Console.WriteLine("Enter your choice: ");

    string userMenuChoice = Console.ReadLine();

    if (userMenuChoice == "1")
    {
        Console.Clear();
        Console.WriteLine("Let's play");
        Console.ReadLine();
    }

    else if (userMenuChoice == "2")
    {
        Console.Clear();
        Console.WriteLine("How to play");
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