

namespace UnitTesting1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestBookCreation()
        {
            var book = new lab3.Form1.Book
            {
                Title = "Unit Testing Book",
                Author = "Tim Robin M. Remeticado"
            };
            Assert.AreEqual("Unit Testing Book", book.Title);
            Assert.AreEqual("Tim Robin M. Remeticado", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            var magazine = new lab3.Form1.Magazine
            {
                Title = "Unit Testing Magazine",
                Author = "Tim Robin M. Remeticado",
                issueNumber = 546908
            };
            Assert.AreEqual("Unit Testing Magazine", magazine.Title);
            Assert.AreEqual("Tim Robin M. Remeticado", magazine.Author);
            Assert.AreEqual(546908, magazine.issueNumber);
        }
    }
}
