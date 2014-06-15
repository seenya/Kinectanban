using Kinectanban.Model;
using Kinectanban.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kinectanban.ViewModel
{
    public class CardViewModel : ViewModelBase
    {
        private IResourceService _resourceService;
        // For design time support only
        public CardViewModel()
        { }

        public CardViewModel(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public Brush Background 
        { 
            get 
            { 
                return _resourceService.GetBrushForCard(_card); 
            } 
        }

        private CardModel _card;
        public CardModel Card 
        { 
            get
            {
                return _card;
            }
            set
            {
                _card = value;
                RaisePropertyChanged("Card");
            }
        }

    }
}
