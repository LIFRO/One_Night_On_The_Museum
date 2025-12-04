namespace One_Night_In_The_Museum.UnitTests;

public class UnitTest1
{
    [Fact]
    public void ArtworkCreationTest()
    {
        var artwork = new Artwork() {Title = "MonaLisa", Artist = "Da Vinci", Description = "Cute Smile"};
        Assert.Equal("MonaLisa", artwork.Title);
        Assert.Equal("Da Vinci", artwork.Artist);
        Assert.Equal("Cute Smile", artwork.Description);

    }
}



