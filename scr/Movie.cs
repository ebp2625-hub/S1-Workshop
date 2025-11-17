public class Movie : Item
{
    string director;
    string[] genres;
    string language;
    int releaseYear;
    double duration;

    public Movie movie(string director, string[] genres, string language, int releaseYear, double duration){
        this.director = director;
        this.genres = genres;
        this.language = language;
        this.releaseYear = releaseYear;
        this.duration = duration;
    }
    public string GetDirector(){
        return director;
    }
    public string[] GetGenres(){
        return genres;
    }
    public string GetLanguage(){
        return language;
    }
    public int GetReleaseYear(){
        return releaseYear;
    }
    public double GetDuration(){
        return duration;
    }
}
