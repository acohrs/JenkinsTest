using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace JenkinsTest.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        [TestMethod()]
        public void getWelcomeTextTest()
        {
            Assert.AreEqual("Welcom", "Welcome");
        }
    }
}