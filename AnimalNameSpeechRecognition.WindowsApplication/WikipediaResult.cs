using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNameSpeechRecognition.WindowsApplication
{
    public class WikipediaResult
    {
        public WikiQuery query;
    }

    public class WikiQuery
    {
        public Dictionary<string, WikiPage> pages;
    }

    public class WikiPage
    {
        public string pageid;
        public string title;
        public WikiThumbnail thumbnail;
        public string pageimage;
    }

    public class WikiThumbnail
    {
        public string source;
        public int width;
        public int height;
    }
}
