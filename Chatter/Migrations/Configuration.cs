namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;
    using System.Collections.Generic;
    using Models;
    using static Models.ApplicationDbContext;

    internal sealed class Configuration : DbMigrationsConfiguration<Chatter.Models.ChatterContext>
    {


        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Chatter.Models.ChatterContext";
        }

        protected override void Seed(Chatter.Models.ChatterContext context)
        {
            using (var db = new MyEntities())
            {
                var user1 = new User();
                var user2 = new User();
                var user3 = new User();
                user1.Followers = new User[] { user2 };
                user2.Followers = new User[] { user3 };
                db.Users.Add(user1);
                db.SaveChanges();
            }
        }
    }
}
