namespace One_Night_In_The_Museum.UnitTests;

public class UnitTest2
{
     [Fact]
     public void Checkadjacent_ReturnAdjacent()
    {
        Building building = new Building();
        building.grid = new Room[3, 3];

        Room center = new Room("center room", 1,1, "center", building);
        Room north = new Room("north room", 0,1, "north", building);
        Room east = new Room("east room", 1,2, "east", building);

        building.grid[1, 1] = center;
        building.grid[0, 1] = north;
        building.grid[1, 2] = east;

        List<Room?> adjacents = center.CheckAdjacent();

        Assert.Equal(2, adjacents.Count);
        Assert.Contains(east, adjacents);
        Assert.Contains(north, adjacents);
    }
}