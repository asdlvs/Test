using NUnit.Framework;

namespace StrongTest.Core.Tests
{
    public class DecisionMutationTests
    {
        [Test]
        public void TestEquals_Should_Return_True()
        {
            var decisionMutation = new DecisionMutation();
            bool result = decisionMutation.TestEquals();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNotEquals_Should_Return_True()
        {
            var decisionMutation = new DecisionMutation();
            bool result = decisionMutation.TestNotEquals();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestGreaterThen_Should_Return_True()
        {
            var decisionMutation = new DecisionMutation();
            bool result = decisionMutation.TestGreaterThen();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestLessThen_Should_Return_True()
        {
            var decisionMutation = new DecisionMutation();
            bool result = decisionMutation.TestLessThen();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestComplexCondition_Should_Return_True()
        {
            var decisionMutation = new DecisionMutation();
            bool result = decisionMutation.TestComplexCondition();
            Assert.IsTrue(result);
        }
    }
}
