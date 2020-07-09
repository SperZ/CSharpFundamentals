
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_Drofsnar_Bird_Classes
{
    class DrofsnarRepository
    {
        protected readonly List<Birdies> _birdiesDirectory = new List<Birdies>();
        protected readonly List<Birds> _birdDirectory = new List<Birds>();
        protected readonly DrofsnarRepository _repo = new DrofsnarRepository();
        protected readonly Drofsnar d = new Drofsnar(5000, 3);
        //"Computer Stupid" : if you did not tell the computer to do something it will not do it.Just because you create a class does not mean it will be used.Just because you create a method does not mean it will be used. You have to instantiate/ new up instances of a class in order to use it.You must call methods after instantiating the class where that method lives in order for that method to actually run in your application.

        public List<string> Birdd = File.ReadAllText(@"C:\Code Projects\ElevenFiftyProjects\GoldBadge\Assets\game-sequence(1).txt").Split(',').ToList<string>();

        public string BridieName()
        {
            while (d.Life > 0)
            {
                foreach (string b in Birdd)
                {
                    if (b == "Birds")
                    {
                        d.Points = +10;
                    }

                    else if (b == "CrestedIbis")
                    {
                        d.Points = +100;
                    }

                    else if (b == "GreatKiskudee")
                    {
                        d.Points = +300;
                    }

                    else if (b == "RedCrossedBill")
                    {
                        d.Points = +500;
                    }
                    else if (b == "RedNeckPhalarope")
                    {
                        d.Points = +700;
                    }

                    else if (b == "EveningGrossbeak")
                    {
                        d.Points = +1000;
                    }
                    else if (b == "GreaterPrairieChicken")
                    {
                        d.Points = 2000;
                    }
                    else if (b == "IcelandGull")
                    {
                        d.Points = +3000;
                    }
                    else if (b == "OrangeBelliedParrot")
                    {
                        d.Points = +5000;
                    }

                    else if (b == "VulnerableBirdHunter")
                    {
                        int i = 0;
                        i++;

                        if (i == 1)
                        {
                            d.Points = +200;
                        }

                        if (i == 2)
                        {
                            d.Points = +400;
                        }

                        else if (i == 3)
                        {
                            d.Points = +800;
                        }

                        else if (i == 4)
                        {
                            d.Points = +1600;
                        }
                    }
                    else if (b == "InvincibleBirdHunter")
                    {
                        d.Life = -1;
                    }
                }
                if (d.Points > 10000)
                {
                    d.Life = +1;
                }
            }

            return $"Drofsnar has {d.Points} points and {d.Life}";
        }













        public int Bird_Birds(Birds i)
        {
            foreach (Birds s in _birdDirectory)
            {
                if (s.Bird == i.Bird)
                {
                    d.Points = +100;
                }
            }

            return d.Points;
        }

        public int Birds_CrestedIbis(Birds cI)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.CrestedIbis == cI.CrestedIbis)
                {
                    d.Points = +100;
                }
            }

            return d.Points;
        }

        public int Birds_GreatKiskudee(Birds gK)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.GreatKiskudee == gK.GreatKiskudee)
                {
                    d.Points = +300;
                }
            }
            return d.Points;
        }

        public int Birds_RedCrossbill(Birds s)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.RedCrossbill == s.RedCrossbill)
                {
                    d.Points = +500;
                }
            }
            return d.Points;
        }

        public int Birds_RedNeckPhalarope(Birds t)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.RedNeckPhalarope == t.RedNeckPhalarope)
                {
                    d.Points = +700;
                }

            }
            return d.Points;
        }

        public int Birds_EveningGrossBeak(Birds p)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.EveningGrossbeak == p.EveningGrossbeak)
                {
                    d.Points = +100;
                }
            }
            return d.Points;

        }

        public int Birds_GreaterPrairieChicken(Birds p)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.GreaterPrairieChicken == p.GreaterPrairieChicken)
                {
                    d.Points = +2000;
                }
            }
            return d.Points;
        }

        public int Birds_IcelandGull(Birds p)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.IcelandGull == p.IcelandGull)
                {
                    d.Points = +3000;
                }
            }
            return d.Points;
        }

        public int Birds_OrangeBelliedParrot(Birds p)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.OrangeBelliedParrot == p.OrangeBelliedParrot)
                {
                    d.Points = +5000;
                }

            }
            return d.Points;
        }

        public int Birds_VulnerableBirdHunter(Birds p)
        {
            Birds b = new Birds();
            if (b.VulnerableBirdHunter == p.VulnerableBirdHunter)
            {
                d.Points = +200;
            }
            return d.Points;
        }

        public int Birds_VulnerableBirdHunter2(Birds p2)
        {
            Birds b = new Birds();
            if (b.VulnerableBirdHunter2 == p2.VulnerableBirdHunter2)
            {
                d.Points = +400;
            }
            return d.Points;
        }

        public int Birds_VulnerableBirdHunter3(Birds p3)
        {
            Birds b = new Birds();
            if (b.VulnerableBirdHunter3 == p3.VulnerableBirdHunter3)
            {
                d.Points = +800;
            }

            return d.Points;
        }

        public int Birds_VulnerableBirdHunter4(Birds p4)
        {
            Birds b = new Birds();
            if (b.VulnerableBirdHunter4 == p4.VulnerableBirdHunter3)
            {
                d.Points = +1000;
            }
            return d.Points;
        }


        public int Birds_InvicibleBirdHunter(Birds iV)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.InvincibleBirdHunter == iV.InvincibleBirdHunter)
                {
                    d.Life = -1;
                }
            }
            return d.Life;
        }

        public int HealthGain(Drofsnar d)
        {
            if (d.Points > 10000)
            {
                d.Life = +1;
            }
            return d.Life;
        }

        public string FinalValues(Drofsnar d)
        {
            return $"Drofsnar final point value {d.Points} and his final live value is {d.Life}.";
        }

        public string BirdCollective(Birds l)
        {
            foreach (Birds b in _birdDirectory)
            {
                if (b.Bird == l.Bird)
                {
                    d.Points = +10;
                }

                else if (b.CrestedIbis == l.CrestedIbis)
                {
                    d.Points = +100;
                }

                else if (b.GreatKiskudee == l.GreatKiskudee)
                {
                    d.Points = +300;
                }

                else if (b.RedCrossbill == l.RedCrossbill)
                {
                    d.Points = +500;
                }
                else if (b.RedNeckPhalarope == l.RedNeckPhalarope)
                {
                    d.Points = +700;
                }

                else if (b.EveningGrossbeak == l.EveningGrossbeak)
                {
                    d.Points = +1000;
                }
                else if (b.GreaterPrairieChicken == l.GreaterPrairieChicken)
                {
                    d.Points = 2000;
                }
                else if (b.IcelandGull == l.IcelandGull)
                {
                    d.Points = +3000;
                }
                else if (b.OrangeBelliedParrot == l.OrangeBelliedParrot)
                {
                    d.Points = +5000;
                }
                else if (b.VulnerableBirdHunter == l.VulnerableBirdHunter)
                {
                    d.Points = +200;
                }
                else if (b.VulnerableBirdHunter2 == l.VulnerableBirdHunter2)
                {
                    d.Points = +400;
                }
                else if (b.VulnerableBirdHunter3 == l.VulnerableBirdHunter3)
                {
                    d.Points = +800;
                }
                else if (b.VulnerableBirdHunter4 == l.VulnerableBirdHunter4)
                {
                    d.Points = +1600;
                }
                else if (b.InvincibleBirdHunter == l.InvincibleBirdHunter)
                {
                    d.Life = -1;
                }

                if (d.Points > 10000)
                {
                    d.Life = +1;
                }
            }
            return $"Drofsnar points {d.Points} Drofsnar lifes {d.Life}";
        }


    }


}


