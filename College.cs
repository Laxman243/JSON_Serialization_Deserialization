using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class JsonCollegeSerialize
    {
        public static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://jsonplaceholder.typicode.com/posts/1");
            Console.WriteLine(text);

            Posts post = JsonConvert.DeserializeObject<Posts>(text);
            Console.WriteLine( "userID :" +post.userId);
            Console.WriteLine("id :" +post.id);
            Console.WriteLine("body :" +post.body);
            Console.WriteLine("title :" + post.title);
            Console.Read();
        }
    }
    class Posts
    {    
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
