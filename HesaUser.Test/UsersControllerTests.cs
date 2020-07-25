using NUnit.Framework;
using HesaUser.Controllers;
using HesaUser.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Options;
using System;
using System.Security.Cryptography.X509Certificates;

namespace HesaUser.Test
{
    public class UsersControllerTests
    {
        private DbContextOptions<UserDbContext> options;
        private bool latch = false;

        [SetUp]
        public void Setup()
        {
            if (!latch)
            {
                DbContextOptionsBuilder<UserDbContext> optionsBuilder = new DbContextOptionsBuilder<UserDbContext>(); // https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext

                optionsBuilder.UseInMemoryDatabase("sardb");

                options = optionsBuilder.Options;

                SeedInMem();

                latch = true;
            }
        }

        [Test]
        public void TestCountWeHaveSevenSeededUsers()
        {
            using (var context = new UserDbContext(options))
            {
                var controller = new UsersController(context);

                var result = controller.GetUsers("").GetAwaiter().GetResult();

                Assert.IsTrue(result.Value.ToList<User>().Count == 7);
            }
        }

        [Test]
        public void TestCountWeHaveTwoSeededUsersWithSurnameRobinson()
        {
            using (var context = new UserDbContext(options))
            {
                var controller = new UsersController(context);

                var result = controller.GetUsers("Robinson").GetAwaiter().GetResult();

                Assert.IsTrue(result.Value.ToList<User>().Count == 2);
            }
        }

        [Test]
        public void TestCountWeHaveOneSeededUsersWithSurnameJones()
        {
            using (var context = new UserDbContext(options))
            {
                var controller = new UsersController(context);

                var result = controller.GetUsers("Jones").GetAwaiter().GetResult();

                Assert.IsTrue(result.Value.ToList<User>().Count == 1);
            }
        }

        [Test]
        public void TestCountWeHaveNoSeededUsersWithSurnameClough()
        {
            using (var context = new UserDbContext(options))
            {
                var controller = new UsersController(context);

                var result = controller.GetUsers("Clough").GetAwaiter().GetResult();

                Assert.IsTrue(result.Value.ToList<User>().Count == 0);
            }
        }

        private void SeedInMem()
        {
            using(var context = new UserDbContext(options))
            {
                var users = new List<User>
                {
                    new User{FirstName="Simon", Surname="Robinson", Started=DateTime.Parse("2001-09-01"), Left=DateTime.Parse("2002-10-01")},
                    new User{FirstName="Jacob", Surname="Robinson", Started=DateTime.Parse("2001-10-01"), Left=DateTime.Parse("2002-10-01")},
                    new User{FirstName="Alex", Surname="Wilson", Started=DateTime.Parse("2008-06-01"), Left=DateTime.Parse("2012-10-01")},
                    new User{FirstName="Nadia", Surname="Wilson", Started=DateTime.Parse("2007-05-01"), Left=DateTime.Parse("2012-10-01")},
                    new User{FirstName="Reuben", Surname="Wilson", Started=DateTime.Parse("2009-04-01"), Left=DateTime.Parse("2012-10-01")},
                    new User{FirstName="Jenny", Surname="Jones", Started=DateTime.Parse("2016-02-01"), Left=DateTime.Parse("2020-10-01")},
                    new User{FirstName="Leroy", Surname="Shirto", Started=DateTime.Parse("2004-08-01"), Left=DateTime.Parse("2012-09-01")}
                };

                context.AddRange(users);
                context.SaveChanges();
            }
        }

    }
}