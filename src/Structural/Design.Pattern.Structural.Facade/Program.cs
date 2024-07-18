using Design.Pattern.Structural.Facade.Components;
using Design.Pattern.Structural.Facade.Facade;

Amplifier amp = new Amplifier();
DvdPlayer dvd = new DvdPlayer();
Projector projector = new Projector();
Screen screen = new Screen();
TheaterLights lights = new TheaterLights();
PopcornPopper popper = new PopcornPopper();

HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, dvd, projector, screen, lights, popper);

homeTheater.WatchMovie("Raiders of the Lost Ark");
homeTheater.EndMovie();
