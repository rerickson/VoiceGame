using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNameSpeechRecognition.WindowsApplication
{
    public class Wikipedia
    {
        readonly string formatURI = "https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=pageimages&format=json&pithumbsize=400";

        public string getURLForTitle(string title)
        {
            try {
                string finalUri = string.Format(formatURI, title);
                HttpClient client = new HttpClient();

                HttpResponseMessage httpResponse = new HttpResponseMessage();
                string responseBody = "";

                httpResponse = client.GetAsync(finalUri).Result;
                responseBody = httpResponse.Content.ReadAsStringAsync().Result;

                WikipediaResult result = JsonConvert.DeserializeObject<WikipediaResult>(responseBody);

                return result.query.pages.First().Value.thumbnail.source;
            } catch (Exception)
            {
                return "";
            }
        }
    }
}
