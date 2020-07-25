using NUnit.Framework;
using HesaUser.Controllers;
using HesaUser.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Options;

namespace HesaUser.Test
{
    public class UsersControllerTests
    {
        private UsersController controller;

        [SetUp]
        public void Setup()
        {
            DbContextOptionsBuilder<UserDbContext> optionsBuilder = new DbContextOptionsBuilder<UserDbContext>(); // https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext

            optionsBuilder.UseSqlServer("Server=.;Database=HesaUser;Trusted_Connection=True;");

            UserDbContext dbContext = new UserDbContext(optionsBuilder.Options);

            controller = new UsersController(dbContext);
        }

        [Test]
        public void TestCountWeHaveEightSeededUsers()
        {
            var result = controller.GetUsers().GetAwaiter().GetResult();

            Assert.IsTrue(result.Value.ToList<User>().Count == 8);
        }

        [Test]
        public void TestCountWeHaveThreeSeededUsersWithSurnameRobinson()
        {
            var result = controller.GetUsers("Robinson").GetAwaiter().GetResult();

            Assert.IsTrue(result.Value.ToList<User>().Count == 3);
        }

        [Test]
        public void TestCountWeHaveOneSeededUsersWithSurnameJones()
        {
            var result = controller.GetUsers("Jones").GetAwaiter().GetResult();

            Assert.IsTrue(result.Value.ToList<User>().Count == 1);
        }

        [Test]
        public void TestCountWeHaveNoSeededUsersWithSurnameClough()
        {
            var result = controller.GetUsers("Clough").GetAwaiter().GetResult();

            Assert.IsTrue(result.Value.ToList<User>().Count == 0);
        }

    }
}