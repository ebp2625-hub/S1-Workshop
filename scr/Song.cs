public class Song : Item
{
    string composer;
    string singer;
    string genre;
    string fileType;
    string language;
    double duration;
    
    public Song(string title, string composer, string singer, string genre, string fileType, string language, double duration) : base(title){
        this.title = title;
        this.composer = composer;
        this.singer = singer;
        this.genre = genre;
        this.fileType = fileType;
        this.language = language;
        this.duration = duration;
    }

    public string GetComposer(){
        return composer;
    }
    public string GetSinger(){
        return singer;
    }
    public string GetGenre(){
        return genre;
    }
    public string GetFileType(){
        return fileType;
    }
    public string GetLanguage(){
        return language;
    }
    public double GetDuration(){
        return duration;
    }
}
