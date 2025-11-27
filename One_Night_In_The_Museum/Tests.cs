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
}