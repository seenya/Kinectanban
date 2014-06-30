using Kinectanban.Models;
using Kinectanban.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kinectanban.ViewModels
{
    public class CardViewModel : ViewModelBase
    {
        // For design time support only
        public CardViewModel()
        { }

        public CardViewModel(CardModel card)
        {
            _card = card;
        }

        private CardModel _card;
        public CardModel Card 
        { 
            get
            {
                return _card;
            }
        }

    }
}
