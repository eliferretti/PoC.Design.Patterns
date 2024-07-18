namespace Design.Pattern.Creational.Builder.Entities
{
    public class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public string Engine { get; private set; }
        public int Doors { get; private set; }

        private Car() { }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} ({Color}) with a {Engine} engine and {Doors} doors.";
        }

        public class Builder
        {
            private readonly Car _car;

            public Builder()
            {
                _car = new Car();
            }

            public Builder SetMake(string make)
            {
                _car.Make = make;
                return this;
            }

            public Builder SetModel(string model)
            {
                _car.Model = model;
                return this;
            }

            public Builder SetYear(int year)
            {
                _car.Year = year;
                return this;
            }

            public Builder SetColor(string color)
            {
                _car.Color = color;
                return this;
            }

            public Builder SetEngine(string engine)
            {
                _car.Engine = engine;
                return this;
            }

            public Builder SetDoors(int doors)
            {
                _car.Doors = doors;
                return this;
            }

            public Car Build()
            {
                return _car;
            }
        }
    }
}
