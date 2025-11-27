class testGrid
{
    static string testGridMethod()
    {
        int x = 0;
        foreach (string room in roomArray)
        {
            bool roomExists = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (roomArray[i,j].roomId == grid[i,j].id)
                    {
                        roomExists = true;
                    }
                }
            }
            if (!roomExists)
            {
                x++;
            }
        }

        if (x > 0)
        {
            Console.WriteLine($"Error: {x} room(s) are missing from the building. Exit the application.");//Check fails: Some room doesn't exist.
        }

    }
    static string ArtworkContainer()
    {
        
    }
    static void GridMovementTest(Building building)
    {
        Random r = new Random();
        Room[] roomIds = new Room[] {E1, C1, GR1, BR1, BR2, RB1, PR1, WR1};
        Room chosenRoom = roomIds[r.Next(roomIds.Length)];
        int testCords = 0;
        string[,] grid = building.grid; 
        int targetx = chosenRoom.gridRow;
        int targety = chosenRoom.gridCollumn;
        int gridRow = chosenRoom.gridRow;
        int gridCollumn = chosenRoom.gridCollumn;

        building.MoveItem(gridRow, gridCollumn, testCords, testCords);
        string sucess = GridChecks(grid, testCords, testCords);
        if(sucess == "Failure")
        {
            Environment.Exit(0);
        }
        building.MoveItem( testCords, testCords, gridRow, gridCollumn);
        sucess =  GridChecks(grid, targetx, targety);
        if(sucess == "Failure")
        {
            Environment.Exit(0);
        }
    }

    public static string GridChecks(string[,] grid, int targetx, int targety)
    {
        string success = "Success";
        string failure = "failure";
    for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; i < grid.GetLength(1); j++)
            {
                if(i == targetx || j == targety)
                {
                    Console.WriteLine("Movement procceses: Room movement initialisation sucess.");
                    return success;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.ResetColor();
                    
                    Console.WriteLine("Movement procceses: Room movement initialisation FAILURE.");
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.ResetColor();
                    return failure;
                }
            }
        }
    return failure;
    }
}