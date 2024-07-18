namespace Design.Pattern.Structural.Facade.Components
{
    public class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier on");
        public void Off() => Console.WriteLine("Amplifier off");
        public void SetDvd() => Console.WriteLine("Amplifier setting DVD");
        public void SetSurroundSound() => Console.WriteLine("Amplifier surround sound on");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier setting volume to {level}");
    }
}
