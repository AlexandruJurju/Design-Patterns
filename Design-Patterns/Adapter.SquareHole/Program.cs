using Adapter.SquareHole;

RoundHole hole = new RoundHole(5);
IRoundPeg roundPeg = new RoundPeg(5);
Console.WriteLine($"Round peg fits: {hole.Fits(roundPeg)}");

ISquarePeg smallSquarePeg = new SquarePeg(5);
ISquarePeg largeSquarePeg = new SquarePeg(10);

IRoundPeg smallAdapter = new SquarePegAdapter(smallSquarePeg);
IRoundPeg largeAdapter = new SquarePegAdapter(largeSquarePeg);

Console.WriteLine($"Small Square Peg fits: {hole.Fits(smallAdapter)}");
Console.WriteLine($"Large Square Peg fits: {hole.Fits(largeAdapter)}");