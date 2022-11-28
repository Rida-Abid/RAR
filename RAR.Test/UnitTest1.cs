using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rar;
using FluentAssertions;

namespace RAR.Test
{
    [TestClass]
    public class UnitTest1
    {


        #region SortedList
        [TestMethod]
        public void TestWithOneWordParameterinSortedList()
        {
        
            var uut = new Logic();
            var testList = new List<string>();
            testList.Add("sat");
            var result = uut.SortedList(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("sat", result.First());
            
        }

        [TestMethod]
        public void TestWithNoParametersinSortedList()
        {
            
            var uut = new Logic();
            var testList = new List<string>();
            var result = uut.SortedList(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
            
        }

        [TestMethod]
        public void TestWith5ParameterinSortedList()
        {

            var uut = new Logic();
            var testList = new List<string>();
            testList.Add("sat");
            testList.Add("bat");
            testList.Add("rat");
            testList.Add("fat");
            testList.Add("mat");
            var result = uut.SortedList(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual("bat", result.First());
            Assert.AreEqual("fat", result[1]);
            Assert.AreEqual("mat", result[2]);
            Assert.AreEqual("rat", result[3]);
            Assert.AreEqual("sat", result[4]);
            


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

        [TestMethod]
        public void TestWith5ParameterinReverse()
        {

            var uut = new Logic();
            var testList = new List<string>();
            testList.Add("sat");
            testList.Add("bat");
            testList.Add("rat");
            testList.Add("fat");
            testList.Add("mat");
            var result = uut.Reverse(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual("mat", result.First());
            Assert.AreEqual("fat", result[1]);
            Assert.AreEqual("rat", result[2]);
            Assert.AreEqual("bat", result[3]);
            Assert.AreEqual("sat", result[4]);



        }
        #endregion

        #region Randomise
        [TestMethod]
        public void TestWithNoParametersinRandomise()
        {

            var uut = new Logic();
            var testList = new List<string>();
            var result = uut.Randomise(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());

        }

        [TestMethod]
        public void TestWithOneWordParameterinRandomise()
        {
            
            var uut = new Logic();
            var testList = new List<string>();
            testList.Add("sat");
            var result = uut.Randomise(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("sat", result.First());
            
        }


        [TestMethod]
        public void TestWith5ParameterinRandomise()
        {

            var uut = new Logic();
            var testList = new List<string>();
            testList.Add("sat");
            testList.Add("bat");
            testList.Add("rat");
            testList.Add("fat");
            testList.Add("mat");
            var result = uut.Randomise(testList);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
          



        }
        #endregion


    }
}