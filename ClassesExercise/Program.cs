using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var myFirstCar = new Car();

            myFirstCar.Make = "Honda";
            myFirstCar.Model = "Accord";
            myFirstCar.Year = 2020;

            Console.WriteLine($"Make: {myFirstCar.Make}");
            Console.WriteLine($"Model: {myFirstCar.Model}");
            Console.WriteLine($"Year: {myFirstCar.Year}");
            
        }
    }
}
