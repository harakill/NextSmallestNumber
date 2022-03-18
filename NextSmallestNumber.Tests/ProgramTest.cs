using NUnit.Framework;

namespace NextSmallestNumber.Tests
{
    public class ProgramTest
    {
        private SmallestNumber _smallestNumber;

        [SetUp]
        public void Setup()
        {
            _smallestNumber = new SmallestNumber();
        }

        [Test]
        [TestCase(new[] { 3, 4, 6, 9, 10, 12, 14, 15, 17, 19, 21 }, 12, 12)]
        [TestCase(new[] { 3, 4, 6, 9, 10, 12, 14, 15, 17, 19, 21 }, 13, 12)]
        [TestCase(new[] { 3, 4, 6, 9, 10, 12, 14, 15, 17, 19, 21 }, 2, -1)]
        public void GetNextSmallestNumber_WhenCalled_ReturnTheNextSmallestNumber(int[] positiveSortedArray, int smallestInt, int expectedResult)
        {
            var result = _smallestNumber.GetNextSmallestNumber(positiveSortedArray, smallestInt);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}