using DiceGame;

Console.WriteLine("Hello, World!");

var game = new TheGame();
IDie die = new WeightedDie(1, 1, 1, 2);    //StandardDie.D4;
for (int i = 0; i < 100; i++)
    Console.WriteLine(die.Roll());    //the simplest unit test!! :)
int[] rollCounts = [0, 0, 0, 0];
for (var i = 0; i < 10_000; i++)
    rollCounts[die.Roll() - 1]++;
Console.WriteLine($"{rollCounts[0]}); {rollCounts[1]} {rollCounts[2]} {rollCounts[3]}");
game.AddPlayer("Sophie");
Console.ReadLine();
Console.WriteLine($"{rollCounts[0]}); {rollCounts[1]} {rollCounts[2]} {rollCounts[3]}");

DiceCup (params IDie[])
    var DiceCup= new DiceCup (D6, D6,D6)
    
    
//var d7 = new StandardDie(7);
//var die = new IDie();


