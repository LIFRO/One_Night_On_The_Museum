public class Room
{
    public List<Artwork> artworks = new List<Artwork>();
    public string name;
    public int gridRow;
    public int gridColumn;
    public string id;
    public Building Building;
    public Room[] Rooms;

    public Room(string name, int row, int col, string id, Building Building)
    {
        this.name = name;
        this.gridRow = row;
        this.gridColumn = col;
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
        Console.WriteLine($"Welcome to the {name}! There are no artworks here. Do you want to visit another room or start over?");
        Console.WriteLine("[1] Visit another room");
        Console.WriteLine("[2] Go out of the museum");

        while(menuloop == true){
        bool userInput = Int32.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    PlayerMovement();
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
                    Console.WriteLine("Invalid choice, please try again!");
                    break;
            }  
        }  
    }
    private void ChoiceIfYesArtworks() {
        bool menuloop = true;
        Console.WriteLine($"Welcome to the {name}! There are {artworks.Count} artworks here. Do you want to check them out, visit another room or start over?");
        Console.WriteLine("[1] Check out artworks");
        Console.WriteLine("[2] Visit another room");
        Console.WriteLine("[3] Exit the museum");
        List<Room?> Adjacent = CheckAdjacent();
        while(menuloop == true){
            bool userInput = Int32.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("These artworks hang in this room. How neat!");
                    int i = 0;
                    foreach (Artwork artpiece in artworks)
                    {
                        i++;
                        Console.WriteLine($"[{i}] {artpiece.Title}");
                    }
                    string? line = Console.ReadLine();
                    if (!string.IsNullOrEmpty(line) && int.TryParse(line, out int input))
                    {
                        Artwork a= artworks[input - 1];
                        Console.WriteLine($"{a.Title} \n {a.Description} \n {a.Artist}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!");
                    }
                    Console.WriteLine($"Press any key to go back to {name}.");
                    Console.ReadKey();
                    ChoiceIfYesArtworks();
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
                    Console.WriteLine("Invalid choice, please try again!");
                    break;
            }
        }
    }   
    public void PlayerMovement()
    {
        Console.WriteLine("Which room do you want to visit?");
        //print adjacent rooms
        List<Room?> Rooms = CheckAdjacent();
        int i = 1;
        foreach (Room room in Rooms )
        {
            Console.WriteLine($"[{i}]{room.name}");
            i++;
        }
        int input = Int32.Parse(Console.ReadLine());
        if(input >= 1 && input <= Rooms.Count())
        {
            Room room = Rooms[input - 1];
            room.Entered();
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again!");
        }
    }
    public void Entered() {
        if (this.artworks == null || this.artworks.Count == 0) {
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
                    gridColumn = c; 
                }
            }
        }
    }    
    public List<Room?> CheckAdjacent()
    {
        List<Room> adjacents = new List<Room>();
        adjacents.Clear();
        int rows = Building.grid.GetLength(0);
        int collum = Building.grid.GetLength(1);

        if (this.gridRow + 1 < rows && Building.grid[this.gridRow + 1, this.gridColumn] != null)
        {
            adjacents.Add(Building.grid[this.gridRow + 1, this.gridColumn]);
        }
        if (this.gridRow - 1 >= 0 && (Building.grid[this.gridRow - 1, this.gridColumn] != null))
        {
            adjacents.Add(Building.grid[this.gridRow - 1, this.gridColumn]);
        }
        if (this.gridColumn + 1 < collum && Building.grid[this.gridRow, this.gridColumn + 1] != null)
        {
            adjacents.Add(Building.grid[this.gridRow, this.gridColumn + 1]);
        }
        if (this.gridColumn - 1 >= 0 && Building.grid[this.gridRow, this.gridColumn - 1] != null)
        {
            adjacents.Add(Building.grid[this.gridRow, this.gridColumn - 1]);
        }
        return adjacents;
    }
}