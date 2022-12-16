using TheFountainOfObjects;

int lastX = 0; ;
int lastY = 0;
bool wincondition = false;


Introduction();
MapSelection();


int Size = Convert.ToInt32(Console.ReadLine());
switch (Size)
{
    case 1: Size = 2; Console.WriteLine("You have selected the small map"); break;
    case 2: Size = 5; Console.WriteLine("You have selected the medium map");  break;
    case 3: Size = 7; Console.WriteLine("You have selected the large map"); break;

}

Console.WriteLine("Please enter 'start' in order to start the game otherwise press help for more information");
string startstring = Console.ReadLine();

if (startstring == "start" || startstring == "Start")
{

    Console.WriteLine("You are now at position: " + lastX + "," + lastY);


    PlayerActions playerInitilization = new PlayerActions(lastX, lastY, Size, Size);

    
    EnvironmentActions world = new EnvironmentActions(0, 2, Size, Size);
    



while (world.IsTurnedOn == false || (lastX != 0 || lastY != 0))
    {
        Console.WriteLine("---------------------------------------------------------");
        if (lastX >= 0 && lastY >= 0 && lastX <= Size && lastY <= Size)
        {
            Console.WriteLine("What do you want to do?");
            string input = Console.ReadLine();

            if (input == "move up" && lastX >= 0 && lastY >= 0 && lastX <= Size && lastY <= Size )
            {

                PlayerActions player = new PlayerActions(lastX, playerInitilization.moveUp(lastX, lastY), Size, Size);
                lastY = playerInitilization.moveUp(lastX, lastY);
                Console.WriteLine("You are now at position: " + lastX + "," + lastY);
                world.FountainProximityNotification(lastX, lastY);
            }
            if (input == "move down" && lastX >= 0 && lastY >= 0 && lastX <= Size && lastY <= Size)
            {

                PlayerActions player = new PlayerActions(lastX, playerInitilization.moveDown(lastX, lastY), Size, Size);
                lastY = playerInitilization.moveDown(lastX, lastY);
                Console.WriteLine("You are now at position: " + lastX + "," + lastY);
                world.FountainProximityNotification(lastX, lastY);
            }
            if (input == "move left" && lastX >= 0 && lastY >= 0 && lastX <= Size  && lastY <= Size )
            {

                PlayerActions player = new PlayerActions(playerInitilization.moveLeft(lastX, lastY), lastY, Size, Size);
                lastX = playerInitilization.moveLeft(lastX, lastY);
                Console.WriteLine("You are now at position: " + lastX + "," + lastY);
                world.FountainProximityNotification(lastX, lastY);
            }
            if (input == "move right" && lastX >= 0 && lastY >= 0 && lastX <= Size && lastY <= Size)
            {

                PlayerActions player = new PlayerActions(playerInitilization.moveRight(lastX, lastY), lastY, Size, Size);
                lastX = playerInitilization.moveRight(lastX, lastY);
                Console.WriteLine("You are now at position: " + lastX + "," + lastY);
                world.FountainProximityNotification(lastX, lastY);
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This move will put you out out of board please try again");
            if (lastX > Size || lastY > Size)
            {
                if (lastX > Size) { lastX = lastX - 1; }
                if (lastY > Size) { lastY = lastY - 1; }
            }
            if (lastX < 0 || lastY < 0)
            {
                if (lastX < 0) { lastX = lastX + 1; }
                if (lastY < 0) { lastY = lastY + 1; }
            }
            Console.WriteLine("Your current position is " + lastX + "," + lastY);
            Console.ForegroundColor = ConsoleColor.White;

        }

        WinAnnouncement(world.IsTurnedOn);


    }
}

if (startstring == "help" || startstring == "Help")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("The fountain of Objects game is a 2d grid based world full of rooms. Most rooms are empty, but a few" +
        "are unique rooms. ");
    Console.WriteLine();
    Console.WriteLine("One room is the cavern entrance. Another is the fountain room containing the fountain of objects.");
    Console.WriteLine();
    Console.WriteLine("The player moves through the cavern system one room at at time to find the Fountain of Objects.");
    Console.WriteLine();
    Console.WriteLine("They activate it and then return to the ntrance of the game");
    Console.WriteLine();
    Console.WriteLine("In order to win, the player must find the fountain, activate it and return to the entrance without dying");
    Console.WriteLine("To move your character enter move up, move down, move left or move right");
    Console.ForegroundColor = ConsoleColor.White;
}


void WinAnnouncement(bool FountainOn)
{
    if (FountainOn == true && (lastX == 0 && lastY == 0))
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("**************************************************************");
        Console.WriteLine("Congratulations! You have turned the fountain on and return to the entrance unharmed");
        Console.WriteLine("**************************************************************");
    }
}
void Introduction()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Welcome to the Fountain of Objects");
    Console.WriteLine();
    Console.WriteLine("To access the help page write help!");
    Console.WriteLine("To begin playing the game write start");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("--------------------------------------");
}
void MapSelection()
{
    Console.WriteLine("Please select a map size by pressing the appropriate button");
    Console.WriteLine();
    Console.WriteLine("1: Small: 3x3");
    Console.WriteLine("2: Medium: 6x6");
    Console.WriteLine("3: Large: 8x8");
    Console.WriteLine("--------------------------------------");
}


