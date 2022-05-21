using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

    class CarFeatures{
        public string ?name,color;
        public double HorsePower;
        public short ReleaseDate;

        public CarFeatures(string _name, string _color, double _HorsePower, short _ReleaseDate){
        System.Console.WriteLine("Car has been created");
        GetFeatures(_name,_color,_HorsePower,_ReleaseDate);
        }
        public void GetFeatures(string _name, string _color, double _HorsePower, short _ReleaseDate){
            name = _name;
            color = _color;
            HorsePower = _HorsePower;
            ReleaseDate = _ReleaseDate;
        }
        public void OutputFeatures(){
            System.Console.WriteLine("Car - " + name);
            System.Console.WriteLine("Car color - " + color);
            System.Console.WriteLine("Car have - " + HorsePower + " horsepower");
            System.Console.WriteLine("Car release date - " + ReleaseDate);
        }

}
