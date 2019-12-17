using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public class BestResponseParameters
    {
        public string After { get; set; }
        public string Before { get; set; }
        public int? Count { get; set; }
        public bool? IncludeCategories { get; set; }
        public int? Limit { get; set; }
        public bool? Show { get; set; }
        public bool? SrDetail { get; set; }

        public override string ToString()
        {
            var endpoint = $"/best.json?" +
                           (After != null ? $"after={After}&" : string.Empty) +
                           (Before != null ? $"before={Before}&" : string.Empty) +
                           (Count != null ? $"count={Count}&" : string.Empty) +
                           (IncludeCategories != null ? $"include_categories={IncludeCategories}&" : string.Empty) +
                           (Limit != null ? $"limit={Limit}&" : string.Empty) +
                           (Show != null ? $"show={Show}&" : string.Empty) +
                           (SrDetail != null ? $"sr_detail={SrDetail}&" : string.Empty);

            return endpoint.Substring(0, endpoint.Length);
        }
    }
}
