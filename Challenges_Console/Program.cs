using _105_Drofsnar_Bird_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Challenges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenges challengeTest = new Challenges();
            challengeTest.LetterPrinter("letter");
            challengeTest.ReturnSortedList();
            challengeTest.BiggieSmalls();
            challengeTest.OutPutReverse("banana");
            List<string> hello = new List<string>() { "JUmp", "Run", "eat" };
            challengeTest.GetByLetterNoVowels(hello);
            challengeTest.LetterPrinter2("supercalifragilisticexpiaildosious");
            challengeTest.LetterPrinterNoI("supercalifragilisticexpialidosious");
            challengeTest.LetterCounter("supercalifragilisticexpialidosious");
            List<string> encounters = new List<string>() {"Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,InvincibleBirdHunter,EveningGrosbeak,GreaterPrairieChicken,VulnerableBirdHunter,VulnerableBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,IcelandGull,CrestedIbis,GreatKiskudee,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,RedCrossbill,Red-neckedPhalarope,InvincibleBirdHunter,VulnerableBirdHunter,Orange-belliedParrot,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,VulnerableBirdHunter"};
            DrofsnarRepo repo = new DrofsnarRepo();
            Drofsnar b = new Drofsnar(5000, 3);
            Console.ReadLine();
        }
        // create a method that returns each char of a string
    }

    public class Challenges
    {
        public void LetterPrinter(string word)
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

        }


        //creates a method that sorts a list of strings
        public void ReturnSortedList()
        {
            List<string> quesodilla = new List<string>();
            quesodilla.Add("cheese");
            quesodilla.Add("meat");
            quesodilla.Add("apple");
            quesodilla.Sort();

            foreach (string taco in quesodilla)
            {
                Console.WriteLine(taco);


            }



        }

        //create a method that sorts a list of integers smallest to biggest
        public void BiggieSmalls()
        {
            List<int> listBefore = new List<int>();
            listBefore.Add(100);
            listBefore.Add(67);
            listBefore.Add(72);
            listBefore.Sort();

            foreach (int x in listBefore)
            {
                Console.WriteLine(x);
            }


        }


        public int StringToInt(string x)
        {
            Console.WriteLine("Input a string");
            string taco = Console.ReadLine();
            int nacho = taco.Length;

            return nacho;
        }

        //create method that takes a list of strings and returns the list without any vowels
        public void GetByLetterNoVowels(List<string> x)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' }; // creating a list of chars that contains the upper and lower case value
            List<string> newList = new List<string>();
            foreach (string word in x)
            {
                StringBuilder hey = new StringBuilder(word.ToLower()); ;
                for (int i = 0; i < hey.Length; i++)
                {
                    if (vowels.Contains(hey[i]))
                    {
                        hey.Replace(hey[i].ToString(), " ");
                        //i--;
                    }
                }
                newList.Add(hey.ToString());
            }
            foreach (string taco in newList)
            {
                Console.WriteLine(taco);
            }

        }


        //create method that returns that takes a list of strings and returns without any vowels
        //public List<string> GetByLetterNoVowels(List<string> x)
        //{
        //    List<string> letters = new List<string>();
        //    foreach (char bowl in letters)
        //    {
        //        if (bowl != "a" || bowl != "e" || bowl != "i" || bowl != "o" || bowl != "u")
        //        {
        //            letters.Add(Convert.ToString(bowl));
        //        }
        //    }

        //    if (letters.Count > 0)
        //    {
        //        return letters;
        //    }

        //    else
        //    {
        //        return null;
        //    }
        //}


        // create a method that takes a user input string and outputs the reverse
        public void OutPutReverse(string word)
        {
            char[] name = word.ToCharArray();
            Array.Reverse(name);
            string name2 = new string(name);

            Console.WriteLine(name2);
        }

        public void FizzBuzz(int x)
        {
            for (int r = 0; r > x; r++)
            {
                if (r % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (r % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (r % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(r);
                }
            }

        }

        public void Greeting(string name)
        {
            Console.WriteLine($"Hello {name}. How are you doing today?");
        }

        public int ReturnInt(string i)
        {
            int o = int.Parse(i);
            return o;
        }

        public void Age(DateTime birth)
        {
            DateTime now = DateTime.Now;
            double timespan = Convert.ToDouble(now - birth);
            int age = Convert.ToInt32(Math.Floor(timespan / 365.25));
            Console.WriteLine(age);
        }

        public void LetterPrinter2(string m)
        {
            foreach(char c in m)
            {
                Console.WriteLine(c);
            }
        }

        public void LetterPrinterNoI(string m)
        {
            foreach (char c in m)
            {
                if (c == 'i')
                {
                    Console.WriteLine(c);
                }

                else
                {
                    Console.WriteLine("Not an i");
                }
            }

        }

        public void LetterCounter(string l)
        {
            int i = 0;
            while(i <= l.Length)
            {
                i++;
            }

            Console.WriteLine(i);

            foreach(char c in l)
            {
                if(c == 'l')
                {
                    Console.WriteLine('L');
                }
            }
        }

        public string FullName(string a, string b)
        {
            User Bob = new User();
            Bob.FirstName = a;
            Bob.LastName = b;
            return $"{Bob.FirstName} {Bob.LastName}";
        }

        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Quotient(int a, int b)
        {
            int quotient = a / b;
            return quotient;
        }

        public int Product(int a, int b)
        {
            int product = a * b;
            return product;
        }

        public int Difference(int a, int b)
        {
            int difference = a - b;
            return difference;
        }

        public void AgeTimeSpan(DateTime birthDate)
        {
            TimeSpan span = DateTime.Now - birthDate;
            Console.WriteLine(span);
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; }

        public User() { }
        public User(string firstName, string lastName, int iD)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = iD;
        }
    }

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

    public class DrofsnarRepo
    {

        public void BridieName(Drofsnar d,List<string> s)
        {
            while (d.Life > 0)
            {
                foreach (string b in s)
                {
                    if (b == "Bird")
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

        }

    }

    

}
