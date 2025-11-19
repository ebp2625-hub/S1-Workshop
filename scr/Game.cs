public class Game : Item
{
    string genre;
    string publisher;
    string[] supportedPlatforms;
    int releaseYear;
    
    public Game(string title, string genre, string publisher, string[] supportedPlatforms, int releaseYear) : base(title){
        this.title = title;
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
