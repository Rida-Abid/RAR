using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rar;

namespace RAR.Test
{
    [TestClass]
    public class UnitTest1
    {


        #region SortedList
        [TestMethod]
        public void TestWithOneWordParameterinSortedList()
        {
            {
                var uut = new Logic();
                var testList = new List<string>();
                testList.Add("sat");
                var result = uut.SortedList(testList);
                Assert.IsNotNull(result);
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("sat", result.First());
            }
        }

        [TestMethod]
        public void TestWithNoParametersinSortedList()
        {
            {
                var uut = new Logic();
                var testList = new List<string>();
                var result = uut.SortedList(testList);
                Assert.IsNotNull(result);
                Assert.AreEqual(0, result.Count());
            }
        }

        #endregion

        #region Reverse
        [TestMethod]
        public void TestWithOneWordParameterinReverse()
        {
            {
                var uut = new Logic();
                var testList = new List<string>();
                testList.Add("sat");
                var result = uut.Reverse(testList);
                Assert.IsNotNull(result);
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("sat", result.First());
                //Assert.AreEqual("sun", result [1]);
            }
        }


        [TestMethod]
        public void TestWithNoParametersinReverse()
        {

            var uut = new Logic();
            var testList = new List<string>();
            var result = uut.Reverse(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());

        }
        #endregion

        #region Get2RandomWords
        [TestMethod]
        public void TestWithNoParametersinGet2RandomWords()
        {

            var uut = new Logic();
            var testList = new List<string>();
            var result = uut.Get2RandomWords(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());

        }
        #endregion


    }  
}