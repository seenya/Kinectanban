using Kinectanban.WebAPI.Models.Trello;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kinectanban.WebAPI.Services
{
    public class TrelloRepositoryService : ITrelloRepositoryService
    {
        private IRestClient _client;
        private IConfigurationService _configurationService;

        public TrelloRepositoryService(IRestClient client, IConfigurationService configurationService)
        {
            _client = client;
            _client.BaseUrl = "https://api.trello.com";
            _configurationService = configurationService;
        }


        public List<TrelloBoardSummary> GetBoards()
        {
            var request = new RestRequest(GetRequestURL("/1/members/seenya/boards"), Method.GET);
            var wallList = _client.Execute<List<TrelloBoardSummary>>(request);

            return wallList.Data;
        }

        public TrelloBoard GetBoard(string id)
        {
            throw new NotImplementedException();
        }

        private string GetRequestURL(string baseUrl)
        {
            string appKey = _configurationService.GetValueForKey("trello.appKey");
            string userToken = _configurationService.GetValueForKey("trello.userToken");
            return string.Format("{0}?key={1}&token={2}", baseUrl, appKey, userToken);
        }
    }
}