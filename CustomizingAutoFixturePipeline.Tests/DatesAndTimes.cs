using System;
using AutoFixture;
using Xunit;

namespace CustomizingAutoFixturePipeline.Tests
{
    public class DatesAndTimes
    {
        [Fact]
        public void DateTimes()
        {
            // arrange
            var fixture = new Fixture();
            DateTime logTime = fixture.Create<DateTime>();

            // act
            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            // assert
            Assert.Equal(result.Year, logTime.Year);
        }


        [Fact]
        public void TimeSpans()
        {
            var fixture = new Fixture();

            TimeSpan span = fixture.Create<TimeSpan>();
        }

    }
}
