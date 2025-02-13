namespace PolymorphismTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            lab3.Form1.Book[] books = new lab3.Form1.Book[] {
                new lab3.Form1.Book{Title = "Generic Book", Author = "John Smith"},
                new lab3.Form1.Magazine{Title = "Tech Weekly", Author = "Jane Doe", issueNumber=12 },
                new lab3.Form1.textBook{Title = "Learn C#", Author = "Mark Jones", subject = "CPE223/L"}
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# - Subject: CPE223/L", books[2].GetInfo());
        }
    }
}
