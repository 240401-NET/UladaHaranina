namespace P0.Tests

{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Vlada", "")]
        [InlineData("", "Name can't be blank!")]
        [InlineData("5467", "")]
        public void ValidateNameTest(string name, string expected)
        {
            Assert.Equal(expected, Validator.validateName(name));
        }
    }
}
