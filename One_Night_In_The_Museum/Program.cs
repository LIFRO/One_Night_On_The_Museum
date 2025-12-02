// See https://aka.ms/new-console-template for more information
Building Building = new Building();
Building.LoadDefaultRooms();
Room E1  = new Room(null, "Entre", 0, 3, "E1");
Room C1  = new Room(null, "Corridor", 1, 3, "C1");
Room GR1 = new Room(null, "GreenRoom", 2, 3, "GR1");
Room BR1 = new Room(null, "BlueRoom", 3, 3, "BR1");
Room BR2 = new Room(null, "BlackRoom", 4, 3, "BR2");
Room RB1 = new Room(null, "RedRoom", 2, 4, "RB1");
Room PR1 = new Room(null, "PurpleRoom", 3, 4, "PR1");
Room WR1 = new Room(null, "WhiteRoom", 3, 2, "WR1");

E1.Entered();