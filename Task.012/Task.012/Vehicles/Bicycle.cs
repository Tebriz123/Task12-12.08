using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._012.Vehicles
{
    internal class Bicycle:Vehicle
    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type: {Type}");
        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
    }
}
