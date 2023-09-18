using FluentAssertions;
using Xunit;

namespace CarWorkshop.Domain.Entities
{
    public class CarWorkshopTests
    {
        [Fact()]
        public void EncodeName_ShouldSetEncodedName()
        {
            var carWorkshop = new CarWorkshop();
            carWorkshop.Name = "Test Workshop";

            // act
            carWorkshop.EncodeName();

            // assert
            carWorkshop.EncodedName.Should().Be("test-workshop");
            
        }

        [Fact]

        public void EncodeName_ShouldThrowException_WhenNameIsNull()
        {
            // arrange

            var carWorkshop = new CarWorkshop();

            // act
            Action action = () => carWorkshop.EncodeName();

            // arrange

            action.Invoking(a => a.Invoke())
                .Should().Throw<NullReferenceException>();
        }
    }
}