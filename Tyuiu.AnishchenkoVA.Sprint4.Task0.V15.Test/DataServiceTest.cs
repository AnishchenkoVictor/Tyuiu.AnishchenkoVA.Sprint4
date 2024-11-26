using Tyuiu.AnishchenkoVA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] s = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetMultOddArrEl(s);
            int kk = 138915;

            Assert.AreEqual(kk, res);
        }
    }
}