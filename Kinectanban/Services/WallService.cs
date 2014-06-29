using Kinectanban.Models;
using Kinectanban.Services.Builders;
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
        private WallViewModelBuilder _builder;

        public WallService(IRestClient client, WallViewModelBuilder builder)
        {
            _client = client;
            _builder = builder;
        }

        public WallListViewModel GetWallList()
        {
            var request = new RestRequest("wall", Method.GET);
            var wallList = _client.Execute<List<WallSummary>>(request);

            return new WallListViewModel() { Walls = wallList.Data };
        }

        public WallViewModel GetWall(string wallId)
        {
            var request = new RestRequest(string.Format("wall/{0}", wallId), Method.GET);
            var wall = _client.Execute<WallModel>(request);

            return _builder.BuildWallViewModel(wall.Data);
        }

        public CardViewModel GetCard(string id)
        {
            throw new NotImplementedException();
        }
    }
}
