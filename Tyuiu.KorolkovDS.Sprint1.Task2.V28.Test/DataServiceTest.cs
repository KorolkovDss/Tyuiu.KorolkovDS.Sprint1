using Tyuiu.KorolkovDS.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KorolkovDS.Sprint1.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 27 ;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(300, res);
        }
    }
}
