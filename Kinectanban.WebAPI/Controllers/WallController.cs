using Kinectanban.WebAPI.Models;
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

        public IEnumerable<string> Get()
        {
            return new string[] { "Wall1", "Wall2" };
        }

        public Wall Get(string id)
        {

            var theLists = new List<string>();
            theLists.Add("List1");
            theLists.Add("List2");
            var theCards = new List<Card>();
            theCards.Add(new Card() { id = "US086", Title = "Title1", Description = "Description that is long 1.", AssignedTo = "Agent 86", AssignedList="List1" });
            theCards.Add(new Card() { id = "US099", Title = "Title2", Description = "Description that is long 2.", AssignedTo = "Agent 99" , AssignedList="List2"});
            return new Wall() { Id = id, Lists = theLists, Cards = theCards };
        }
    }
}
