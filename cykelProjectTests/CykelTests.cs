using NUnit.Framework;
using cykelProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace cykelProject.Tests
{
    [TestFixture()]
    public class CykelTests
    {
        [TearDown]
        public void TearDown()
        {
            CykelButik.cykelDict.Clear();
        }

        [Test()]
        public void TestFuncTest()
        {
            Assert.Fail();
        }
        [Test()]
        public void NewBikeTest()
        {
            string mærkeNummer = "l4x12";
            Cykel cykel = new Cykel();
            Assert.That(CykelButik.cykelDict[mærkeNummer] != null);
        }
        [Test()]
        public void GetFarveTest()
        {
            string mærkeNummer = "l4x12";
            string farve = "grøn";
            Cykel cykel = new Cykel();//farve med mere her
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve() = farve);
        }
        [Test()]
        public void EditFarveTest()
        {
            string mærkeNummer = "l4x12";
            string farve = "testFarve";
            Cykel cykel = new Cykel();
            CykelButik.cykelDict[mærkeNummer].EditFarve(farve);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve = farve);
        }

    }
}