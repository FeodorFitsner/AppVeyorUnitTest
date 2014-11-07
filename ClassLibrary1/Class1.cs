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
            // Arrange.
            const string data = "abcde *.(.).";

            // Act.
            var result = Uri.EscapeDataString(data);

            // Assert.
            result.ShouldBe("abcde%20%2A.%28.%29.");
        }
    }
}
