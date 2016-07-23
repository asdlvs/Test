using NUnit.Framework;

namespace StrongTest.Core.Tests
{
    public class StatementMutationTests
    {
        [Test]
        public void TestStatement1_Should_Return_120()
        {
            var statementMutation = new StatementMutation();
            int result = statementMutation.TestStatement1();

            Assert.AreEqual(result, 120);
        }
    }
}
