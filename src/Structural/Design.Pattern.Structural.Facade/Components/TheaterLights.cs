namespace Design.Pattern.Structural.Facade.Components
{
    public class TheaterLights
    {
        public void Dim(int level) => Console.WriteLine($"Theater Ceiling Lights dimming to {level}%");
    }
}
