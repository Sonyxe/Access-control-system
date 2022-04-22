using Access_control_system.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        public class UnitTestGenerateRandomPersonList
        {
            [Fact]
            public void GenerateRandomPersonListMoreThenOneItemInList()
            {
                Person person = new Person();
                _ = person.GeneratePersonList();

                Assert.True(person.Id > 0);

            }
        }
    }
}
