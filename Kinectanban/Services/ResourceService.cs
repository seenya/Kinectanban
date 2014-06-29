using Kinectanban.Models;
using Kinectanban.Services.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Kinectanban.Services
{
    public class ResourceService : IResourceService
    {
        private Brush _defaultBrush;
        private Brush _defectBrush;

        public ResourceService(IResourceSupplier resourceSupplier)
        {
            _defaultBrush = (Brush)resourceSupplier.FindResource(Constants.DEFAULT_CARD_BRUSH);
            _defectBrush = (Brush)resourceSupplier.FindResource(Constants.DEFECT_CARD_BRUSH);
        }

        public Brush GetBrushForCard(CardModel card)
        {
            string type = string.Empty;
            if (card != null)
                type = card.Type;

            if ((!String.IsNullOrEmpty(type) && type.ToLower() == Constants.CARD_TYPE_DEFECT_LOWERCASE))
            {
                return _defectBrush;
            }

            return _defaultBrush;
        }
    }
}
