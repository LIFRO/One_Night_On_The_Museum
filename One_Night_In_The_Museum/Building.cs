public class Building()
{
    public Room[,] grid = new Room[8, 8];
    
    public void AddToGrid(int row, int collumn, Room room)
    {
        grid[row, collumn] = room;
    }

    public void MoveItem(int FromRow, int FromColumn, int ToRow, int ToColumn)
    {
        grid[ToRow, ToColumn] = grid[FromRow, FromColumn];
        grid[FromRow, FromColumn] = null;
    }
    
    public void LoadDefaultRooms()
    {
    this.AddToGrid(0, 3, E1);
    this.AddToGrid(1, 3, C1);
    this.AddToGrid(2, 3, GR1);
    this.AddToGrid(3, 3, BR1);
    this.AddToGrid(4, 3, BR2);
    this.AddToGrid(2, 4, RB1);
    this.AddToGrid(3, 4, PR1);
    this.AddToGrid(3, 2, WR1);
    }
}