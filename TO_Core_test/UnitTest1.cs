using TO_Basic_App_Github;

namespace TO_Core_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            //Arrange

            Class1 tp = new Class1();

            //Act
            var result = tp.Name;

            //Assert
            Assert.Equal("[Tamara Orusa] - The Code Master", result);
        }
    }
}