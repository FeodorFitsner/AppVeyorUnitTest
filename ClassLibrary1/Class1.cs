﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ClassLibrary1
{
    public class Class1
    {
        [Fact]
        public void GivenAFunkyString_EscapeDataString_EncodesTheData()
        {
            var v = typeof(Uri).Assembly.ToString();
            
            // Arrange.
            const string data = "abcde *.(.).";

            // Act.
            var result = Uri.EscapeDataString("abcde *.(.).");

            // Assert.
            Assert.Equal("abcde%20%2A.%28.%29.", result);
            //result.ShouldBe("abcde%20%2A.%28.%29.");
        }
    }
}
