using Design.Pattern.Structural.Adapter.Adapter;
using Design.Pattern.Structural.Adapter.Entities;
using Design.Pattern.Structural.Adapter.Interfaces;

LegacySystem legacySystem = new LegacySystem();
INewSystem adaptedSystem = new LegacyToNewAdapter(legacySystem);

Console.WriteLine(adaptedSystem.GetData()); // Output: Data from legacy system