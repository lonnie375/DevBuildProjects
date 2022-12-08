namespace NASAAPIFUN.Models
{
    //user provides date 
    // drop down of name of rovers "Curiosity, Opportunity, and Spirit"
    // will see page listing the photos 
    public class RoverResponse
    {
        public List<PhotoResponse> photos { get; set; }

    }

    public class PhotoResponse
    {
        public string img_src { get; set; }
        public string earth_date { get; set; }
        public string sol { get; set; }
        public Rover roverName { get; set; }
    

    }

    public class Rover
    {
        public string name { get; set; }
       
    }

    //DAL 

    //public class NASAAPI
    //{
    //    public static HttpClient _web = null;

    //    public static HttpClient GetHttpClient()
    //    {
    //        if (_web == null)
    //        {
    //            _web = new HttpClient();
    //            _web.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/");
    //        }
    //        return _web;
    //    }

    //    //GetPhotos for user
    //    public async static Task<RoverResponse> FindPhoto(PhotoResponse photo)
    //    {
    //        HttpClient _web = GetHttpClient();
    //        var connection = await _web.GetAsync($"v1/rovers/curiosity/photos?earth_date=2015-06-03&api_key=Rvlc9pRqISHsBiywq1F8GhEHghUN9ddUE6f2dMd1"); 
    //        RoverResponse resp = await connection.Content.ReadAsAsync<RoverResponse>();
            
    //        return resp;
    //    }


    //}
}
