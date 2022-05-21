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
        CarFeatures FirstCar = new CarFeatures("BMW", "black edition", 350.3, 2022);
        FirstCar.OutputFeatures();
        
        CarFeatures SecondCar = new CarFeatures("Audi", "white edition", 433.8, 2021);
        SecondCar.OutputFeatures();

        CarFeatures ThirdCar = new CarFeatures("Lada", "cal edition", 0.1, 1945);
        SecondCar.OutputFeatures();

        CarFeatures.OutputValuesCars();
    }
}
