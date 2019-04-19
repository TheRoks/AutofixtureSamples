using System;
using AutoFixture;
using Xunit;

namespace CustomizingFixtureInstances.Tests
{
    public class CustomizingEntireFixtures
    {
        [Fact]
        public void Error()
        {
            var fixture = new Fixture();

            fixture.Inject("LHR");

            var flight = fixture.Create<FlightDetails>();

            string s = fixture.Create<string>();
        }

        [Fact]
        public void SettingValueForCustomType()
        {
            var fixture = new Fixture();


            fixture.Inject(new FlightDetails
            {
                DepartureAirportCode = "PER",
                ArrivalAirportCode = "LHR",
                FlightDuration = TimeSpan.FromHours(10),
                AirlineName = "Awesome Aero"
            });


            var flight1 = fixture.Create<FlightDetails>();
            var flight2 = fixture.Create<FlightDetails>();
        } 

    }
}
