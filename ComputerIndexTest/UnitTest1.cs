using prjIndexesICE;

namespace ComputerIndexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestID()
        {
            Computer comp = new Computer(3000, "Samsung", "Black", "OLED");
            Assert.AreEqual(comp[0], "Samsung");
        }

        [TestMethod]
        public void TestUpdateName()
        {
            Computer comp = new Computer(3000, "Samsung", "Black", "OLED");
            comp[2] = "Black";
            Assert.AreEqual(comp[2], "Black");
        }
    }
}