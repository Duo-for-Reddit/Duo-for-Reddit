using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedditCommunications
{
    public class RedditFileDataTransfer : IRedditDataProxy
    {
        public Task<BestResponse> GetBestAsync(BestResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<CommentsResponse> GetCommentsAsync(CommentsResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<HotResponse> GetHotAsync(HotResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<NewResponse> GetNewAsync(NewResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<RisingResponse> GetRisingAsync(RisingResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<SearchResponse> GetSearchAsync(SearchResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<SearchRedditNamesResponse> GetSearchRedditNamesResponse(SearchRedditNamesResponseParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
