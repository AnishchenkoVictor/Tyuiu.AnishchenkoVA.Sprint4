using Tyuiu.AnishchenkoVA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a = { { -8, 6, -9 }, { -9, 4, -8 }, { -9, 7, -9 } };
            int res = ds.Calculate(a);
            int kk = 17;
            Assert.AreEqual(kk, res);
        }
    }
}