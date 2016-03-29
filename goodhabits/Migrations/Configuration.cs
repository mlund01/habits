using goodhabits.Models;

namespace goodhabits.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<goodhabits.Models.goodhabitsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(goodhabits.Models.goodhabitsContext context)
        {
	        context.Users.AddOrUpdate(new User[]
	        {
		        new User
		        {
			        Email = "lundmax@gmail.com",
			        FirstName = "Max",
			        LastName = "Lund",
			        Password = "testpass",
			        UserId = 1
		        },
		        new User
		        {
			        Email = "connoroby@gmail.com",
			        FirstName = "Connor",
			        LastName = "O'Brien",
			        Password = "testpass2",
			        UserId = 2
		        }

	        });
			context.Sessions.AddOrUpdate(new Session[]
			{
				new Session
				{
					Description = "This is Connor's First Session",
					EndDate = new DateTime(2016, 4, 1, 12, 0, 0),
					StartDate = new DateTime(2016, 4, 29, 12, 0, 0),
					Name = "First Session",
					SessionId = 1,
					UserId = 2
				},
				new Session
				{
					Description = "This is Connor's Second Session",
					EndDate = new DateTime(2016, 5, 1, 12, 0, 0),
					StartDate = new DateTime(2016, 5, 29, 12, 0, 0),
					Name = "Second Session",
					SessionId = 2,
					UserId = 2
				},
				new Session
				{
					Description = "This is Max's First Session",
					EndDate = new DateTime(2016, 4, 1, 12, 0, 0),
					StartDate = new DateTime(2016, 4, 29, 12, 0, 0),
					Name = "First Session - Max",
					SessionId = 3,
					UserId = 1
				}
			});
			context.Goals.AddOrUpdate(new Goal[]
			{
				new Goal
				{
					Description = "Drink less than 2 beers",
					GoalId = 1,
					Question = "Did you drink less than 2 beers today?",
					SessionId = 3
				},
				new Goal
				{
					Description = "Sleep more than 7 hours",
					GoalId = 2,
					Question = "Did you sleep more than 7 hours last night?",
					SessionId = 3
				},
                new Goal
				{
					Description = "Workout",
					GoalId = 3,
					Question = "Did you workout today?",
					SessionId = 3
				},
				new Goal
				{
					Description = "Sleep more than 8 hours",
					GoalId = 4,
					Question = "Did you sleep more than 7 hours last night?",
					SessionId = 1
				},
				new Goal
				{
					Description = "Practice the guitar",
					GoalId = 5,
					Question = "Did you practice the guitar today?",
					SessionId = 1
				},
				new Goal
				{
					Description = "Work on a Pluralsight course",
					GoalId = 6,
					Question = "Did you work on a pluralsight course today?",
					SessionId = 1
				},
				new Goal
				{
					Description = "Sleep more than 10 hours",
					GoalId = 7,
					Question = "Did you sleep more than 10 hours last night?",
					SessionId = 2
				},
				new Goal
				{
					Description = "Dance for an hour",
					GoalId = 8,
					Question = "Did you dance for an hour today?",
					SessionId = 2
				},
				new Goal
				{
					Description = "Learn something about a new programming language",
					GoalId = 9,
					Question = "Did learn something about a new programming language today?",
					SessionId = 2
				}


			});

	        context.UserResponses.AddOrUpdate(new UserResponse[]
	        {
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 1,
					UserResponseId = 1
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					GoalId = 1,
					UserResponseId = 2
				},
				new UserResponse
				{
					Answer = false,
					Date = new DateTime(2016, 4, 3),
					Note = "This was a bad day",
					GoalId = 1,
					UserResponseId = 3
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 2,
					UserResponseId = 4
				},
				new UserResponse
				{
					Answer = false,
					Date = new DateTime(2016, 4, 2),
					Note = "Pretty bad day!",
					GoalId = 2,
					UserResponseId = 5
				},
				new UserResponse
				{
					Answer = false,
					Date = new DateTime(2016, 4, 3),
					Note = "Why can't I do anything right?",
					GoalId = 2,
					UserResponseId = 6
				},
				new UserResponse
				{
					Answer = false,
					Date = new DateTime(2016, 4, 1),
					GoalId = 3,
					UserResponseId = 7
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					Note = "Killing it!",
					GoalId = 3,
					UserResponseId = 8
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 3),
					GoalId = 3,
					UserResponseId = 9
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 4,
					UserResponseId = 10
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					GoalId = 4,
					UserResponseId = 11
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 3),
					GoalId = 4,
					UserResponseId = 12
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 5,
					UserResponseId = 13
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					GoalId = 5,
					UserResponseId = 14
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 3),
					GoalId = 5,
					UserResponseId = 15
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 6,
					UserResponseId = 16
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					GoalId = 6,
					UserResponseId = 17
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 3),
					GoalId = 6,
					UserResponseId = 18
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 1),
					GoalId = 7,
					UserResponseId = 19
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 2),
					GoalId = 7,
					UserResponseId = 20
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 4, 3),
					GoalId = 7,
					UserResponseId = 21
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 1),
					GoalId = 8,
					UserResponseId = 22
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 2),
					GoalId = 8,
					UserResponseId = 23
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 3),
					GoalId = 8,
					UserResponseId = 24
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 1),
					GoalId = 9,
					UserResponseId = 25
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 2),
					GoalId = 9,
					UserResponseId = 26
				},
				new UserResponse
				{
					Answer = true,
					Date = new DateTime(2016, 5, 3),
					GoalId = 9,
					UserResponseId = 27
				}
			});
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
