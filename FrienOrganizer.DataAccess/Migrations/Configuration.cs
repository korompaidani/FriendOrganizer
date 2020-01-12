namespace FrienOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FrienOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FrienOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Daniel", LastName = "Korompai" },
                new Friend { FirstName = "Ramona", LastName = "Donko" },
                new Friend { FirstName = "Judit", LastName = "Szabo" },
                new Friend { FirstName = "Miklos", LastName = "Korompai" }
                );
        }
    }
}
