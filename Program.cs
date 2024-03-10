using Christmass_2023_Arena;

// Initialize the repository (Arena)
Arena arena = new Arena("Rome", 3);

// Initialize entity

Gladiator firstGladiator = new Gladiator("Spartacus", 100, 100);
Gladiator secondGladiator = new Gladiator("Peshocus", 80, 60);
Gladiator thirdGladiator = new Gladiator("Toshocus", 20, 20);

//Add Gladiator

Console.WriteLine(arena.AddGladiator(firstGladiator));  // Spartacus successfully enlisted in the arena
Console.WriteLine(arena.AddGladiator(secondGladiator)); // Peshocus successfully enlisted in the arena
Console.WriteLine(arena.AddGladiator(thirdGladiator));  // Toshocus successfully enlisted in the arena
Console.WriteLine(arena.GladiatorCount()); // 3

//Remove Gladiator
Console.WriteLine(arena.RemoveGladiator("Peshocus")); // True
Console.WriteLine(arena.GladiatorCount()); // 2

Console.WriteLine(arena.RemoveGladiator("Peshocus")); // False
Console.WriteLine(arena.GladiatorCount()); // 2

//Get Strongets Gladiator
Console.WriteLine(arena.GetStrongestGladiator()); // Name => [Spartacus] Strength => [100] Health => [100]

//Battle
Console.WriteLine(arena.Battle("Spartacus", "Toshocus"));  // The winner is Spartacus.Toshocus died in the arena.
Console.WriteLine(arena.GladiatorCount()); // 1

//Remove Gladiator
Console.WriteLine(arena.RemoveGladiator("Spartacus")); // true


// Initialize entity
Gladiator fourthGladiator = new Gladiator("Asterix", 100, 100);
Gladiator fifthGladiator = new Gladiator("Naidobrix", 80, 120);
Gladiator sixthGladiator = new Gladiator("Obelix", 100, 20);

//Add Gladiator
Console.WriteLine(arena.AddGladiator(fourthGladiator));  // Asterix successfully enlisted in the arena
Console.WriteLine(arena.AddGladiator(fifthGladiator));   // Naidobrix successfully enlisted in the arena
Console.WriteLine(arena.AddGladiator(sixthGladiator));   // Obelix successfully enlisted in the arena

//Battle
Console.WriteLine(arena.Battle("Asterix", "Obelix"));  // There is no winner.
Console.WriteLine(arena.Battle("Asterix", "Naidobrix"));  // The winner is Asterix.
Console.WriteLine(arena.GetStrongestGladiator());  // The winner is Asterix.

// ArenaInfo

Console.WriteLine(arena.ArenaInfo());
//Warriors enlisted in the Grand Arena of Rome:
//Name => [Asterix] Strength => [100] Health => [100]
//Name => [Naidobrix] Strength => [80] Health => [20]
//Name => [Obelix] Strength => [100] Health => [20]
