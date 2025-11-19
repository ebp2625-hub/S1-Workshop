public class App : Item
{
    string version;
    string publisher;
    string[] supportedPlatforms;
    double fileSize;

    public App(string title, string version, string publisher, string[] supportedPlatforms, double fileSize) : base(title){
        this.title = title;
        this.version = version;
        this.publisher = publisher;
        this.supportedPlatforms = supportedPlatforms;
        this.fileSize = fileSize;
    }

    public string GetVersion(){
        return version;
    }
    public string GetPublisher(){
        return publisher;
    }
    public string[] GetSupportedPlatforms(){
        return supportedPlatforms;
    }
    public double GetFileSize(){
        return fileSize;
    }

}
