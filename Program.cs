// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Ninja Ryu = new Ninja("Ryu");

Wizard Iphigenia = new Wizard("Iphigenia");

Samurai Toshiro = new Samurai ("Toshiro Mifune");

Ryu.Attack(Iphigenia);
Console.WriteLine($"{Ryu.Name} has attacked {Iphigenia.Name}! Her health is now {Iphigenia.Health}.");

Ryu.Steal(Toshiro);
Console.WriteLine($"{Ryu.Name} has stolen health from {Toshiro.Name}! His health is now {Ryu.Health}.");

Iphigenia.Heal(Iphigenia);
Console.WriteLine($"{Iphigenia.Name} casts healing on herself! Her health is now {Iphigenia.Health}.");



