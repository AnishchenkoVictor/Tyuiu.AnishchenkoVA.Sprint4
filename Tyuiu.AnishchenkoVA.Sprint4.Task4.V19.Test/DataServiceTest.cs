using Tyuiu.AnishchenkoVA.Sprint4.Task4.V19.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] a = { { 8, 6, 9, 4, 5 }, { 9, 4, 8, 5, 6 }, { 9, 7, 9, 8, 4 }, { 4, 6, 5, 7, 8 }, { 6, 6, 7, 6, 4 } };
            int res = ds.Calculate(a);
            int kk = 72;
            Assert.AreEqual(kk, res);
        }
    }
}