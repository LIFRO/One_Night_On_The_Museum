
public class Building()
{
    public Room[,] grid = new Room[7, 7];
    
    public void AddToGrid(int row, int column, Room room)
    {
        grid[row, column] = room;
    }

    public void MoveItem(int FromRow, int FromColumn, int ToRow, int ToColumn)
    {
        grid[ToRow, ToColumn] = grid[FromRow, FromColumn];
        grid[FromRow, FromColumn] = null;
    }
}
