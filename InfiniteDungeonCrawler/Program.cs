//ascii art generator from here: https://patorjk.com/software/taag/#p=display&f=Graffiti&t=TEXTGEON&x=none&v=4&h=4&w=80&we=false

bool isGameMenuActive = true;
bool isGameLoopActive = true;

List<string> startingText = new List<string> {"In a land as far as it is wide...", "As the sun rises to mark the age of a new dawn...", "With great bravery comes great sacrifice..."};
List<string> userInventory = new List<string> {"Wooden Sword", "Minor Healing Potion"};

int playerGold = 0;

Random rnd = new Random();
int ranNum = rnd.Next(0, startingText.Count());

string ranStartingText = startingText[ranNum];

string playerName = "";

while (isGameMenuActive)
{
    Console.Clear();
    Console.WriteLine(@"__________________________  _________________________________________    _______   
\__    ___/\_   _____/\   \/  /\__    ___/  _____/\_   _____/\_____  \   \      \  
  |    |    |    __)_  \     /   |    | /   \  ___ |    __)_  /   |   \  /   |   \ 
  |    |    |        \ /     \   |    | \    \_\  \|        \/    |    \/    |    \
  |____|   /_______  //___/\  \  |____|  \______  /_______  /\_______  /\____|__  /
                   \/       \_/                 \/        \/         \/         \/ ");
    Console.WriteLine();
    Console.WriteLine("1. Play");
    Console.WriteLine("2. How to play");
    Console.WriteLine("3. Quit");
    Console.WriteLine();
    Console.Write("Enter your choice... ");

    var userMenuChoice = Console.ReadLine();

    if (userMenuChoice == "1")
    {
        Console.Clear();
        Console.WriteLine(ranStartingText);
        Console.ReadLine();
        Console.WriteLine("Lives a warrior daring to enter the dungeons...");
        Console.ReadLine();
        Console.WriteLine("May this brave warrior go far and may the Gods show mercy upon their soul.");
        Console.ReadLine();
        Console.Clear();
        Console.Write("What is your name, brave warrior... ");
        playerName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Welcome, {playerName}.");
        Console.ReadLine();
        Console.Write("Are you ready?... (Press any key to continue) ");
        Console.ReadLine();

        while (isGameLoopActive)
        {
            Console.Clear();
        }
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
        Console.WriteLine("Goodbye, brave warrior...");
        isGameMenuActive = false;
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Incorrect input, please choose from the menu provided");
        Console.ReadLine();
    }
}