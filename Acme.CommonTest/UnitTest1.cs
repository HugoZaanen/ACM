﻿using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertSpacestestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
