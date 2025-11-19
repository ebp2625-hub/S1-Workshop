using System.Runtime.CompilerServices;

namespace Domain.User
{
    class Borrower : User{

    public Borrower(string name, int age, string cpr){
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

    public void listCollection(){}
    public void rateItem(){}

    }

}
