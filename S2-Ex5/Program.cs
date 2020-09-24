using System;

namespace S2_Ex5
{
    class Program
    {
        static void Main()
        {
            var cars = new CarRepository().GetCars();

            cars.FindAll(IsWhite).ForEach(Console.WriteLine);
            Console.Out.WriteLine(" ");
            cars.FindAll(hasEngineBiggerThan1_5).ForEach(Console.WriteLine);
            Console.Out.WriteLine(" ");
            cars.FindAll(isBlackAndHasManual).ForEach(Console.WriteLine);
        }
        
        static bool IsWhite(Car car)
        {
            return car.Color == "white";
        }

        static bool hasEngineBiggerThan1_5(Car car) => car.EngineSize > 1.5;

        static bool isBlackAndHasManual(Car car) => car.Color == "black" && car.IsManualShift == true;

    }
    
    
}