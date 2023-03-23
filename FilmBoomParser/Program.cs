using HtmlAgilityPack;
namespace FilmBoomParser
{

    class Program
    {

        static void Main(string[] args)
        {
            // Load the HTML code of https://rezka.ag/
            var web = new HtmlWeb();
            var doc = web.Load("https://rezka.ag/");

            // Find all anchor tags in the HTML code
            var links = doc.DocumentNode.SelectNodes("//a[@href]");

            // Check if links is not null before trying to access it
            if (links != null)
            {
                // Extract the "href" attribute from each anchor tag and print it to the console
                foreach (var link in links)
                {
                    var href = link.GetAttributeValue("href", null);
                    if (!string.IsNullOrEmpty(href) && href.StartsWith("http"))
                    {
                        Console.WriteLine(href);
                    }
                }
            }
            else
            {
                Console.WriteLine("No links found.");
            }


        }
        public async Task some()
        {

            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.imdb.com/title/tt1675434/");
            Console.WriteLine(response);

            //    var result = JsonConvert.DeserializeObject<FBEVENTS>(response);



        }




    }


}