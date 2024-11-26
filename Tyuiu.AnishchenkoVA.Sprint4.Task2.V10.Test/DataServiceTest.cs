using Tyuiu.AnishchenkoVA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] s = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(s);
            int wait = 375;
            Assert.AreEqual(wait, res);
        }
    }
}