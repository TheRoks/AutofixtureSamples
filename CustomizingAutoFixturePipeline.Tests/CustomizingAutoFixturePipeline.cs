using System.Collections.Generic;
using AutoFixture;
using Xunit;

namespace CustomizingAutoFixturePipeline.Tests
{
    public class CustomizingAutoFixturePipeline
    {
        [Fact]
        public void Error()
        {
            var fixture = new Fixture();

            var flight = fixture.Create<FlightDetails>();
        }


        [Fact]
        public void CustomizedPipeline()
        {
            var fixture = new Fixture();

            fixture.Customizations.Add(new AirportCodeSpecimenBuilder());

            var flight = fixture.Create<FlightDetails>();

            var airport = fixture.Create<Airport>();
        }


    }
}
