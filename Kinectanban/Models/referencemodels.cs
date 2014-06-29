using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Models
{
    //public class CardModel
    //{
    //    public CardModel(Card theCard)
    //    {
    //        _rallyCard = theCard;
    //        Label = String.Format("{0} ({1})", RallyCard.cardId, Convert.ToInt32(Convert.ToDouble(RallyCard.points)));
    //        Text = RallyCard.cardTitle;
    //        SetOwner();
    //        SetColour();
    //    }

    //    private Card _rallyCard = null;
    //    public Card RallyCard
    //    {
    //        get
    //        {
    //            return _rallyCard;
    //        }
    //    }
    //    public string Label { get; set; }
    //    public string Text { get; set; }
    //    public string Owner { get; set; }
    //    public Brush Colour { get; set; }

    //    private void SetOwner()
    //    {
    //        string shortenedOwner = string.Empty;
    //        if (RallyCard.owner != null)
    //            shortenedOwner = RallyCard.owner.Split(' ')[0];
    //        Owner = shortenedOwner;
    //    }

    //    private void SetColour()
    //    {
    //        ReadBrushes();
    //        Boolean isUserStory = RallyCard.cardId.StartsWith("U") ? true : false;
    //        Brush colour = null;
    //        if (RallyCard.blocked)
    //            colour = _blockedColour;
    //        else if (RallyCard.ready)
    //            colour = _readyColour;
    //        else if (isUserStory)
    //            colour = _userStoryColour;
    //        else
    //            colour = _defectColour;

    //        Colour = colour;
    //    }

    //    private static Brush _blockedColour;
    //    private static Brush _readyColour;
    //    private static Brush _userStoryColour;
    //    private static Brush _defectColour;

    //    private void ReadBrushes()
    //    {
    //        if (_blockedColour == null)
    //        {
    //            var converter = new System.Windows.Media.BrushConverter();
    //            _blockedColour = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["kanban.item.blocked.color"]);  //red
    //            _readyColour = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["kanban.item.ready.color"]); // green
    //            _userStoryColour = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["kanban.userstory.color"]); //purple
    //            _defectColour = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["kanban.defect.color"]); //orange
    //        }
    //    }

    //}

    //public class KanbanStateModel
    //{
    //    public KanbanStateModel()
    //    {
    //        Cards = new ObservableCollection<CardModel>();
    //    }

    //    public string Name { get; set; }
    //    public string ImageUri { get; set; }
    //    public ObservableCollection<CardModel> Cards { get; set; }

    //}

    //public class MainWindowModel : INotifyPropertyChanged
    //{
    //    public MainWindowModel()
    //    {
    //        Projects = new ObservableCollection<Project>();
    //        Cards = new ObservableCollection<Card>();
    //        KanbanStates = new ObservableCollection<KanbanStateModel>();
    //    }

    //    public ObservableCollection<Project> Projects { get; set; }
    //    private Dictionary<string, KanbanStateModel> _kanbanStatesDictionary = new Dictionary<string, KanbanStateModel>();
    //    public ObservableCollection<KanbanStateModel> KanbanStates { get; set; }
    //    public ObservableCollection<Card> Cards { get; set; }

    //    private string _currentProjectName;
    //    public string CurrentProjectName
    //    {
    //        get
    //        {
    //            return _currentProjectName;
    //        }
    //        set
    //        {
    //            if (value != _currentProjectName)
    //            {
    //                _currentProjectName = value;
    //                NotifyPropertyChanged("CurrentProjectName");
    //                NotifyVisibilitiesChanged();
    //            }

    //        }
    //    }

    //    private string _globalText;
    //    public string GlobalText
    //    {
    //        get
    //        {
    //            return _globalText;
    //        }
    //        set
    //        {
    //            if (value != _globalText)
    //            {
    //                _globalText = value;
    //                NotifyPropertyChanged("GlobalText");
    //            }

    //        }
    //    }

    //    private Card _selectedCard;
    //    public Card SelectedCard
    //    {
    //        get
    //        {
    //            return _selectedCard;
    //        }
    //        set
    //        {
    //            if (value != _selectedCard)
    //            {
    //                _selectedCard = value;
    //                NotifyPropertyChanged("SelectedCard");
    //                NotifyVisibilitiesChanged();
    //            }

    //        }
    //    }

    //    private Iteration _currentIteration;
    //    public Iteration CurrentIteration
    //    {
    //        get
    //        {
    //            return _currentIteration;
    //        }
    //        set
    //        {
    //            if (value != _currentIteration)
    //            {
    //                _currentIteration = value;
    //                NotifyPropertyChanged("CurrentIteration");
    //                NotifyPropertyChanged("Theme");
    //            }

    //        }
    //    }

    //    public Visibility ProjectViewVisibility
    //    {
    //        get
    //        {
    //            if (CurrentProjectName == null)
    //                return Visibility.Visible;
    //            else
    //                return Visibility.Collapsed;
    //        }
    //    }

    //    public Visibility CardsViewVisibility
    //    {
    //        get
    //        {
    //            if (CurrentProjectName != null && SelectedCard == null)
    //                return Visibility.Visible;
    //            else
    //                return Visibility.Collapsed;

    //        }
    //    }

    //    public Visibility CardDetailVisibility
    //    {
    //        get
    //        {
    //            if (SelectedCard != null)
    //                return Visibility.Visible;
    //            else
    //                return Visibility.Collapsed;
    //        }
    //    }

    //    public string Theme
    //    {
    //        get
    //        {
    //            if (_currentIteration != null && _currentIteration.theme != null)
    //                return _currentIteration.theme;
    //            return string.Empty;
    //        }
    //    }

    //    private void NotifyVisibilitiesChanged()
    //    {
    //        NotifyPropertyChanged("CardDetailVisibility");
    //        NotifyPropertyChanged("CardsViewVisibility");
    //        NotifyPropertyChanged("ProjectViewVisibility");
    //    }


    //    private void NotifyPropertyChanged(String propertyName)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void SetCards(IList<Card> newCards)
    //    {
    //        foreach (KanbanStateModel kanbanState in KanbanStates)
    //        {
    //            kanbanState.Cards.Clear();
    //        }

    //        foreach (Card card in newCards)
    //        {
    //            if (_kanbanStatesDictionary.ContainsKey(card.kanbanState))
    //            {
    //                _kanbanStatesDictionary[card.kanbanState].Cards.Add(new CardModel(card));
    //            }
    //        }
    //    }

    //    public void SetProjects(IList<Project> newProjects)
    //    {
    //        Projects.Clear();
    //        foreach (Project project in newProjects)
    //            Projects.Add(project);
    //    }

    //    public void SetKanbanStates(IList<KanbanStateModel> newKanbanStates)
    //    {
    //        // One is ordered for UI display, the other is a cached dictionary so we don't need to keep building it.
    //        KanbanStates.Clear();
    //        foreach (KanbanStateModel kanbanState in newKanbanStates)
    //        {
    //            KanbanStates.Add(kanbanState);
    //            _kanbanStatesDictionary.Add(kanbanState.Name, kanbanState);
    //        }
    //    }

    //    public void MoveCardToKanbanState(CardModel cardToMove, KanbanStateModel targetKanbanState)
    //    {
    //        if (cardToMove.RallyCard.kanbanState != targetKanbanState.Name)
    //        {
    //            var oldKanbanState = GetModelForKanbanStateName(cardToMove.RallyCard.kanbanState);
    //            cardToMove.RallyCard.kanbanState = targetKanbanState.Name;
    //            oldKanbanState.Cards.Remove(cardToMove);
    //            targetKanbanState.Cards.Add(cardToMove);
    //        }
    //    }

    //    private KanbanStateModel GetModelForKanbanStateName(string stateName)
    //    {
    //        return (from KanbanStateModel k in KanbanStates where k.Name == stateName select k).First();
    //    }
    //}

}
