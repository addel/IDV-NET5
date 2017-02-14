using IDV_NET5_WEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IDV_NET5_WEB.Service
{
    public class UserService
    {
        HttpClient _client = new HttpClient();

        public User Register(User user)
        {
         
            var jsonInString = JsonConvert.SerializeObject(user);
            var resPost = _client.PostAsync("http://localhost:54677/api/users/", new StringContent(jsonInString, Encoding.UTF8, "application/json")).Result;

            if (resPost.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<User>(resPost.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public User Login(User user)
        {

            var jsonInString = JsonConvert.SerializeObject(user);
            var resPost = _client.PostAsync("http://localhost:54677/api/users/login", new StringContent(jsonInString, Encoding.UTF8, "application/json")).Result;

            if (resPost.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<User>(resPost.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public bool deleteUser(int id)
        {

            var resdelete = _client.DeleteAsync("http://localhost:54677/api/users/" + id).Result;

            if (resdelete.IsSuccessStatusCode)
            {
                return true;
            }
            else
                return false;
        }

        public List<User> List()
        {
            var result = _client.GetAsync("http://localhost:54677/api/users/list").Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<User>>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public User GetSingle(int id)
        {
            var result = _client.GetAsync("http://localhost:54677/api/users/" + id).Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<User>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        public User Update(User user)
        {
            var jsonInString = JsonConvert.SerializeObject(user);
            var result = _client.PutAsync("http://localhost:54677/api/users/", new StringContent(jsonInString, Encoding.UTF8, "application/json")).Result;

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<User>(result.Content.ReadAsStringAsync().Result);
            }
            else
                return null;
        }

        

    }
}
