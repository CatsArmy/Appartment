using Flats;

Flat f1 = new Flat(1, "Lennon", 5, 4);
Flat f2 = new Flat(2, "Star", 3, 2);
f1.Pay(1);
f2.Pay(2);
Console.WriteLine($"Your debt is: {f2.Debt()}");