using AutoFixture;
using Xunit;


namespace CustomizingAutoFixturePipeline.Tests
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
