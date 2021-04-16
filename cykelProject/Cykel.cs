using System;

namespace cykelProject
{
    public class Cykel
    {
        
        string mærkeNummer;
        string farve;
        int pris;
        Mærke mærke;
        public void TestFunc()
        {
            Console.WriteLine(":)");
        }

        public Cykel(string mærkeNummer, string farve, int pris, Mærke mærke)
        {
            this.mærkeNummer = mærkeNummer;
            this.farve = farve;
            this.pris = pris;
            this.mærke = mærke;

            CykelButik.cykelDict.Add(mærkeNummer, this);
        }
        public string GetFarve()
        {
            return farve;
        }
        public void EditFarve(string farve)
        {
            this.farve = farve;
        }
        public int GetPris()
        {
            return pris;
        }
        public void EditPris(int pris) 
        {
            this.pris = pris;
        }
        public Mærke GetMærke()
        {
            return mærke;
        }
        public void EditMærke(Mærke mærke)
        {
            this.mærke = mærke;
        }

        public enum Mærke
        {
            Cool,
            AndetNavn,
            wow
        }
    }
}
