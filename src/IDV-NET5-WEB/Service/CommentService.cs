using IDV_NET5_WEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IDV_NET5_WEB.Service
{
    public class CommentService
    {
        HttpClient _client = new HttpClient(); 

        public Comment Get(int id)
        {
            var result = _client.GetAsync("http://localhost:54677/api/comments/"+id).Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Comment>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public List<Comment> GetByMovie(int id)
        {
            var result = _client.GetAsync("http://localhost:54677/api/comments/movie/" + id).Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Comment>>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public List<Comment> GetAll()
        {
            var result = _client.GetAsync("http://localhost:54677/api/comments/").Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Comment>>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }


    }
}
