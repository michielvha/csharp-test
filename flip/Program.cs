Random flip = new Random();
string result = flip.Next(0, 2) == 0 ? "Heads" : "Tails";
Console.WriteLine($"Coin flip result: {result}");

// or even shorter by calling the method directly in the string interpolation
Console.WriteLine((flip.Next(0, 2) == 0) ? "heads" : "tails");