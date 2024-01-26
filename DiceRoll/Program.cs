// See https://aka.ms/new-console-template for more information
using static System.Console;
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/
Random dice = new Random();


int bonus=0;

int rolls1 = dice.Next(1,7);
int rolls2 = dice.Next(1,7);
int rolls3 = dice.Next(1,7);

int score=rolls1+rolls2+rolls3;

if(rolls1==rolls2)
{
    if(rolls1==rolls3){
        bonus=6;
    }
    else{
        bonus=2;
    }
}
else if(rolls1==rolls3)
{
    if(rolls1==rolls2){
        bonus=6;
    }
    else{
        bonus=2;
    }
}
else if(rolls3==rolls2)
{
    if(rolls2==rolls1){
        bonus=6;
    }
    else{
        bonus=2;
    }
}
int total= score+bonus;
WriteLine("Roll\tScore");
WriteLine($"Roll 1\t {rolls1}");
WriteLine($"Roll 2\t {rolls2}");
WriteLine($"Roll 3\t {rolls3}");
WriteLine($"\nBonus  :  {bonus}");
WriteLine($"\nTotal Score : {score} + {bonus} = {total}");

if (score > 14)
{
    WriteLine("You win!");
}
else
{
    WriteLine("Sorry, you lose.");
}


