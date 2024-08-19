using HtmlAgilityPack;

namespace program_web
{
    public static class Finding_Email
    {
        public static string Searching_Email_on_Website(string url, string emailWanted)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument website_details = web.Load(url);

            bool checkEmail = Correct_email_construction.Check_Email(emailWanted);
            if (checkEmail == false)
                return $"\nThe text entered looks like this: '{emailWanted}'. This is incorrect syntax for email, please do the test again";

            else
            {
                int i = 0;

                IEnumerable<HtmlNode> links = website_details.DocumentNode.Descendants("a").Where(x => x.Attributes.Contains("href"));
                foreach (var link in links)
                {
                    {
                        if (link.InnerText == emailWanted)
                        {
                            i++;
                        }
                    }
                }
                return $"\nEmail wanted: '{emailWanted}' on {url} appears {i} times.";
            }
        }
    }
}
