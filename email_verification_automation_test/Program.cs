using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace program_web
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://apnpromise.pl/kontakt/";
            Console.WriteLine($"Objective of the task: to find the email address: 'promise@promise.pl' on 'https://apnpromise.pl/kontakt/'");

            string enterEmail = "promise@promise.pl";
            var email = Finding_Email.Searching_Email_on_Website(url, enterEmail);
            Console.WriteLine(email.ToString());
        }
    }
}
