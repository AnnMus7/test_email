using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace program_web
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://apnpromise.pl/kontakt/";
            Console.WriteLine($"Objective of the task: to find the email address: 'promise@promise.pl' on 'https://apnpromise.pl/kontakt/'");
            
            Console.WriteLine("\nPlease enter the email you would like to find on the site");
            string enterEmail = Console.ReadLine();
            
            var email = Finding_Email.Searching_Email_on_Website(url, enterEmail);
            Console.WriteLine(email.ToString());
        }
    }
}
