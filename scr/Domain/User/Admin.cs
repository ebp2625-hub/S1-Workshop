namespace Domain.User
{
    class Admin : User{

        public Admin(string name, int age, string cpr){
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


        //getters and setter for all types of users
        public void getUser(){}
        public void removeUser(){}
    }
    
}
