using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            string regnum;
            string color;
            int fuel;
            int odometer;


            public Car(string _name, string _model, string _regnum, string _color)
            {
                name = _name;
                model = _model;
                regnum = _regnum;
                color = _color;
                fuel = 60;
                odometer = 0;

                Console.WriteLine($"Congratulations! {color} {name} {model} {regnum} has been created.");
            }


            
            public string Name
            {
                get { return name; }
            }

            public string Model
            {
                get { return model; }
            }

            public string Regnum
            {
                get { return regnum; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fuel
            {
                get { return fuel; }
            }

            public void Drive()
            {
                fuel -= 5;
                odometer += 100;
                Console.WriteLine("Wwryyyyyy");
            }
            public void ShowCarInfo()
            {
                Console.WriteLine($"Car Name: {name}.");
                Console.WriteLine($"Car Model: {model}.");
                Console.WriteLine($"Car Registration Number: {regnum}.");
                Console.WriteLine($"Car Color: {color}.");
                Console.WriteLine($"Car Fuel tank: {fuel}.");
                Console.WriteLine($"Car Odometer: {odometer}.");
            }
        }
        static void Main(string [] args)
        {
            Car myCar = new Car("Toyota", "Celica", "Fafnir", "Red");

            while(myCar.Fuel > 0)
            {
                myCar.Drive();
            }
            myCar.ShowCarInfo();
        }
    }
}          
