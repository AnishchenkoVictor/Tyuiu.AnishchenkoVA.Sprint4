using Tyuiu.AnishchenkoVA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 4;
            int cols = 3;
            string a = "678135972584";
            int res = ds.Calculate(rows, cols, a);
            int kk = 5;
            Assert.AreEqual(kk, res);
        }
    }
}