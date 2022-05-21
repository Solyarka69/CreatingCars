using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
class MyApplication
{
    public static void Main(String[] args)
    {
        CharacteristicsRobot botyara = new CharacteristicsRobot("BOTYARA",300,new double[] {1.2,3.4,5.1}); 
            botyara.printCharacteristics();

        CharacteristicsRobot botyara2 = new CharacteristicsRobot();
            botyara2.getCharacteristics("BOTYARA2",200,new double[] {2.1,7.8,9.9}); 
            botyara2.printCharacteristics();

        
        

    }
}
