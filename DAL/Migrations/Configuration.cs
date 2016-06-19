








using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ApplicationDbContext context)
        {
            var userId = string.Empty;
            if (context.Roles.Count() == 0)
            {

                context.Roles.Add(new Role("listenCalls"));

                context.Roles.Add(new Role("listenOwnCalls"));
                context.Roles.Add(new Role("manageUsers"));
                context.Roles.Add(new Role("manageGroups"));
                context.Roles.Add(new Role("manageServices"));
                context.Roles.Add(new Role("manageRoles"));
                //context.Roles.Add(new IdentityRole("Admin"));

                //  context.Roles.Add(new IdentityRole("User"));
                context.SaveChanges();
                var manager = new ApplicationUserManager(new UserStore<User>(context));
                var testUser = new User() { UserName = "admin" };

                manager.Create(testUser, "!College83");
                userId = testUser.Id;
                context.SaveChanges();
             //   manager.AddToRole(userId, "Admin");
            //    context.SaveChanges();

                var service = new Service()
                {
                    Name = "Tallinn",
                    Created = DateTime.Now

                };
                context.Services.Add(service);
                context.SaveChanges();
                var call = new Call()
                {

                    Anumber = "5108008",
                    Bnumber = "1182",
                    Created = DateTime.Now,
                    UserId = userId,
                    Dir = "1",
                    ServiceId = 1,
                    Duration = "23"

                };
                context.Calls.Add(call);
                context.SaveChanges();
            }
            /*
            if (context.Services.Count() == 0)
            {
                var service = new Service()
                {
                    Name = "Tallinn",
                    Created = DateTime.Now

                };
                context.Services.Add(service);

                var anotherservice = new Service()
                {
                    Name = "Tartu",
                    Created = DateTime.Now

                };
                context.Services.Add(anotherservice);

                /* Calls */
         /*       var call = new Call()
            {

                Anumber = "5108008",
                Bnumber = "1182",
                Created = DateTime.Now,
                UserId = userId,
                Dir = "1",
                ServiceId = 1

            };
            context.Calls.Add(call);
            context.SaveChanges();
            


            }*/
        }
    }
}
