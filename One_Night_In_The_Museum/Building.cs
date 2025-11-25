class building()
{
    string[,] grid = new string[8, 8];
    
    void  MoveItem(string[,] grid, int FromRow, int FromColumn, int ToRow, int ToColumn)
    {
        grid[ToRow, ToColumn] = grid[FromRow, FromColumn];
        grid[FromRow, FromColumn] = null;
    } 
}