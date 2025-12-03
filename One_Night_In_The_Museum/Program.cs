// See https://aka.ms/new-console-template for more information
Building Building = new Building();
Room E1  = new Room(null, "Entrance", 0, 3, "E1", Building);
Room C1  = new Room(null, "Corridor", 1, 3, "C1", Building);
Room GR1 = new Room(null, "Green Room", 2, 3, "GR1", Building);
Room BR1 = new Room(null, "Blue Room", 3, 3, "BR1", Building);
Room BR2 = new Room(null, "Black Room", 4, 3, "BR2", Building);
Room RB1 = new Room(null, "Red Room", 2, 4, "RB1", Building);
Room PR1 = new Room(null, "Purple Room", 3, 4, "PR1", Building);
Room WR1 = new Room(null, "White Room", 3, 2, "WR1", Building);

/*Entre = E1
Corridor C1
GreenRoom = GR1
BlueRoom = BR1
BlackRoom = BR2
RedRoom = RB1
PurpleRoom = PR1
WhiteRoom = WR1*/

ArtworkList.ArtworkAdd(WR1, 0, 1);
ArtworkList.ArtworkAdd(PR1, 1, 4);
ArtworkList.ArtworkAdd(BR1, 5, 1);
ArtworkList.ArtworkAdd(RB1, 6, 3);
ArtworkList.ArtworkAdd(GR1, 9, 2);


Room[] Rooms = new Room[]{E1, C1, GR1, BR1, BR2, RB1, PR1, WR1};

foreach(Room room in Rooms)
{
    Building.AddToGrid(room.gridRow, room.gridCollumn, room);
}

/*Building.AddToGrid(0, 3, E1);*/
/*Building.AddToGrid(1, 3, C1);*/
/*Building.AddToGrid(2, 3, GR1);*/
/*Building.AddToGrid(3, 3, BR1);*/
/*Building.AddToGrid(4, 3, BR2);*/
/*Building.AddToGrid(2, 4, RB1);*/
/*Building.AddToGrid(3, 4, PR1);*/
/*Building.AddToGrid(3, 2, WR1);*/

E1.Entered();
