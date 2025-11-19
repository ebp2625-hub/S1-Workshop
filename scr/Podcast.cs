public class Podcast : Item
{
    string[] hosts;
    string[] guests;
    string language;
    int episodeNumber;

    public Podcast(string title, string[] hosts, string[] guests, string language, int episodeNumber) : base(title){
        this.title = title;
        this.hosts = hosts;
        this.guests = guests;
        this.language = language;
        this.episodeNumber = episodeNumber;
    }

    public string[] GetHosts(){
        return hosts;
    }
    public string[] GetGuests(){
        return guests;
    }
    public string GetLanguage(){
        return language;
    }
    public int GetEpisodeNumber(){
        return episodeNumber;
    }
}
