using AutoFixture;
using Xunit;


namespace CustomizingFixtureInstances.Tests
{
    public class DataAnnotatedObjects
    {
        [Fact]
        public void BasicString()
        {
            // arrange

            var fixture = new Fixture();

            var player = fixture.Create<PlayerCharacter>();


            // act and assert phases...

        }
    }
}
