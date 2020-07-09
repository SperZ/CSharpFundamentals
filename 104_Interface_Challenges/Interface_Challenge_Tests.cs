using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _104_Interface_Challenges
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }
        bool Starts { get; }
        bool TurnsOff { get; }
        bool Drives { get; }
    }

    public class SUV : IVehicle
    {
        public string Make
        {
            get { return "Ford"; }
        }

        public string Model
        {
            get { return "Expedition"; }
        }

        public string Color
        {
            get { return "orange"; }
        }

        public bool Starts
        {
            get
            {
                bool starts = false;
                return starts;
            }
        }
        public bool TurnsOff
        {
            get
            {
                bool turnsOff = false;
                return turnsOff;
            }
        }
        public bool Drives
        {
            get
            {
                bool drives = false;
                return drives;
            }
        }


    }

    public class Motorcycle : IVehicle
    {
        public string Make
        {
            get { return "Victory"; }
        }

        public string Model
        {
            get { return "500"; }
        }

        public string Color
        {
            get { return "blue"; }
        }

        public bool Starts
        {
            get
            {
                bool starts = true;
                return starts;
            }
        }

        public bool TurnsOff
        {
            get
            {
                bool turnsOff = false;
                return turnsOff;
            }
        }

        public bool Drives
        {
            get
            {
                bool drives = true;
                return drives;
            }

        }

        public class Plane : IVehicle
        {
            public string Make
            {
                get { return "Cesna"; }
            }

            public string Model
            {
                get { return "800"; }
            }

            public string Color
            {
                get { return "White"; }
            }

            public bool Starts
            {
                get
                {
                    bool starts = true;
                    return starts;
                }

            }


            public bool TurnsOff
            {
                get
                {
                    bool turnsOff = true;
                    return turnsOff;
                }
            }

            public bool Drives
            {
                get
                {
                    bool drives = true;
                    return drives;
                }
            }
        }

        public class Boat : IVehicle 
        {
            public string Make { get { return "Polaris"; } }

            public string Model { get { return "SpeedMachine"; } }

            public string Color { get { return "yellow"; } }

            public bool Starts { get { bool starts = true;
                    return starts;
                } }

            public bool TurnsOff { get { bool turnsOff = true;
                    return turnsOff;
                } }

            public bool Drives { get { bool drives = false;
                    return drives;
                } }
        }



        [TestClass]
        public class IVechileTest
        {
            [TestMethod]
            public void PlaneTest()
            {
                IVehicle plane = new Plane();
                string output = plane.Make;

                Console.WriteLine($"The planes make is a {output}");

                IVehicle suv = new SUV();
                string output2 = suv.Model;

                Console.WriteLine($"The model of the suv is an {output2}");

                IVehicle cycle = new Motorcycle();
                bool output3 = cycle.Starts;

                Console.WriteLine($"Does the Motorcycle run? {output3}.");

                IVehicle boat = new Boat();
                bool output4 = boat.Drives;

                Console.WriteLine($"Does the boat drive {output4}");

            }

        }
    }
}
