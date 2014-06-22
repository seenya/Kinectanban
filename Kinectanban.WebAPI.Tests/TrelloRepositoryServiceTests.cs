using Kinectanban.WebAPI.Services;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.WebAPI.Tests
{
    [TestFixture()]
    public class TrelloRepositoryServiceTests
    {
        [Test()]
        public void GetBoards_HappyPath_BoardsReturned()
        {
            TrelloRepositoryService service = new TrelloRepositoryService(new RestClient(), new ConfigurationService(new EnvironmentVariableService()));

            var boards = service.GetBoards();

            Assert.Greater(boards.Count, 1);
        }
    }
}
