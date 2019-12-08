using System;
using System.Threading.Tasks;

namespace RedditCommunications
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiHelper.InitializeApiClient();

            var dataModel = new RedditDataModel();
            IRedditDataProxy dataProxy = new RedditRESTDataTransfer(dataModel);



            bool keepSearching = true;

            while (keepSearching)
            {
                Console.Write("Enter subreddit you want to search (ie. rocketleague): ");
                dataModel.SubReddit = "r/" + Console.ReadLine();

                Console.Write("\nEnter topic you want to search about: ");
                var query = Console.ReadLine();

                Console.Write("\nEnter number of threads to retrieve: ");
                var limit = Int32.Parse(Console.ReadLine());

                Console.Write("\nSort by one of (new, hot, top, relevance, comments): ");
                var sort = Console.ReadLine();

                var parameters = new SearchResponseParameters
                {
                    Query = query,
                    Limit = limit,
                    RestrictSr = OnOffOptions.On,
                    Sort = sort
                };

                GetSearchAsync(dataProxy, dataModel, parameters).Wait();

                Console.WriteLine("\nThis was your subreddit endpoint: " + parameters);

                Console.WriteLine("\nWant to search again? (yes / no)");
                keepSearching = Console.ReadLine() == "yes" ? true : false;
            }
        }

        static async Task GetRisingAsync(IRedditDataProxy dataProxy,
                                         RedditDataModel dataModel,
                                         RisingResponseParameters parameters)
        {
            var reponse = await dataProxy.GetRisingAsync(parameters);

            foreach (var child in reponse.data.children)
            {
                var output = String.Format($"|{child.data.ups,-6:N0}|") + "  " + child.data.title;
                Console.WriteLine(output);
            }
        }

        static async Task GetSearchAsync(IRedditDataProxy dataProxy,
                                         RedditDataModel dataModel,
                                         SearchResponseParameters parameters)
        {
            var response = await dataProxy.GetSearchAsync(parameters);

            foreach (var child in response.data.children)
            {
                var output = String.Format($"|{child.data.ups,-6:N0}|") + "  " + child.data.title;
                Console.WriteLine(output);
            }
        }
    }
}
