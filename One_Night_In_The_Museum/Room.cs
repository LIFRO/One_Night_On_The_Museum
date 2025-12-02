public class Room
{
    public Artwork[] artworks;
    public string name;
    public int gridRow;
    public int gridCollumn;
    public string id;

    public Room(Artwork[]? artworks, string name, int row, int col, string id)
    {
    this.artworks = artworks ?? Array.Empty<Artwork>();
    this.name = name;
    this.gridRow = row;
    this.gridCollumn = col;
    this.id = id;
    }

    public void RoomPlace(Building Building, int Row, int Collumn)
    {
        Building.grid[ Row, Collumn] = this;
        cordsearch(Building);
    }

    public void Entered()
    {
        Console.WriteLine("");
    }
    public void cordsearch(Building Building)
    {
        for (int r = 0; r < Building.grid.GetLength(0); r++)
        {
            for (int c = 0; c < Building.grid.GetLength(1); c++)
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