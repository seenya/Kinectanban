using Kinectanban.Models;
using Kinectanban.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Services
{
    public class WallService : IWallService
    {
        private IRestClient _client;

        public WallService(IRestClient client)
        {
            _client = client;
        }

        public WallListViewModel GetWallList()
        {
            var request = new RestRequest("wall", Method.GET);
            var wallList = _client.Execute<List<WallSummary>>(request);

            return new WallListViewModel() { Walls = wallList.Data };
        }

        public WallViewModel GetWall(string wallId)
        {
            throw new NotImplementedException();
        }

        public CardViewModel GetCard(string id)
        {
            throw new NotImplementedException();
        }
    }
}
