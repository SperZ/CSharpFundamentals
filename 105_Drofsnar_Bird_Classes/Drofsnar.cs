using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_Drofsnar_Bird_Classes
{
    public class Drofsnar
    {
        public int Points { get; set; }
        public int Life { get; set; }

        public Drofsnar() { }

        public Drofsnar(int points, int life)
        {
            Points = Points;
            Life = life;
        }
    }

    public class Birdies
    {
        public string Name { get; set; }
    }

    public class Birds
    {
        public string Bird { get; set; }
        public string CrestedIbis { get; set; }
        public string GreatKiskudee { get; set; }
        public string RedCrossbill { get; set; }
        public string RedNeckPhalarope { get; set; }
        public string EveningGrossbeak { get; set; }
        public string GreaterPrairieChicken { get; set; }
        public string IcelandGull { get; set; }
        public string OrangeBelliedParrot { get; set; }
        public string InvincibleBirdHunter { get; set; }
        public string VulnerableBirdHunter { get; set; }
        public string VulnerableBirdHunter2 { get; set; }
        public string VulnerableBirdHunter3 { get; set; }
        public string VulnerableBirdHunter4 { get; set; }
    }


    public enum BirdTypes
    {
        Bird,
        CrestedIbis,
        GreatKiskudee,
        RedCrossbill,
        RedNeckPhalarope,
        EveningGrossbeak,
        GreaterPrairieChicken,
        IcelandGull,
        OrangeBelliedParrot,
        InvincibleBirdHunter,
        VulnerableHunter,
        VulnerabnleHunter2,
        VulneranleHunter3,
        VulnerableHunter4,
    }

  

}
