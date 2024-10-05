using NUnit.Framework;

namespace LeetCodeExercisesTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Humano humano = new Humano();
            Assert.That(humano.ObtenerEdad(), Is.EqualTo(0));
        }
    }
}
