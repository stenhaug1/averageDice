// random dice rolls

Console.WriteLine(" Rolling some dice :) ");
//Random rng = new Random();
//int Dice =rng.Next (1,21);
//Console.WriteLine(Dice);
int rolls = 0;
int sum = 0;
Console.WriteLine("How Many Rolls do you want to roll?");
int DiceRolls = int.Parse(Console.ReadLine());
//Console.WriteLine(sum);
Console.WriteLine("How many sides on the Die would you like to roll?");
int DiceSides = int.Parse(Console.ReadLine());


if (DiceSides == 6)
{
    while (rolls < DiceRolls)
    {
        Random rng = new Random();
        int Dice = rng.Next(1, 7);
        sum += Dice;
        rolls++;
    }

}

else if (DiceSides == 4)
{
    while (rolls < DiceRolls)
    {
        Random rng = new Random();
        int Dice = rng.Next(1, 5);
        sum += Dice;
        rolls++;
    }
}
else if (DiceSides == 10)
{
    while (rolls < DiceRolls)
    {
        Random rng = new Random();
        int Dice = rng.Next(1, 11);
        sum += Dice;
        rolls++;
    }
}
else if (DiceSides == 20)
{
    while (rolls < DiceRolls)
    {
        Random rng = new Random();
        int Dice = rng.Next(1, 21);
        sum += Dice;
        rolls++;
    }
}

else
{
    while (rolls < DiceSides)
    {
        Random rng = new Random();
        int Dice = rng.Next(1, 101);
        sum += Dice;
        rolls++;
    }
}


double Avg = (double)sum / (double)DiceRolls;
Console.WriteLine("total Sum is " + sum);
Console.WriteLine("Avg is " + Avg);
