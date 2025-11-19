public class Image : Item
{
    int[] resolution;
    string fileFormat;
    double fileSize;
    string dateTaken;

    public Image(string title, int[] resolution, string fileFormat, double fileSize, string dateTaken) :/*måske fejl*/ base(title){
        this.title = title;
        this.resolution = resolution;
        this.fileFormat = fileFormat;
        this.fileSize = fileSize;
        this.dateTaken = dateTaken;
    }

    public int[] GetResolution(){
        return resolution;
    }

    public string GetFileFormat(){
        return fileFormat;
    }

    public double GetFileSize(){
        return fileSize;
    }

    public string GetDateTaken(){
        return dateTaken;
    }
}
