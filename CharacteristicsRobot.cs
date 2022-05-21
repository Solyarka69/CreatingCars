using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

    class CharacteristicsRobot{

        private string ?name;
        private int weight;
        private double[] ?coordinates;
        

        public CharacteristicsRobot(string _name, int _weight, double[] _coordinates){
            System.Console.WriteLine("Object has been created");
            getCharacteristics(_name,_weight,_coordinates);
        }
        public CharacteristicsRobot(){}
        

    public void getCharacteristics(string _name, int _weight, double[] _coordinates){
        name = _name;
        weight = _weight;
        coordinates = _coordinates;
    }

    public void printCharacteristics(){
        System.Console.WriteLine("Bot name is " + name);
        System.Console.WriteLine("Bot weight is " + weight);
        System.Console.WriteLine("Bot coodinates is");
        foreach(double el in coordinates) 
        System.Console.WriteLine(el);
        
    }

}
