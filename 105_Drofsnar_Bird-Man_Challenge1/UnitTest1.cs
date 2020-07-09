using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _105_Drofsnar_Bird_Man_Challenge1
{
    public class Drofsnar
    {
        public int Points { get; set; }
        public int Life { get; set; }

        public Drofsnar() { }

        public Drofsnar(int points, int life)
        {
            Points = points;
            Life = life;
        }

    }

    public class Birds
    {
        public int Bird { get; set; }
        public int CrestedIbis { get; set; }
        public int GreatKiskudee { get; set; }
        public int RedCrossbill { get; set; }
        public int RedNeckPhalarope { get; set; }
        public int EveningGrossbeak { get; set; }
        public int GreaterPrairieChicken { get; set; }
        public int IcelandGull { get; set; }
        public int OrangeBelliedParrot { get; set; }
        public int InvincibleBirdHunter { get; set; }
        public int VulnerableBirdHunter { get; set; }
    }


    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            Drofsnar drosfnar = new Drofsnar();

            drosfnar.Points = 5000;
            drosfnar.Life = 3;

            Console.WriteLine($"Drofsnar has {drosfnar.Points} points and {drosfnar.Life} lives.");

            Birds firstBird = new Birds();
            Birds crestedIbis = new Birds();
            Birds greatKiskudee = new Birds();
            Birds redCrossbill = new Birds();
            Birds redNeckPhalarope = new Birds();
            Birds eveningGrossBeak = new Birds();
            Birds greaterPraireChicken = new Birds();
            Birds icelandGull = new Birds();
            Birds orangeBelliedParrot = new Birds();
            Birds invincebillBirdHunter = new Birds();
            Birds vulnerableBirdHunter = new Birds();
            Birds vulnerableBirdHunter2 = new Birds();
            Birds vulnerableBirdHunter3 = new Birds();
            Birds vulnerableBirdHunter4 = new Birds();


            firstBird.Bird = 100;
            crestedIbis.CrestedIbis = 100;
            greatKiskudee.GreatKiskudee = 300;
            redCrossbill.RedCrossbill = 500;
            redNeckPhalarope.RedNeckPhalarope = 700;
            eveningGrossBeak.EveningGrossbeak = 1000;
            greaterPraireChicken.GreaterPrairieChicken = 2000;
            icelandGull.IcelandGull = 3000;
            orangeBelliedParrot.OrangeBelliedParrot = 5000;
            invincebillBirdHunter.InvincibleBirdHunter = -1;
            vulnerableBirdHunter.VulnerableBirdHunter = 200;
            vulnerableBirdHunter2.VulnerableBirdHunter = 400;
            vulnerableBirdHunter3.VulnerableBirdHunter = 800;
            vulnerableBirdHunter4.VulnerableBirdHunter = 1600;
            protected readonly List<Birds> _birdDirectory = new List<Birds>();      
    }

        public Drofsnar BirdName(Drofsnar points)
        {
            Drofsnar b = new Drofsnar(5000,3);
            Birds d = new Birds();
            switch (d) 
            {
                case d.Bird:
                case d.CrestedIbis:
                    b.Points = +100;
                    break;
                case d.GreatKiskudee:
                    b.Points = +300;
                    break;
                case d.RedCrossbill:
                    b.Points = +500;
                    break;
                case d.RedNeckPhalarope:
                    b.Points= +700;
                    break;
                case d.EveningGrossbeak:
                    b.Points = +1000;
                    break;
                case d.GreaterPrairieChicken:
                    b.Points = + 2000;
                    break;
                case d.IcelandGull:
                    b.Points = +3000;
                    break;
                case d.OrangeBelliedParrot:
                    b.Points = +5000;
                    break;
                case d.InvincibleBirdHunter:
                    b.Life = -1;
                    break;  
                case d.VulnerableBirdHunter:
                    b.Points = +200;
                    break;
                       
                                           ;
                      
                    


            }

        }

        



        public Drofsnar BirdEncounter(Birds i)
        {
            foreach(Drofsnar d == i.Bird)
            {
                d.Points = +100;
            }
        }

        public Drofsnar InvincibleBirdHunter(Birds ib)
        {
            foreach(Drofsnar d in ib.InvincibleBirdHunter)
            {
                d.Life = -1;
            }
        }

        public Drofsnar HealthGain(Drofsnar p)
        {

            if (p.Points > 10000)
            {
                p.Life = +1;
            }
            else
            {
                p.Life = +0;
            }

            return p.Life;       
        }

        public void FinalPointsAndHealth(Drofsnar p) 
        {
            Console.WriteLine($"Drofsnar final point tally is {p.Points} points and his final life tally is {p.Life} lives.");
        }
    }
}
