using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        /// <summary>
        /// We have know the name of changed property
        /// e.g. OnPropertyChanged("SelectedFriend");
        /// e.g. OnPropertyChanged(nameof(SelectedFriend));
        /// e.g. OnPropertyChanged() --> [CallerMemberName]string propertyName = null
        /// </summary>
        public Friend SelectedFriend
        {
            get
            {
                return _selectedFriend;
            }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();

            Friends.Clear();

            foreach(var friend in friends)
            {
                Friends.Add(friend);
            }
        }        
    }
}
