namespace ValidationTesting
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidBookCreation()
        {
            var magazine = new lab3.Form1.Magazine
            {
                Title = "Invalid",
                Author = "Jane Doe",
                issueNumber = -1
            };
        }
    }
}
