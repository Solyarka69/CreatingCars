using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

    class CarFeatures{
        public static short ValuesCars;
        public static string ?name,color;
        public static double HorsePower;
        public static short ReleaseDate;

        public CarFeatures(string _name, string _color, double _HorsePower, short _ReleaseDate){
        System.Console.WriteLine("Car has been created");
        GetFeatures(_name,_color,_HorsePower,_ReleaseDate);
        }
        public void GetFeatures(string _name, string _color, double _HorsePower, short _ReleaseDate){
            name = _name;
            color = _color;
            HorsePower = _HorsePower;
            ReleaseDate = _ReleaseDate;
            ValuesCars++;
        }
        public void OutputFeatures(){
            System.Console.WriteLine("Car - " + name);
            System.Console.WriteLine("Car color - " + color);
            System.Console.WriteLine("Car have - " + HorsePower + " horsepower");
            System.Console.WriteLine("Car release date - " + ReleaseDate);
        }
        public static void OutputValuesCars(){
            System.Console.WriteLine(ValuesCars + " cars has been created!");
        }
}
