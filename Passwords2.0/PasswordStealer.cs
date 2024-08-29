namespace Passwords2._0;

public class PasswordStealer
{
    public static bool AddPassword(string password, List<string> passwords)
    {
        string vowels = "AEIOUY";
        int count = 0;
        foreach (string p in passwords)
        {
            if (p == password)
            {
                return false;
            }
        }
        if (password == "admin" || password == "mod")
        {
            return true;
        }
        /*if (password.Length > 7 && password.Length < 12) // allowed
        {
            return true;
        }*/
        if (password.Length < 7 || password.Length > 12) // if else was used logic error
        {
            return false; 
        }
        if (password.Contains('6') || !password.Contains("123457890") || password.Contains(' ')) // reverse order to return false 
        {
            return false;
        }
        foreach (char v in password)
        {
            if (vowels.Contains(v))
            {
                count++;
            }
        }
        if (count < 2)
        {
            return false;
        }
        return true;
    }
    
    /*public bool HereIAm(string x)
    {
        if (x == "hello")
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/
}