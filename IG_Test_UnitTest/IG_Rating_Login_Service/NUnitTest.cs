using IG_Test.DataAccess.Context;
using IG_Test.DataAccess.Repository;
using IG_Test.Helpers.Shared.MD5;
using IG_Test_Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace IG_Test_UnitTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RatingTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<IGContext>();
            optionsBuilder.UseInMemoryDatabase("IELTS_GiaSu");
            var dbContext = new IGContext(optionsBuilder.Options);
            var dateTime = DateTime.UtcNow;
            var ratingObj = new IG_Rating_Login_Service
            {
                feedback = "Hệ thống tốt",
                loginToken = MD5Generator.CreateMD5(dateTime.ToString()),
                timestamp = dateTime,
                serviceCode = "IG_VeSinh",
                ratingPoint = 5
            };
            dbContext.IG_Rating_Login_Service.Add(ratingObj);
            var result = dbContext.SaveChanges();
            if(result > 0)
            {
                Assert.Pass();
            }else
            {
                Assert.Fail();
            }
        }
    }
}