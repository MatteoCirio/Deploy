using Deploy;
namespace SumTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSomma()
        {
            var sum = new Sum();
            int a = 18;
            int b = 15;
            int result = sum.Somma(a, b);

            Assert.Equal(33, result);
        }
    }
}