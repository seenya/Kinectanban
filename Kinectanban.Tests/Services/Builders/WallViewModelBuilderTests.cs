using Kinectanban.Models;
using Kinectanban.Services;
using Kinectanban.Services.Builders;
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
            var cards1 = new List<CardModel>();
            cards1.Add(CreateStoryCard());
            cards1.Add(CreateStoryCard());
            list1.Cards = cards1;
            ListModel list2 = new ListModel() { Name = "list2" };
            var cards2 = new List<CardModel>();
            cards2.Add(CreateStoryCard());
            cards2.Add(CreateStoryCard());
            list2.Cards = cards2;
            List<ListModel> theLists = new List<ListModel>();
            theLists.Add(list1);
            theLists.Add(list2);            
            WallModel wall = new WallModel() { ID="ID1", Name="SpecialWall", Lists=theLists };

            var builder = CreateBuilder();

            WallViewModel vm = builder.BuildWallViewModel(wall);

            Assert.IsNotNull(vm);
            Assert.AreEqual("ID1", vm.ID);
            Assert.AreEqual("SpecialWall", vm.Name);
            Assert.AreEqual(2, vm.Lists.Length);
            Assert.AreEqual(2, vm.Lists[0].Cards.Length);
            Assert.AreEqual(3, vm.Lists[1].Cards.Length);
        }

        private static CardModel CreateStoryCard()
        {
            CardModel card = new CardModel() { Id = "US001", Title = "The story", IsBlocked = false, IsReady = false, IsDefect=false };
            return card;
        }

        private WallViewModelBuilder CreateBuilder()
        {
            return new WallViewModelBuilder();
        }
    }
}