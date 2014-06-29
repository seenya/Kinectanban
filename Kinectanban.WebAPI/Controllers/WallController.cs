using Kinectanban.WebAPI.Models;
using Kinectanban.WebAPI.Models.Trello;
using Kinectanban.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kinectanban.WebAPI.Controllers
{
    public class WallController : ApiController
    {
        private ITrelloRepositoryService _wallService;

        public WallController(ITrelloRepositoryService wallService)
        {
            _wallService = wallService;
        }

        public IList<WallSummary> Get()
        {
            var trelloBoards = _wallService.GetBoards();

            List<WallSummary> walls = new List<WallSummary>();
            foreach(TrelloBoardSummary board in trelloBoards)
            {
                WallSummary summary = new WallSummary() { ID = board.id, Name = board.name };
                walls.Add(summary);
            }

            return walls;
        }

        public Wall Get(string id)
        {

            var theLists = new List<CardList>();
            var list1 = new CardList() { Name = "In Dev" };
            var list2 = new CardList() { Name = "In QA" };
            theLists.Add(list1);
            theLists.Add(list2);
            var theCards = new List<Card>();
            theCards.Add(new Card() { Id = "US086", Title = "Title1", Detail = "Description that is long 1.", AssignedTo = "Agent 86"});
            theCards.Add(new Card() { Id = "US099", Title = "Title2", Detail = "Description that is long 2.", AssignedTo = "Agent 99"});
            list1.Cards = theCards.ToArray();
            return new Wall() { ID = id, Lists = theLists.ToArray() };
        }
    }
}
