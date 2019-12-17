using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public class NewResponseParameters
    {
        public string After { get; set; }
        public string Before { get; set; }
        public int? Count { get; set; }
        public bool? IncludeCategories { get; set; }
        public int? Limit { get; set; }
        public bool? All { get; set; }
        public bool? SrDetail { get; set; }

        public override string ToString()
        {
            var endpoint = $"/new.json?" +
                           (After != null ? $"after={After}&" : string.Empty) +
                           (Before != null ? $"before={Before}&" : string.Empty) +
                           (Count != null ? $"count={Count}&" : string.Empty) +
                           (IncludeCategories != null ? $"include_categories={IncludeCategories}&" : string.Empty) +
                           (Limit != null ? $"limit={Limit}&" : string.Empty) +
                           (All != null ? $"all={All}&" : string.Empty) +
                           (SrDetail != null ? $"sr_detail={SrDetail}&" : string.Empty);

            // Remove the '&' at the end of the string.
            return endpoint.Substring(0, endpoint.Length - 1);
        }
    }
}
