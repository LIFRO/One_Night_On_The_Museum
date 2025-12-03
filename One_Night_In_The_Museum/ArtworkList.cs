using One_Night_In_The_Museum;

public static class ArtworkList{
        public static Artwork[] CentralArtworks = new Artwork[]
        {
                new Artwork { Title = "Starry Night", Artist = "Vincent van Gogh", Description = "A swirling night sky over a quiet village, expressing turbulence and emotion." },
                new Artwork { Title = "The Persistence of Memory", Artist = "Salvador Dalí", Description = "Melting clocks in a dreamlike desert landscape, exploring the fluidity of time." },
                new Artwork { Title = "Mona Lisa", Artist = "Leonardo da Vinci", Description = "Portrait of a woman with an enigmatic smile, capturing subtle emotion and realism." },
                new Artwork { Title = "The Scream", Artist = "Edvard Munch", Description = "A figure in anguish under a blood-red sky, symbolizing existential dread." },
                new Artwork { Title = "Girl with a Pearl Earring", Artist = "Johannes Vermeer", Description = "A young girl turning toward the viewer, emphasizing light and texture." },
                new Artwork { Title = "Guernica", Artist = "Pablo Picasso", Description = "A chaotic monochrome scene depicting the horrors of war and suffering." },
                new Artwork { Title = "The Birth of Venus", Artist = "Sandro Botticelli", Description = "Venus emerging from the sea on a shell, representing beauty and classical mythology." },
                new Artwork { Title = "American Gothic", Artist = "Grant Wood", Description = "A stern farmer and his daughter in front of a farmhouse, exploring rural life and morality." },
                new Artwork { Title = "The Night Watch", Artist = "Rembrandt van Rijn", Description = "A dynamic militia company scene with dramatic light and movement." },
                new Artwork { Title = "The Kiss", Artist = "Gustav Klimt", Description = "A couple embracing in a shimmering golden environment, expressing love and intimacy." },
                new Artwork { Title = "Las Meninas", Artist = "Diego Velázquez", Description = "A complex portrait capturing the Spanish royal family with layered perspectives." },
        };

        public static void ArtworkAdd(Room room, int startIndex, int count)
    {
        var ArtworksArray = ArtworkList.CentralArtworks.Skip(startIndex).Take(count).ToArray();
        foreach(Artwork artwork in PRArtworksArray)
        {
                room.artworks.Add(artwork);
        }
    }
};
