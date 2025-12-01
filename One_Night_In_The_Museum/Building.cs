public class Building()
{
    public Room[,] grid = new Room[8, 8];
    
    public void MoveItem(int FromRow, int FromColumn, int ToRow, int ToColumn)
    {
        grid[ToRow, ToColumn] = grid[FromRow, FromColumn];
        grid[FromRow, FromColumn] = null;
    } 
}