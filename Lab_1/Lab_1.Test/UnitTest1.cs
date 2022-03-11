using NUnit.Framework;
using Lab_1;
namespace Lab_1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Ulamek liczba = new Ulamek(2, 4);
            string Tescik = liczba.ToString();
            Assert.IsTrue(Tescik == "2/4");
        }
    }
}