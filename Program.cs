// random dice rolls

Console.WriteLine(" Rolling 1 D6 dice");
//Random rng = new Random();
//int Dice =rng.Next (1,21);
//Console.WriteLine(Dice);
int rolls =0;
int sum =0;
Console.WriteLine(sum);


while(rolls < 10)
{
Random rng = new Random();
int Dice =rng.Next (1,7);
Console.WriteLine(Dice);
sum += Dice;
rolls ++;
}

Console.WriteLine("total Sum is " + sum);
