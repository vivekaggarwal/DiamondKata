using NUnit.Framework;

namespace DiamondKata.Tests
{
    [TestFixture]
    public class DiamondMakerShould
    {
        [Test]
        public void CreateDiamondWithA()
        {
            var diamond = new Diamond('A');
            Assert.That(diamond.Crystalise(), Is.EqualTo("A"));
        }

        [Test]
        public void CreateDiamondWithB()
        {
            var expectedResult = " A\n"+
                                 "B B\n"+
                                 " A";

            var diamond = new Diamond('B');
            var result = diamond.Crystalise();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CreateDiamondWithE()
        {
            var expectedResult = "    A\n" +
                                 "   B B\n" +
                                 "  C   C\n" +
                                 " D     D\n" +
                                 "E       E\n" +
                                 " D     D\n" +
                                 "  C   C\n" +
                                 "   B B\n" +
                                 "    A";

            var diamond = new Diamond('E');
            var result = diamond.Crystalise();

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}