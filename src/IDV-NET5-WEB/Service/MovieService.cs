using IDV_NET5_WEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IDV_NET5_WEB.Service
{
    public class MovieService
    {
        HttpClient _client = new HttpClient(); 

        public Movie Get(int id)
        {
            var result = _client.GetAsync("http://localhost:54677/api/movies/"+id).Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Movie>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        
    }
}
