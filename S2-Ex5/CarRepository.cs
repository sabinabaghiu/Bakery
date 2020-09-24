using System.Collections.Generic;

namespace S2_Ex5
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car("black", 1.4, 15, true),
                new Car("red", 2.0, 8, false),
                new Car("white", 1.8, 12, true),
                new Car("black", 1.6, 6, false),
                new Car("blue", 1.9, 14, true)
            };
        }
    }
}