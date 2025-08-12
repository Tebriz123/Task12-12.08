using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._012.Vehicles
{
    internal abstract class Vehicle
    {
        private string _factoryname;
        private string _model;
        private string _color;
        private double _drivetime;
        private double _drivepath;

         
        public string FactoryName
        {
            get
            {
                return _factoryname;
            }
            set
            {
                _factoryname = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Color
        {
            get
            {

                return _color;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _color = value;
                }
                
            }
        }
        public double DriveTime
        {
            get
            {
                return _drivetime;
            }
            set
            {
                if(value > 0)
                {
                    _drivetime = value;
                }
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivepath;
            }
            set
            {
                if(value > 0)
                {
                    _drivepath = value;
                }
            }
        }



        public void AverageSpeed()
        {
            double speed = DrivePath / DriveTime;
            Console.WriteLine(speed);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName} Model: {Model}  Color: {Color}  DriveTime: {DriveTime}  DrivePath: {DrivePath}");
        }
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }
        public abstract void DefineNatureHarmness(); 



    }
}
