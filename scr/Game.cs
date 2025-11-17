public class Game : Item
{
    string genre;
    string publisher;
    string[] supportedPlatforms;
    int releaseYear;
    
    public Game(string genre, string publisher, string[] supportedPlatforms, int releaseYear){
        this.genre = genre;
        this.publisher = publisher;
        this.supportedPlatforms = supportedPlatforms;
        this.releaseYear = releaseYear;
    }

    public string GetGenre(){
        return genre;
    }
    public string GetPublisher(){
        return publisher;
    }
    public string[] GetSupportedPlatforms(){
        return supportedPlatforms;
    }
    public int GetReleaseYear(){
        return releaseYear;
    }
}
