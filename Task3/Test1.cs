using System;

namespace Task3
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookNullTest()
        {
            var book = new lab3.Form1.Book
            {
                Title = "",
                Author = "John Doe"
            };
            book.validate();
        }

        public void MagazineNullTest()
        {
            var mag = new lab3.Form1.Magazine
            {
                Title = "",
                issueNumber = -3
            };
            mag.validate();
        }

        public void TextBookNullValidate()
        {
            var textBook = new lab3.Form1.textBook
            {
                Title = "",
                subject = ""
            };
            textBook.validate();
        }
    }
}
