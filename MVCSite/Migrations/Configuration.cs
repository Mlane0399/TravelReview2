namespace MVCSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCSite.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCSite.Models.MVCSiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCSite.Models.MVCSiteContext context) /*These are the categories using seed data*/
        {
            context.Categories.AddOrUpdate(x => x.ID,
                new Category() { ID = 1, Location = "Southeast Asia", PriceRange = "30+", SizeAccomo = "Small" },
                new Category() { ID = 2, Location = "United Kingdom", PriceRange = "500+", SizeAccomo = "Small" },
                new Category() { ID = 3, Location = "France", PriceRange = "200+", SizeAccomo = "Average" },
                new Category() { ID = 4, Location = "Iceland", PriceRange = "150+", SizeAccomo = "Large" },
                new Category() { ID = 5, Location = "Caribbean", PriceRange = "75+", SizeAccomo = "Average" }
                );
        
            context.Reviews.AddOrUpdate(x => x.ID, /*These are the reviews using seed data*/
                new Review() { ID = 1, Title = "Definitely have to check out the islands", Content = "First time to Southeast Asia (Thailand and Cambodia specifically). Food was amazing and cheap. People are super friendly. Definitely head down to the Gulf of Thailand for the Full Moon Party!", CategoryID = 1, PublishedDate = DateTime.Parse("2017/05/11") , ReturnAgain = true
                },
                new Review() { ID = 2, Title = "Wish it wasn't so expensive...", Content = "England is know for being pretty highbrow and upperclass, and boy do their prices reflect that. Stayed in London, but spent way to much money on clothes and drinks. Sunday roasts are pretty tasty in the pub.", CategoryID = 2, PublishedDate = DateTime.Parse("2015/11/09") , ReturnAgain = false
                },
                new Review() { ID = 3, Title = "More wine and cheese, please! And be sure to ask for the Queen Suite", Content = "Best vacation ever! So many things to do, The Louvre, Notre Dame, The Bastille, and of course the cafes! People watching on the streets of Paris was totally worth the flight alone!", CategoryID = 3, PublishedDate = DateTime.Parse("2016/06/19") , ReturnAgain = true
                },
                new Review() { ID = 4, Title = "Some of the friendliest people I've ever met, super safe country", Content = "Two words: Blue Lagoon. If you haven't been to Iceland, you better put it on your list. Food took some getting used to, but the scenery was absolutely breathtaking.", CategoryID = 4, PublishedDate = DateTime.Parse("2005/08/10") , ReturnAgain = true
                },
                new Review() { ID = 5, Title = "Definitely have to check out the islands", Content = "Went to Jamaica for the first time, and I should have gone to another island. The people were friendly, but they kept offering me illegal goods, and I could smell them using those goods everywhere.", CategoryID = 5, PublishedDate = DateTime.Parse("1995/04/14"), ReturnAgain = false
                }

                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
