class testGrid
{
    static void testGridMethod()
    {
        int x = 0;
        foreach (string room in roomArray)
        {
            bool roomExists[x] = false;
            while (!roomExists)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (room.id == $"{i},{j}")
                        {
                            roomExists[x] = true;
                        }
                    }
                }
            }
            x++;
        }

        for (int i = 0; i < roomArray.length; i++)
        {
            
        }
    }
}