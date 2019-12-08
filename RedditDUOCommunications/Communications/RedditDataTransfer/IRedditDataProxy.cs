using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedditCommunications
{
    public interface IRedditDataProxy
    {
        Task<RisingResponse> GetRisingAsync(RisingResponseParameters parameters);
        Task<SearchResponse> GetSearchAsync(SearchResponseParameters parameters);
        Task<NewResponse> GetNewAsync(NewResponseParameters parameters);
        Task<HotResponse> GetHotAsync(HotResponseParameters parameters);
        Task<BestResponse> GetBestAsync(BestResponseParameters parameters);
        Task<CommentsResponse> GetCommentsAsync(CommentsResponseParameters parameters);
        Task<SearchRedditNamesResponse> GetSearchRedditNamesResponse(SearchRedditNamesResponseParameters parameters);
    }
}
