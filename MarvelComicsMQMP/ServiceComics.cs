using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MarvelComicsMQMP
{
    public class ServiceComics
    {
        public async Task<ComicsList> GetComicsAsync(string query)
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url = "https://marvel.emreparker.com/v1/search/issues?q="+ query +"&limit=5";
            string data = await client.DownloadStringTaskAsync(url);
            ComicsList comics = JsonConvert.DeserializeObject<ComicsList>(data);
            return comics;
        }
    }
}
