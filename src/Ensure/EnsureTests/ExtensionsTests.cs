using EnsureCore;
using EnsureCore.Extensions;

namespace EnsureTests
{
    public class ExtensionsTests
    {
        [Fact]
        public void NotNull_InputIsNotNull_NoExceptionThrown()
        {
            // Arrange
            var input = new object();

            // Act
            Ensure.Is.NotNull(input, "", "test message");

            // Assert
        }

        [Fact]
        public void NotNull_InputIsNull_ThrowsAnException()
        {
            // Arrange
            object input = null;

            // Act

            var action = () => Ensure.Is.NotNull(input, "", "test message");

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }
    }
}