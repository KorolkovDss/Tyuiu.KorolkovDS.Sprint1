using Tyuiu.KorolkovDS.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KorolkovDS.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = 0.005;
            var res = (ds.Calculate(x, y));
            Assert.AreEqual(wait, res);
            
        }
    }
}
