using NUnit.Framework;
using FooBarQix;

namespace FoobarQix
{
    public class ProgramTests
    {

        [TestCase("1" ,"1")]
        [TestCase("2" ,"2")]
        [TestCase("3" ,"FooFoo")]
        [TestCase("4" ,"4")]
        [TestCase("5" ,"BarBar")]
        [TestCase("6" ,"Foo")]
        [TestCase("7" ,"QixQix")]
        [TestCase("8" ,"8")]
        [TestCase("9" ,"Foo")]
        [TestCase("10","Bar*")]
        [TestCase("13","Foo")]
        [TestCase("15","FooBarBar")]
        [TestCase("21","FooQix")]
        [TestCase("33","FooFooFoo")]
        [TestCase("51","FooBar")]
        [TestCase("53","BarFoo")]
        public void GetFooBarQix(string input,string ExpectedResult)
        {
            var actualvalue = Program.GetFooBarQix(input);
            Assert.AreEqual(ExpectedResult, actualvalue);
        }
    }
}