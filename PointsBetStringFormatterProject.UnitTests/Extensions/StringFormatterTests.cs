using PointsBetStringFormatterProject.Extensions;

namespace PointsBetStringFormatterProject.UnitTests.Extensions
{
    [TestFixture]
    public class StringFormatterTests
    {
        private static IEnumerable<TestCaseData> TestCaseData()
        {
            yield return new TestCaseData(new List<string> { }, false, string.Empty);
            yield return new TestCaseData(new List<string> { }, true, string.Empty);
            yield return new TestCaseData(new List<string> { "test1" }, false, "test1");
            yield return new TestCaseData(new List<string> { "test1" }, true, "\"test1\"");
            yield return new TestCaseData(new List<string> { "test1", "test2", "test3" }, false, "test1, test2, test3");
            yield return new TestCaseData(new List<string> { "test1", "test2", "test3" }, true, "\"test1\", \"test2\", \"test3\"");
        }

        [TestCaseSource(nameof(TestCaseData))]
        public void Format_StringList_ReturnsExpected(List<string> items, bool addQuotes, string expectedResult)
        {
            // act
            var result = StringFormatter.ToCommaSeparatedList(items, addQuotes);

            // assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}