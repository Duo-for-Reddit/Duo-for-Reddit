using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public class SearchResponseParameters
    {
        public string After { get; set; }
        public string Before { get; set; }
        public string Category { get; set; }
        public bool? IncludeFacets { get; set; }
        public int? Limit { get; set; }
        public string Query { get; set; }
        public string RestrictSr { get; set; }
        public bool? Show { get; set; }
        public string Sort { get; set; }
        public bool? SrDetail { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            var endpoint = $"/search.json?" +
                           (After != null ? $"after={After}&" : string.Empty) +
                           (Before != null ? $"before={Before}&" : string.Empty) +
                           (Category != null ? $"category={Category}&" : string.Empty) +
                           (IncludeFacets != null ? $"include_facets={IncludeFacets}&" : string.Empty) +
                           (Limit != null ? $"limit={Limit}&" : string.Empty) +
                           (Query != null ? $"q={Query}&" : string.Empty) +
                           (RestrictSr != null ? $"restrict_sr={RestrictSr}&" : string.Empty) +
                           (Show != null ? $"show={Show}&" : string.Empty) +
                           (Sort != null ? $"sort={Sort}&" : string.Empty) +
                           (SrDetail != null ? $"sr_detail={SrDetail}&" : string.Empty) +
                           (Time != null ? $"time_options={Time}&" : string.Empty) +
                           (Type != null ? $"type={Type}&" : string.Empty);

            // Remove the '&' at the end of the string.
            return endpoint.Substring(0, endpoint.Length - 1);
        }
    }

    public static class SortOptions
    {
        public static readonly string Relevance = "relevance";
        public static readonly string Hot = "hot";
        public static readonly string Top = "top";
        public static readonly string New = "new";
        public static readonly string Comments = "comments";
    }

    public static class TimeOptions
    {
        public static readonly string Hour = "hour";
        public static readonly string Day = "day";
        public static readonly string Week = "week";
        public static readonly string Month = "month";
        public static readonly string Year = "year";
        public static readonly string All = "all";
    }

    public static class OnOffOptions
    {
        public static readonly string On = "on";
        public static readonly string Off = "off";
    }
}
