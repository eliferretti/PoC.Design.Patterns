namespace Design.Pattern.Structural.Facade.Components
{
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player on");
        public void Off() => Console.WriteLine("DVD Player off");
        public void Play(string movie) => Console.WriteLine($"DVD Player playing \"{movie}\"");
        public void Stop() => Console.WriteLine("DVD Player stopped");
        public void Eject() => Console.WriteLine("DVD Player eject");
    }
}
