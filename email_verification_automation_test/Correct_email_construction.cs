using System.Text.RegularExpressions;

namespace program_web
{
    public static class Correct_email_construction
    {
        public static bool Check_Email(string email)
        {            
            Regex email_construction = new Regex(@"^[a-zA-Z0-9]+\.?[a-z0-9]+\-?[a-z0-9]+@[a-z]+\.[a-z]{2,3}$"); 

            bool ifCorrectEmail = email_construction.IsMatch(email);
            return ifCorrectEmail;     
        }
    }
}
