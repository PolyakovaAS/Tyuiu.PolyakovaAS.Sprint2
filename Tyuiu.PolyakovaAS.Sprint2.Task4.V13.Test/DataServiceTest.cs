using Tyuiu.PolyakovaAS.Sprint2.Task4.V13.Lib;
namespace Tyuiu.PolyakovaAS.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var z = ds.Calculate(5, 2);
            Assert.AreEqual(24.8, z);
        }
    }
}
