namespace RestAPI;

public class Users{
    private int password;
    public string? FName;
    public string? LName;
    public string? EmailId;
    public string? PhoneNo;
    public string? Password{
        set {
            password=value!.GetHashCode();
        }
    }
    public void change_password(string oldPass, string newPass){
        if (oldPass.GetHashCode() == password){
            password = newPass!.GetHashCode();
        }
        else{
            System.Console.WriteLine("Incorrect password");
        }
    }

    public bool verify_password(string password){
        if (this.password.GetHashCode()==password.GetHashCode()){
            return true;
        }
        return false;
    }

}