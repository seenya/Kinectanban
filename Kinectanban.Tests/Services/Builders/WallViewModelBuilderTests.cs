using Kinectanban.Models;
using Kinectanban.Services;
using Kinectanban.Services.Builders;
using Kinectanban.Services.Wrappers;
using Kinectanban.ViewModels;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Media;

namespace Kinectanban.Tests.Services.Builders
{
    [TestFixture()]
    public class WallViewModelBuilderTests
    {
        [Test()]
        public void BuildViewModel_2Lists2CardsInOne3CardsInTheOther_BuiltWith2Lists2Cards()
        {
            ListModel list1 = new ListModel() { Name="list1" };
            list1.Cards = new CardModel[] {CreateStoryCard(), CreateStoryCard()};
            ListModel list2 = new ListModel() { Name = "list2" };
            list2.Cards = new CardModel[] { CreateStoryCard(), CreateStoryCard(), CreateStoryCard() };
            List<ListModel> theLists = new List<ListModel>();
            theLists.Add(list1);
            theLists.Add(list2);            
            WallModel wall = new WallModel() { ID="ID1", Name="SpecialWall", Lists=theLists.ToArray() };

            var builder = CreateBuilder();

            WallViewModel vm = builder.BuildWallViewModel(wall);

            Assert.IsNotNull(vm);
            Assert.AreEqual("ID1", vm.ID);
            Assert.AreEqual("SpecialWall", vm.Name);
            Assert.AreEqual(2, vm.Lists.Length);
            Assert.AreEqual(2, vm.Lists[0].Cards.Length);
            Assert.AreEqual(3, vm.Lists[1].Cards.Length);
        }

        [Test()]
        public void BuildCardViewModel_TypeIsStory_BackgroundIsSet()
        {
            CardModel card = CreateStoryCard();

            WallViewModelBuilder builder = CreateBuilder();

            CardViewModel vm = builder.BuildCardViewModel(card);

            Assert.IsNotNull(vm.Background);
            Assert.AreSame(card, vm.Card);
        }

        private static CardModel CreateStoryCard()
        {
            CardModel card = new CardModel() { Id = "US001", Title = "The story", IsBlocked = false, IsReady = false, Type = "Story" };
            return card;
        }

        private WallViewModelBuilder CreateBuilder()
        {
            var mockResourceService = new Mock<IResourceService>();
            mockResourceService.Setup(r => r.GetBrushForCard(It.IsAny<CardModel>())).Returns(new SolidColorBrush());
            return new WallViewModelBuilder(mockResourceService.Object);
        }
    }
}