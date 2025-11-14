using Tyuiu.PolyakovaAS.Sprint2.Task0.V13.Lib;
namespace Tyuiu.PolyakovaAS.Sprint2.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1905;
            int y = 475;
            bool[] res = new bool[6]; 
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
