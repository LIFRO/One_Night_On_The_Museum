public class Room
{
    public List<Artwork> artworks = new List<Artwork>();
    public string name;
    public int gridRow;
    public int gridCollumn;
    public string id;
    public Building Building;

    bool upExists = false; 
    bool downExists = false;
    bool leftExists = false;
    bool rightExists = false;

    

    public Room(string name, int row, int col, string id, Building Building)
    {
        this.name = name;
        this.gridRow = row;
        this.gridCollumn = col;
        this.id = id;
        this.Building = Building;
    }

    private void ChoiceIfNoArtworks()
    {
        Console.Write($"Welcome to the {name}! There are no artworks here. Do you want to visit another room or start over?");
        Console.WriteLine("[1] Visit another room");
        Console.WriteLine("[2] Start over");
        string userInput = Console.ReadLine();
        
        switch (userInput)
        {
            case "1":
                Console.Write("Which room do you want to visit?");
                //Room list, move option
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                break;

            case "2":
                Console.Clear();
                break;

            default:
                Console.Write("Invalid choice, please try again! Please try again.");
                break;
        }    
    }

    private void ChoiceIfYesArtworks() {
        Console.Write($"Welcome to the {name}! There are {artworks.length} here. Do you want to check them out, visit another room or start over?");
        Console.WriteLine("[1] Check out artworks");
        Console.WriteLine("[2] Visit another room");
        Console.WriteLine("[3] Start over");
        Room[] Adjacent = CheckAdjacent(); 
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.Write("These artworks hang in this room. How neat!");
                //Skriv ut alla artworks i rummet
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                break;

            case "2":
                Console.Write("Which room do you want to visit?");
                Console.Write(Adjacent[0]);

            string moveInput = Console.ReadLine();
                PlayerMovement;
                //Room list, move option
                break;

            case "3":
                Console.Clear();
                break;

            default:
                Console.Write("Invalid choice, please try again!");
                break;
        }    
    }
    
    public void PlayerMovement()
    {
        switch()
        {
            case "1":
            Adjacent[0].Entered();
            break;

            case "2":
            Adjacent[1].Entered();
            break;

            case "3":
            Adjacent[2].Entered();
            break;

            case "4":
            Adjacent[3].Entered();
            break;

            default:
            Console.WriteLine("That's not a room! Please try again.");
            break;
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

        foreach(Room room in adjacents) {
            Console.Log();
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
                    gridCollumn = c; 
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

        if (Building.grid[this.gridRow + 1, this.gridCollumn] != null)
        {
            adjacents.Add(Building.grid[this.gridRow + 1, this.gridCollumn]);
            rightExists = true;
        }
        if ((Building.grid[this.gridRow - 1, this.gridCollumn] != null) && this.gridRow != 0)
        {
            adjacents.Add(Building.grid[this.gridRow - 1, this.gridCollumn]);
            leftExists = true;
        }
        if (Building.grid[this.gridCollumn + 1, this.gridRow] != null)
        {
            adjacents.Add(Building.grid[this.gridCollumn + 1, this.gridRow]);
            upExists = true;
        }
        if ((Building.grid[this.gridCollumn - 1, this.gridRow] != null) && this.gridCollumn != 0)
        {
            adjacents.Add(Building.grid[this.gridCollumn - 1, this.gridRow]);
            downExists = true;
        }
        return (adjacents);
    }

}