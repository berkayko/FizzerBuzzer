
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestFizzer
{
    [TestClass]
    public class TestFizzer
    {
        [TestMethod]
        public void TestFizz()
        {
           Fizzer  fizzer = new Fizzer();
           string result=fizzer.DefineNumber(3,false);
           Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void TestBuzz()
        {
            Fizzer fizzer = new Fizzer();
            string result = fizzer.DefineNumber(5, false);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void TestFizzbuzz()
        {
            Fizzer fizzer = new Fizzer();
            string result = fizzer.DefineNumber(15, false);
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestMethod]
        public void TestLuck()
        {
            Fizzer fizzer = new Fizzer();
            string result=fizzer.DefineNumber(3, true);
            Assert.AreEqual("Luck", result);
        }
        [TestMethod]
        public void TestNumber()
        {
            Fizzer fizzer = new Fizzer();
            string result = fizzer.DefineNumber(11, true);
            var expected = "11";
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCountFizz()
        {
            Fizzer fizzer = new Fizzer();
            Enumerable.Range(1, 100).ToList().ForEach(i=> fizzer.DefineNumber(i,true));
            var expected = 21;
            Assert.AreEqual(expected, fizzer.fizzCount);
        }
        [TestMethod]
        public void TestCountBuzz()
        {
            Fizzer fizzer = new Fizzer();
            Enumerable.Range(1, 100).ToList().ForEach(i => fizzer.DefineNumber(i, true));
            var expected = 13;
            Assert.AreEqual(expected, fizzer.buzzCount);
        }
        [TestMethod]
        public void TestCountFizzBuzz()
        {
            Fizzer fizzer = new Fizzer();
            Enumerable.Range(1, 100).ToList().ForEach(i => fizzer.DefineNumber(i, true));
            var expected = 5;
            Assert.AreEqual(expected, fizzer.fizzBuzzCount);
        }
        [TestMethod]
        public void TestCountLuck()
        {
            Fizzer fizzer = new Fizzer();
            Enumerable.Range(1, 100).ToList().ForEach(i => fizzer.DefineNumber(i, true));
            var expected = 19;
            Assert.AreEqual(expected, fizzer.luckCount);
        }
        [TestMethod]
        public void TestCountNumber()
        {
            Fizzer fizzer = new Fizzer();
            Enumerable.Range(1, 100).ToList().ForEach(i => fizzer.DefineNumber(i, true));
            var expected = 42;
            Assert.AreEqual(expected, fizzer.numberCount);
        }
    }
}
