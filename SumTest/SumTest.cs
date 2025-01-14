using Deploy;
namespace SumTest
{
    public class SumTest
    {
        [Fact]
        public void TestSomma1()
        {
            var sum = new Sum();
            int a = 18;
            int b = 15;
            int result = sum.Somma(a, b);

            Assert.Equal(33, result);
        }

        [Fact]
        public void TestSomma2()
        {
            var sum = new Sum();
            int a = 10;
            int b = 15;
            int result = sum.Somma(a, b);

            Assert.Equal(35, result);
        }

        [Fact]
        public void TestSomma3()
        {
            var sum = new Sum();
            int a = 20;
            int b = 20;
            int result = sum.Somma(a, b);

            Assert.Equal(40, result);
        }
    }
}