using System;

namespace One_Night_In_The_Museum.UnitTests;

public class MoveItemTests
{
    [Fact]
    
    public void MoveItemTest()
    {
        Building building = new Building();
        Room Test = new Room(null, "Test", 7, 7, "T1", building);

        building.AddToGrid(Test.gridRow, Test.gridCollumn, Test);
        building.MoveItem(7, 7, 0, 0);

        Assert.Equal(Test, building.grid[0,0]);
        Assert.Null(building.grid[7,7]);
    }
}

