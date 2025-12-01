using System;

namespace One_Night_In_The_Museum.UnitTests;

public class MoveItemTests
{
    [Fact]
    
    public void MoveItemTest()
    {
        Building building = new Building();

        building.AddToGrid("test", 7, 7);
        building.MoveItem(7, 7, 0, 0);

        Assert.Equal("test", building.grid[0,0]);
        Assert.Null(building.grid[7,7]);
    }
}
