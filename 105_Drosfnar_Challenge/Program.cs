using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_Drosfnar_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

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

}
