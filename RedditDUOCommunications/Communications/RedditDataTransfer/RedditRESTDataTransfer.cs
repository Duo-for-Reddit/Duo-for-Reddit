using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedditCommunications
{
    public class RedditRESTDataTransfer : IRedditDataProxy
    {
        private RedditDataModel Model;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public RedditRESTDataTransfer(RedditDataModel model)
        {
            Model = model;
        }

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

        /// <summary>
        /// Sends a GET request based on the rising parameters.
        /// </summary>
        /// <param name="parameters">Parameters to customize the request.</param>
        /// <returns></returns>
        public async Task<RisingResponse> GetRisingAsync(RisingResponseParameters parameters)
        {
            Model.Endpoint = parameters.ToString();
            return await GetResponse<RisingResponse>(Model.URL);
        }

        /// <summary>
        /// Sends a GET request based on the search parameters.
        /// </summary>
        /// <param name="parameters">Parameters to customize the search.</param>
        /// <returns></returns>
        public async Task<SearchResponse> GetSearchAsync(SearchResponseParameters parameters)
        {
            Model.Endpoint = parameters.ToString();
            return await GetResponse<SearchResponse>(Model.URL);
        }

        public Task<SearchRedditNamesResponse> GetSearchRedditNamesResponse(SearchRedditNamesResponseParameters parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends a REST GET request to the server.
        /// </summary>
        /// <typeparam name="T">The data model for the GET request.</typeparam>
        /// <param name="url">The URL for the GET request.</param>
        /// <returns>ReponseInternal of type T</returns>
        private async Task<T> GetResponse<T>(string url)
        {
            using (var reponse = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (reponse.IsSuccessStatusCode)
                {
                    return await reponse.Content.ReadAsAsync<T>();
                }
                throw new HttpRequestException();
            }
        }
    }
}
