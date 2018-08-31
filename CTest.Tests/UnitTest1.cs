using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CTest.Controllers;

namespace CTest.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void Test1()
        {
            var result = controller.Get(1);
            Assert.NotNull(result);
        }

        [Fact]
        public void Test2()
        {
            var result = controller.Get();
            Assert.NotNull(result);
        }
    }
}
