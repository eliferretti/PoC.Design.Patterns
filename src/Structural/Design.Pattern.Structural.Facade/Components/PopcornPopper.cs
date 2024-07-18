﻿namespace Design.Pattern.Structural.Facade.Components
{
    public class PopcornPopper
    {
        public void On() => Console.WriteLine("Popcorn Popper on");
        public void Off() => Console.WriteLine("Popcorn Popper off");
        public void Pop() => Console.WriteLine("Popcorn Popper popping popcorn!");
    }
}
