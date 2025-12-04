public class Room
{
    public List<Artwork> artworks = new List<Artwork>();
    public string name;
    public int gridRow;
    public int gridcolumn;
    public string id;
    public Building Building;
    public Room[] Rooms;

    bool upExists = false; 
    bool downExists = false;
    bool leftExists = false;
    bool rightExists = false;

    public Room(string name, int row, int col, string id, Building Building)
    {
        this.name = name;
        this.gridRow = row;
        this.gridcolumn = col;
        this.id = id;
        this.Building = Building;
    }
    public void WaitTimer(int Seconds)
    {
        Thread.Sleep(Seconds * 1000);
    }
    private void ChoiceIfNoArtworks()
    {
        bool menuloop = true;
        Console.Write($"Welcome to the {name}! There are no artworks here. Do you want to visit another room or start over?");
        Console.WriteLine("[1] Visit another room");
        Console.WriteLine("[2] Go back to the entrance.");

        while(menuloop == true){
        bool userInput = Int32.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.Write("Which room do you want to visit?");
                    //Room list, move option
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    menuloop = false;
                    break;

                case 2:
                    Console.WriteLine("Thank you for visiting the museum! Please exit throught the gift shop.");
                    WaitTimer(2);
                    Console.Clear();
                    menuloop = false;
                    break;

                default:
                    Console.Write("Invalid choice, please try again!");
                    break;
            }  
        }  
    }
    private void ChoiceIfYesArtworks() {
        bool menuloop = true;
        Console.Write($"Welcome to the {name}! There are {artworks.Count} here. Do you want to check them out, visit another room or start over?");
        Console.WriteLine("[1] Check out artworks");
        Console.WriteLine("[2] Visit another room");
        Console.WriteLine("[3] Start over");
        List<Room> Adjacent = CheckAdjacent();
        while(menuloop == true){
            bool userInput = Int32.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.Write("These artworks hang in this room. How neat!");
                    //Skriv ut alla artworks i rummet
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    menuloop = false;
                    break;

                case 2:
                    PlayerMovement();
                    menuloop = false;
                    break;

                case 3:
                    Console.WriteLine("Thank you for visiting the museum! Please exit throught the gift shop.");
                    WaitTimer(2);
                    Console.Clear();
                    menuloop = false;
                    break;

                default:
                    Console.Write("Invalid choice, please try again!");
                    break;
            }
        }
    }   
    public void PlayerMovement()
    {
     Console.Write("Which room do you want to visit?");
        //print adjacent rooms
        for (int i = 0; i < Rooms.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Rooms[i]}");
        }

        int moveInput;
        string input = Console.ReadLine();
        //player choice
        if (int.TryParse(input, out moveInput) && moveInput >= 1 && moveInput <= Rooms.Length)
        {
            int roomIndex = moveInput - 1;
            var roomChoice = Rooms[roomIndex];
            Console.WriteLine($"You walk into the {roomChoice}");                   
        }
        else 
        {
            Console.Write("Invalid choice, please try again!");
        }
    }
    public void Entered() {
        List<Room> adjacents = CheckAdjacent();

        if (this.artworks == null) {
            ChoiceIfNoArtworks();   
        }
        else {
            ChoiceIfYesArtworks();
        } 
    }
    public void CoordSearch() {
        for (int r = 0; r < Building.grid.GetLength(0); r++)
        {
            for (int c = 0; c < Building.grid.GetLength(1); c++)
            {
                if (Building.grid[r,c] == this)
                {
                    gridRow = r;
                    gridcolumn = c; 
                }
            }
        }
    }    
    public List<Room> CheckAdjacent()
    {
        upExists = false; 
        downExists = false;
        leftExists = false;
        rightExists = false;

        List<Room> adjacents = new List<Room>();
        adjacents.Clear();

        if (Building.grid[this.gridRow + 1, this.gridcolumn] != null)
        {
            adjacents.Add(Building.grid[this.gridRow + 1, this.gridcolumn]);
            rightExists = true;
        }
        if ((Building.grid[this.gridRow - 1, this.gridcolumn] != null) && this.gridRow != 0)
        {
            adjacents.Add(Building.grid[this.gridRow - 1, this.gridcolumn]);
            leftExists = true;
        }
        if (Building.grid[this.gridcolumn + 1, this.gridRow] != null)
        {
            adjacents.Add(Building.grid[this.gridcolumn + 1, this.gridRow]);
            upExists = true;
        }
        if ((Building.grid[this.gridcolumn - 1, this.gridRow] != null) && this.gridcolumn != 0)
        {
            adjacents.Add(Building.grid[this.gridcolumn - 1, this.gridRow]);
            downExists = true;
        }
        return adjacents;
    }
}