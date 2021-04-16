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
        public void NewBikeTest()
        {
            string mærkeNummer = ":)";
            Cykel cykel = new Cykel(mærkeNummer,"",0,Cykel.Mærke.wow);
            Assert.That(CykelButik.cykelDict[mærkeNummer], Is.EqualTo(cykel));
        }
        [Test()]
        public void GetFarveTest()
        {
            string mærkeNummer = "l4x12";
            string farve = "grøn";
            Cykel cykel = new Cykel(mærkeNummer, farve, 200, Cykel.Mærke.Cool);//farve med mere her
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve(), Is.EqualTo(farve));
        }
        [Test()]
        public void EditFarveTest()
        {
            string mærkeNummer = "l4x12";
            string farve = "testFarve";
            Cykel cykel = new Cykel(mærkeNummer,"blå",160,Cykel.Mærke.AndetNavn);
            CykelButik.cykelDict[mærkeNummer].EditFarve(farve);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetFarve, Is.EqualTo(farve));
        }
        [Test()]
        public void GetPrisTest()
        {
            string mærkeNummer = "l4x12";
            int pris = 169;
            Cykel cykel = new Cykel(mærkeNummer,"",pris,Cykel.Mærke.Cool);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetPris(), Is.EqualTo(pris));
        }
        [Test()]
        public void EditPrisTest()
        {
            string mærkeNummer = "l4x12";
            int pris = 172;
            Cykel cykel = new Cykel(mærkeNummer,"",201,Cykel.Mærke.AndetNavn);//anden pris her
            CykelButik.cykelDict[mærkeNummer].EditPris(pris);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetPris(), Is.EqualTo(pris));
        }
        [Test()]
        public void GetMærkeTest()
        {
            string mærkeNummer = "l4x12";
            Cykel.Mærke mærke = Cykel.Mærke.Cool;
            Cykel cykel = new Cykel(mærkeNummer,"",0,mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetMærke(), Is.EqualTo(mærke));
        }
        [Test()]
        public void EditMærkeTest()
        {
            string mærkeNummer = "l4x12";
            Cykel.Mærke mærke = Cykel.Mærke.AndetNavn;
            Cykel cykel = new Cykel(mærkeNummer,"",0,Cykel.Mærke.Cool);//andet mærke her
            CykelButik.cykelDict[mærkeNummer].EditMærke(mærke);
            Assert.That(CykelButik.cykelDict[mærkeNummer].GetMærke(), Is.EqualTo(mærke));
        }
    }
}