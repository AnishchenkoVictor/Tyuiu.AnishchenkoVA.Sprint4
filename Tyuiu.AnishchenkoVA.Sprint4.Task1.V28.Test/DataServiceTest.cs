using Tyuiu.AnishchenkoVA.Sprint4.Task1.V28.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] s = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(s);
            int wait = 375;
            Assert.AreEqual(wait, res);
        }
    }
}