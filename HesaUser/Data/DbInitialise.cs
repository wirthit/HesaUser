using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HesaUser.Data
{
    public static class DbInitialise
    {
        public static void Initialise(UserDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return; // already has User rows so don't seed
            }

            var users = new User[]
            {
                new User {FirstName="Simon", Surname="Robinson", Started=DateTime.Parse("2001-09-01") },
                new User {FirstName="Alex", Surname="Wilson", Started=DateTime.Parse("2002-08-01") },
                new User {FirstName="Jenny", Surname="Jones", Started=DateTime.Parse("2003-06-01"), Left=DateTime.Parse("2004-08-01") },
                new User {FirstName="Nadia", Surname="Wilson", Started=DateTime.Parse("2004-04-01") },
                new User {FirstName="Mark", Surname="Robinson", Started=DateTime.Parse("2005-10-01") },
                new User {FirstName="Malcolm", Surname="Robinson", Started=DateTime.Parse("2006-11-01") },
                new User {FirstName="Leroy", Surname="Shirto", Started=DateTime.Parse("2007-01-01") },
                new User {FirstName="Suzanne", Surname="Platford", Started=DateTime.Parse("2008-02-01") }
            };

            foreach(var user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}
