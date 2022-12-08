namespace TopStories.Models
{

        public class Result
        {
            public string section { get; set; }
            public string subsection { get; set; }
            public string title { get; set; }
            public string abstracts { get; set; }
            public string url { get; set; }
            public string uri { get; set; }
            public string byline { get; set; }
            public string item_type { get; set; }
            public DateTime published_date { get; set; }
            public string short_url { get; set; }
        }

        public class Root
        {
            public List<Result> result { get; set; }
        }

    public class TopStoryAPI
    {
        public static HttpClient _web = null;

        public static HttpClient GetHttpClient()
        {
            if (_web == null)
            {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://api.nytimes.com/svc/topstories/v2/");
            }
            return _web;
        }

       //Find Article by Category 
       public async static Task<Stories> FindArticle(string category)
        {
            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync($"{category}.json?api-key=vgKGJsdDTitdsMiIHQBeXMWyfPHADB3S");
            Result results = await connection.Content.ReadAsAsync<Result>();

            Stories myStories = new Stories();
            myStories.title = results.title; 
            myStories.section = results.section;    
            myStories.byline= results.byline;
            myStories.uri = results.uri;
            myStories.url = results.url;
            myStories.subsection = results.subsection; 
            myStories.published_date = results.published_date;
            
           
            
            return myStories; 
        }


    }
}
