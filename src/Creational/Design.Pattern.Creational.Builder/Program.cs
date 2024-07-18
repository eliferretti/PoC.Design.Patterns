using Design.Pattern.Creational.Builder.Entities;

var car = new Car.Builder()
           .SetMake("Toyota")
           .SetModel("Corolla")
           .SetYear(2024)
           .SetColor("Red")
           .SetEngine("Hybrid")
           .SetDoors(4)
           .Build();

Console.WriteLine(car);
