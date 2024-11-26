using Tyuiu.AnishchenkoVA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var a = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int res = ds.Calculate(a);
            int x = 4;
            Assert.AreEqual(x, res);
        }
    }
}