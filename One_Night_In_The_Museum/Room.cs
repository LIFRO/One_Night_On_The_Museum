class room
{
    Artwork[] artworks;
    string name;
    int gridRow;
    int gridCollumn;
    
    public room(Artwork[] artworks, string name, int gridRow, int gridCollumn)
    {
        this.artworks = artworks;
        this.name = name;
        this.gridRow = gridRow;
        this.gridCollumn = gridCollumn;
    }
}