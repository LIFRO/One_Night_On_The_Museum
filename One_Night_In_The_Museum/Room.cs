public class Room
{
    public required Artwork[] artworks;
    public required string name;
    public required int gridRow;
    public required int gridCollumn;
    public required string id;

    public Room() { }

    public void RoomPlace(Building Building, int Row, int Collumn)
    {
        Building.grid[ Row, Collumn] = this;
        cordsearch(Building);
    }

    public void cordsearch(Building Building)
    {
        for (int r = 0; r < Building.grid.GetLength(0); r++)
        {
            for (int c = 0; r < Building.grid.GetLength(1); c++)
            {
                if (Building.grid[r,c] == this)
                {
                    gridRow = r;
                    gridCollumn = c; 
                }
            }
        }
    }
}