
using System.Text.RegularExpressions;

public static class  Validatot
{
    public static bool IsValidname(in string name, out string formattedname)
    {
       formattedname = string.Empty;
        if(string.IsNullOrEmpty(name))
            return false;
        formattedname = name.Trim();
        if (Regex.IsMatch(formattedname, @"^[a-zA-Z'-]+$"))
            return true;
        else
            return false;
    }

    public static bool IsValidEmailAddres(in string email, out string formattedemail)
    {
        formattedemail = string.Empty;
        if (string.IsNullOrEmpty(email))
            return false;
        
        formattedemail  = email.Trim();
        if(Regex.IsMatch(formattedemail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            return true;
        else
            return false;
    }

    public static bool IsValidAge(in int age)
    {

        if(age < 0) return false;
        
        if(age > 100) return false;
        
        return true;
    }

    public static bool IsvalidPhoneNumber(in string phoneNumber,out string formattedPhoneNumber)
    {
        formattedPhoneNumber = string.Empty;
        if(phoneNumber == null) return false;
        
        formattedPhoneNumber = phoneNumber.Trim();

        if (Regex.IsMatch(formattedPhoneNumber, @"^\+?\d{ 1,3}?[-.\s]?\(?\d{ 1,4}\)?[-.\s]?\d{ 1,4}[-.\s]?\d{ 1,9}$"))
            return true;
        else
            return false;

    }
}
