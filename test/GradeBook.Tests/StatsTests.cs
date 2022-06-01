using System;
using Xunit;

namespace GradeBook.Tests
{
    public class StatsTests
    {
        [Fact]
        public void Book_stats_test()
        {
            //Arrage
            var newbook = new Book("Test1");
            newbook.Addgrade(2.3);
            newbook.Addgrade(3.4);

            //Act
            var stats = newbook.get_statistics();

            //Assert
            Assert.Equal(5.7/2, stats.average,6);
            Assert.Equal(3.4, stats.max,6);
            Assert.Equal(2.3, stats.min,6);

        }
    }
}
