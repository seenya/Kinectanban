using Kinectanban.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kinectanban.Services.Builders
{
    public class WallViewModelBuilder
    {
        private IResourceService _resourceService;

        public WallViewModelBuilder(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public CardViewModel BuildCardViewModel(Models.CardModel card)
        {
            return new CardViewModel(card, _resourceService.GetBrushForCard(card));
        }

        public WallViewModel BuildWallViewModel(Models.WallModel wall)
        {
            WallViewModel vm = new WallViewModel() { ID = wall.ID, Name = wall.Name, Lists = BuildListViewModels(wall) };
            return vm;
        }

        private ListViewModel[] BuildListViewModels(Models.WallModel wall)
        {
            ListViewModel[] lvm = new ListViewModel[wall.Lists.Length];
            for (int i = 0; i < wall.Lists.Length; i++)
            {
                lvm[i] = BuildListViewModel(wall.Lists[i]);
            }
            return lvm;
        }

        private ListViewModel BuildListViewModel(Models.ListModel listModel)
        {
            ListViewModel lvm = new ListViewModel() { Name = listModel.Name, Icon = BuildIconImage(listModel.Name), Cards = BuildCardViewModels(listModel.Cards) };
            return lvm;
        }

        private System.Windows.Media.ImageSource BuildIconImage(string listName)
        {
            string path = System.IO.Path.GetFullPath("Images\\" + listName.ToLower() + ".png");
            if (System.IO.File.Exists(path))
                return new BitmapImage(new Uri(path));
            else
                return null;
        }

        private CardViewModel[] BuildCardViewModels(Models.CardModel[] cards)
        {
            CardViewModel[] cvm = new CardViewModel[cards.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                cvm[i] = BuildCardViewModel(cards[i]);
            }
            return cvm;
        }


    }
}
