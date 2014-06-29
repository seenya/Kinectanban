using Kinectanban.WebAPI.Models.Trello;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.WebAPI.Services
{
    public interface ITrelloRepositoryService
    {
        IList<TrelloBoardSummary> GetBoards();
        TrelloBoard GetBoard(string id);
    }
}
