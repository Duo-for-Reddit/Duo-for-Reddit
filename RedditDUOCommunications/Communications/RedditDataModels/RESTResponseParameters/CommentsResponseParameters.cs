using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public class CommentsResponseParameters
    {
        /// <summary>
        /// Create an instance of the CommentsResponseParameters class.
        /// </summary>
        /// <param name="article">Article ID36 required.</param>
        public CommentsResponseParameters(string article)
        {
            Article = article;
        }

        public string Article { get; set; }
        public string Comment { get; set; }
        public int? Context { get; set; }
        public int? Depth { get; set; }
        public int? Limit { get; set; }
        public bool? Showedits { get; set; }
        public bool? Showmore { get; set; }
        public string Sort { get; set; }
        public bool? SrDetail { get; set; }
        public bool? Threaded { get; set; }
        public int? Truncate { get; set; }

        public override string ToString()
        {
            var endpoint = $"/comments/{Article}/test.json" +
                           (Comment != null ? $"comment={Comment}&" : string.Empty) +
                           (Context != null ? $"context={Context}&" : string.Empty) +
                           (Depth != null ? $"depth={Depth}&" : string.Empty) +
                           (Limit != null ? $"limit={Limit}&" : string.Empty) +
                           (Showedits != null ? $"showedits={Showedits}&" : string.Empty) +
                           (Showmore != null ? $"showmore={Showmore}&" : string.Empty) +
                           (Sort != null ? $"sort={Sort}&" : string.Empty) +
                           (SrDetail != null ? $"sr_detail={SrDetail}&" : string.Empty) +
                           (Threaded != null ? $"threaded={Threaded}&" : string.Empty) +
                           (Truncate != null ? $"truncate={Truncate}&" : string.Empty);

            // Remove the '&' at the end of the string.
            return endpoint = endpoint.Substring(0, endpoint.Length - 1);
        }
    }
}
