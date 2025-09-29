using Tyuiu.KorolkovDS.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KorolkovDS.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string str = "строка";
            
            bool wait = true;
            var res = ds.CheckLowerCaseRusLetters(str);
            Assert.AreEqual(wait,res);
        }
    }
}
