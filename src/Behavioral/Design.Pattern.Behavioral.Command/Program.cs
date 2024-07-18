using Design.Pattern.Behavioral.Command.Commands;
using Design.Pattern.Behavioral.Command.Devices;
using Design.Pattern.Behavioral.Command.Invoker;

RemoteControl remote = new RemoteControl();

Light livingRoomLight = new Light();
Fan livingRoomFan = new Fan();

ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);
ICommand fanOn = new FanOnCommand(livingRoomFan);
ICommand fanOff = new FanOffCommand(livingRoomFan);

// Turn the light on
remote.SetCommand(lightOn);
remote.PressButton();

// Turn the light off
remote.SetCommand(lightOff);
remote.PressButton();

// Turn the fan on
remote.SetCommand(fanOn);
remote.PressButton();

// Turn the fan off
remote.SetCommand(fanOff);
remote.PressButton();

// Undo the last command (turn the fan on)
remote.PressUndo();