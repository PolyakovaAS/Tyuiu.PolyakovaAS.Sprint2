using Tyuiu.PolyakovaAS.Sprint2.Task5.V13.Lib;
namespace Tyuiu.PolyakovaAS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = "16.04";
            string result = ds.FindDateOfNextDay(2000, 4, 15);
            Assert.AreEqual(wait, result);
        }
    }
}
