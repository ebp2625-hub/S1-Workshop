public class Employee : User
{

    public Employee(string name, int age, string cpr){
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

    public string GetName(){
        return name;
    }
    public int GetAge(){
        return age;
    }
    public string GetCpr(){
        return cpr;
    }

    public void addItem(){}
    public void removeItem(){}
}
