using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinectanban.Services;
using Kinectanban.Services.Wrappers;
using Kinectanban.Model;

namespace Kinectanban.Tests.Services
{
    [TestFixture()]
    public class ResourceServiceTests
    {


        [Test()]
        public void GetBrushForCard_CardIsNull_DefaultBrushReturned()
        {
            string expectedResourceKey = Constants.DEFAULT_CARD_BRUSH;
            var mockResourceSupplier = new Mock<IResourceSupplier>();
            mockResourceSupplier.Setup(a => a.FindResource(It.Is<String>(s => s == expectedResourceKey)));
            var resourceService = new ResourceService(mockResourceSupplier.Object);

            resourceService.GetBrushForCard(null);

            mockResourceSupplier.VerifyAll();
        }

        [Test()]
        public void GetBrushForCard_CardTypeIsDefectUpperCase_DefectBrushReturned()
        {
            string expectedResourceKey = Constants.DEFECT_CARD_BRUSH;
            var mockResourceSupplier = new Mock<IResourceSupplier>();
            mockResourceSupplier.Setup(a => a.FindResource(It.Is<String>(s => s == expectedResourceKey)));
            var resourceService = new ResourceService(mockResourceSupplier.Object);

            CardModel card = new CardModel() { Type = Constants.CARD_TYPE_DEFECT_LOWERCASE.ToUpper() };

            resourceService.GetBrushForCard(card);

            mockResourceSupplier.VerifyAll();
        }

        [Test()]
        public void GetBrushForCard_CardTypeIsDefectLowerCase_DefectBrushReturned()
        {
            string expectedResourceKey = Constants.DEFECT_CARD_BRUSH;
            var mockResourceSupplier = new Mock<IResourceSupplier>();
            mockResourceSupplier.Setup(a => a.FindResource(It.Is<String>(s => s == expectedResourceKey)));
            var resourceService = new ResourceService(mockResourceSupplier.Object);

            CardModel card = new CardModel() { Type = Constants.CARD_TYPE_DEFECT_LOWERCASE };

            resourceService.GetBrushForCard(card);

            mockResourceSupplier.VerifyAll();
        }

        [Test()]
        public void GetBrushForCard_CardTypeIsUserStory_DefaultBrushReturned()
        {
            string expectedResourceKey = Constants.DEFAULT_CARD_BRUSH;
            var mockResourceSupplier = new Mock<IResourceSupplier>();
            mockResourceSupplier.Setup(a => a.FindResource(It.Is<String>(s => s == expectedResourceKey)));
            var resourceService = new ResourceService(mockResourceSupplier.Object);

            CardModel card = new CardModel() { Type = "UserStory" };

            resourceService.GetBrushForCard(card);

            mockResourceSupplier.VerifyAll();
        }

        [Test()]
        public void GetBrushForCard_CardTypeIsBlah_DefaultBrushReturned()
        {
            string expectedResourceKey = Constants.DEFAULT_CARD_BRUSH;
            var mockResourceSupplier = new Mock<IResourceSupplier>();
            mockResourceSupplier.Setup(a => a.FindResource(It.Is<String>(s => s == expectedResourceKey)));
            var resourceService = new ResourceService(mockResourceSupplier.Object);

            CardModel card = new CardModel() { Type = "Blah" };

            resourceService.GetBrushForCard(card);

            mockResourceSupplier.VerifyAll();

        }

    }
}
