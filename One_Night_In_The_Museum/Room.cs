public class Room
{
    public Artwork[] artworks;
    public string name;
    public int gridRow;
    public int gridCollumn;
    public string id;
    public Building Building;

    public Room(Artwork[]? artworks, string name, int row, int col, string id, Building Building)
    {
        this.artworks = artworks ?? Array.Empty<Artwork>();
        this.name = name;
        this.gridRow = row;
        this.gridCollumn = col;
        this.id = id;
        this.Building = Building;
    }


    private void ChoiceIfNoArtworks()
    {
        Console.Write($"Welcome to the {name}! There are no artworks here. Do you want to visit another room? ");
        Console.WriteLine("Yes [Y] No [N]");
        string userInput = Console.ReadLine();
        HandleNoArtworks(userInput);
    }

    private void ChoiceIfYesArtworks()
    {
        Console.Write($"Welcome to the {name}! There are {artworks.length} here. Do you want to check them out or visit another room?");
        Console.WriteLine("Check out artworks [1] Visit another room [2]");
        string userInput = Console.ReadLine();
        HandleRoomWithArt(userInput);
    }
tyguhikol
    void HandleNoArtworks(string userInput)
    {
        switch (userInput)
        {
            case "Y":
                break;

            case "N":
                Console.Write("Ok, do you want to start over?");
                break;
            default:
                Console.Write("Invalid choice, please try again!");
                break;
        }    

    }
    void HandleRoomWithArt(string userInput)
    {
        switch (userInput)
        {
            case "Y":
                break;

            case "N":
                Console.Write("Ok, do you want to start over?");
                break;
            default:
                Console.Write("Invalid choice, please try again!");
                break;
        }    

    }





    public void Entered()
    {
        Room[] adjacents = CheckAdjacent();
        if (this.artworks == null)
        {


            switch (userInput)
            {
                case "Y":
                Console.Write(adjacents);
                break;

                case "N":
                Console.Write("Okay, do you want to start over?");
                break;

            }
        }
        else
        {
            Console.Write($"Welcome to the {name}! There are {artworks.length} here. Do you want to check them out or visit another room?");
            Console.WriteLine("Check out artworks [1] Visit another room [2]");
            Console.ReadLine();
        }
        foreach(Room room in adjacents)
        {
            Console.Log
        }
        
    }

    public void CoordSearch()
    {
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

    public Room[] CheckAdjacent()
    {
        bool upExists = false; 
        bool downExists = false;
        bool leftExists = false;
        bool rightExists = false;

        Room[] adjacents = new Room[4];

        if (Building.grid[this.gridRow + 1, this.gridCollumn] != null)
        {
            adjacents[0] = Building.grid[this.gridRow + 1, this.gridCollumn];
        }
        if (Building.grid[this.gridRow - 1, this.gridCollumn] != null)
        {
            adjacents[1] = Building.grid[this.gridRow - 1, this.gridCollumn];
        }
        if (Building.grid[this.gridCollumn + 1, this.gridCollumn] != null)
        {
            adjacents[2] = Building.grid[this.gridCollumn + 1, this.gridCollumn];
        }
        if (Building.grid[this.gridCollumn - 1, this.gridCollumn] != null)
        {
            adjacents[3] = Building.grid[this.gridCollumn - 1, this.gridCollumn];
        }

        return (adjacents);
    }
}