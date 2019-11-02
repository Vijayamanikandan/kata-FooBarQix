using NUnit.Framework;
using FooBarQix;

namespace FoobarQix
{
    public class Tests
    {

        [Test]
        [TestCase(3,"Foo")]
        [TestCase(5,"Bar")]
        [TestCase(7, "Qix")]
        [TestCase(15,"FooBar")]
        [TestCase(105, "FooBarQix")]
        [TestCase(11,"")]
        public void IsDivisibleByisTrue(int input,string ExpectedResult)
        {
            var actualvalue = Helper.IsDivisble(input);
            Assert.AreEqual(ExpectedResult, actualvalue);
        }


        [Test]
        [TestCase(3, "Foo")]
        [TestCase(5, "Bar")]
        [TestCase(7, "Qix")]
        [TestCase(35, "FooBar")]
        [TestCase(57, "BarQix")]
        [TestCase(357, "FooBarQix")]
        [TestCase(11, "")]
        public void ContainsDigitsTests(int input, string ExpectedResult)
        {
            var actualvalue = Helper.ContainsDigits(input);
            Assert.AreEqual(ExpectedResult, actualvalue);
        }
    }
}