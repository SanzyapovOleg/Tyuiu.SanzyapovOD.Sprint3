using Tyuiu.SanzyapovOD.Sprint3.Task3.V20.Lib;
namespace Tyuiu.SanzyapovOD.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "abcde abc abcdefg abcd ab";
            char chr = 'b';
            int res = ds.GetCharCount(str, chr);
            Assert.AreEqual(5, res);
        }
    }
}