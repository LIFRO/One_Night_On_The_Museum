
public class Building()
{
    public Room[,] grid = new Room[2, 2];
    
    public void AddToGrid(int row, int collumn, Room room)
    {
        grid[row, collumn] = room;
    }

    public void MoveItem(int FromRow, int FromColumn, int ToRow, int ToColumn)
    {
        grid[ToRow, ToColumn] = grid[FromRow, FromColumn];
        grid[FromRow, FromColumn] = null;
    }
}
