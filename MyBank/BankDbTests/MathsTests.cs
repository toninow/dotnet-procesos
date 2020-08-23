using NUnit.Framework;
//using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace BankDbTests
{
    public class MathsTests
    {
        //[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        [TestMethod()]
        public void AddIntegers_FromDataSourceTest()
        {
            var target = new Maths();

            // Access the data
            int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
            int y = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
            int expected = Convert.ToInt32(TestContext.DataRow["Sum"]);
            int actual = target.IntegerMethod(x, y);
            Assert.AreEqual(expected, actual,
                "x:<{0}> y:<{1}>",
                new object[] {x, y});
        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
    }
}