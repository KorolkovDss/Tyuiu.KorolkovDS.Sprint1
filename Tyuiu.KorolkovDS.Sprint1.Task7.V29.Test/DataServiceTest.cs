using Tyuiu.KorolkovDS.Sprint1.Task7.V29.Lib;

namespace Tyuiu.KorolkovDS.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 2.072;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait ,res);
        }
    }
}
