using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from real database
            yield return new Friend { FirstName = "Daniel", LastName = "Korompai" };
            yield return new Friend { FirstName = "Ramona", LastName = "Donko" };
            yield return new Friend { FirstName = "Judit", LastName = "Szabo" };
            yield return new Friend { FirstName = "Miklos", LastName = "Korompai" };
        }

    }
}
