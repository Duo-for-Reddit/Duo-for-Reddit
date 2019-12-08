using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RedditCommunications
{
    public class RedditDataModel
    {
        public readonly string RedditURL = "https://www.reddit.com/";
        public string SubReddit { get; set; } = "r/Pitt";
        public string Endpoint { get; set; }
        public string URL { get { return RedditURL + SubReddit + Endpoint; } }
    }
}
