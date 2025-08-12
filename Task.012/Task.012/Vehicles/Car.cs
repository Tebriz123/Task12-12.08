using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._012.Vehicles
{
    internal class Car:Vehicle
    {
        private int _doorcount;
        private bool _iselectriccar;


        public int DoorCount
        {
            get
            {
                 return _doorcount;
            }
            set
            {
                if (value > 1)
                {
                    _doorcount = value;
                }
            }
        }
        public bool IsElectricCar
        {
            get
            {
                return _iselectriccar;
            }
            set
            {
                _iselectriccar = value;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"DoorCount: {DoorCount}  IsElectricCar: {IsElectricCar}");
        }
        public override void DefineNatureHarmness()
        {
            if ( IsElectricCar )
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
    }
}
