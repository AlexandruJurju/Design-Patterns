using Command.Remote.Commands;
using Command.Remote.Invokers;
using Command.Remote.Receivers;

var remote = new RemoteControls();

var light = new Light();
var garageDoor = new GarageDoor();

var lightOn = new LightOnCommand(light);
var lightOff = new LightOffCommand(light);
var garageOpen = new GarageDoorOpenCommand(garageDoor);
var garageClose = new GarageDoorCloseCommand(garageDoor);

remote.SetCommand(lightOn);
remote.PressButton();
Console.WriteLine();

remote.SetCommand(lightOff);
remote.PressButton();
Console.WriteLine();

remote.SetCommand(garageOpen);
remote.PressButton();
Console.WriteLine();

remote.SetCommand(garageClose);
remote.PressButton();
Console.WriteLine();
