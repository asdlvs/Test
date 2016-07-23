using NUnit.Framework;

namespace StrongTest.Core.Tests
{
    public class ValueMutationTests
    {
        [Test]
        public void TestSumm_Should_Return_Correct_Summ()
        {
            var valueMutation = new ValueMutation();
            int result = valueMutation.Sum(6, 12);
            Assert.AreEqual(result, 18);
        }

        public void AddToConstValue_Should_Correctly_Add_To_Const_Value()
        {
            var valueMutation = new ValueMutation();
            int result = valueMutation.AddToConstValue(6);
            Assert.AreEqual(result, 11);
        }
    }
}
