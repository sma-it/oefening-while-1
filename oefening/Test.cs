using NUnit.Framework;
using NUnitLite;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        [Test]
        public void TestVerdubbelGetal()
        {
            Assert.That(First.Program.VerdubbelGetal(15), Is.EqualTo(1920));
        }

        [Test]
        public void TestKwadrateerGetal()
        {
            Assert.That(First.Program.KwadrateerGetal(3, 100000), Is.EqualTo(4));
        }

        [Test]
        public void TestBepaalLeeuwen()
        {
            Assert.That(First.Program.BepaalLeeuwen(27), Is.EqualTo(26));
        }

        [Test]
        public void TestSomFibonaci()
        {
            Assert.That(First.Program.SomFibonaci(300), Is.EqualTo(986));
        }
    }
}
