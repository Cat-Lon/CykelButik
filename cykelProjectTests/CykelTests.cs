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
        CykelButik cykelButik = new CykelButik();
        string mærkeNummer;
        string farve;
        int pris;
        Cykel.Mærke mærke;

        [TearDown]
        public void TearDown()
        {
            CykelButik.cykelDict.Clear();
        }
        [SetUp]
        public void SetUp()
        {
            mærkeNummer = "l4x12";
            farve = "grøn";
            pris = 200;
            mærke = Cykel.Mærke.wow;
        }
        [Test()]
        public void NewBikeTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer], Is.EqualTo(cykel));
        }
        [Test()]
        public void GetFarveTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve(), Is.EqualTo(farve));
        }
        [Test()]
        public void EditFarveTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            string newFarve = "TestFarve";
            CykelButik.cykelDict[mærkeNummer].EditFarve(newFarve);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve, Is.EqualTo(newFarve));
        }
        [Test()]
        public void GetPrisTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetPris(), Is.EqualTo(pris));
        }
        [Test()]
        public void EditPrisTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            int newPris = 172;
            CykelButik.cykelDict[mærkeNummer].EditPris(newPris);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetPris(), Is.EqualTo(newPris));
        }
        [Test()]
        public void GetMærkeTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetMærke(), Is.EqualTo(mærke));
        }
        [Test()]
        public void EditMærkeTest()
        { 
            Cykel.Mærke newMærke = Cykel.Mærke.AndetNavn;
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            CykelButik.cykelDict[mærkeNummer].EditMærke(newMærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetMærke(), Is.EqualTo(newMærke));
        }
        [Test()]
        public void RemoveBikeTest()
        {
            Cykel cykel = new Cykel(mærkeNummer, farve, pris, mærke);
            cykelButik.RemoveBike(mærkeNummer);
            Assert.Throws<KeyNotFoundException>(() => CykelButik.cykelDict[mærkeNummer].GetPris()) ;
        }
    }
}