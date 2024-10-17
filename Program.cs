Random random = new Random();


int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

// int roll1 = 5;
// int roll2 = 5;
// int roll3 = 5;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll {roll1} + {roll2} + {roll3} = {total}");

if (total < 14)
{
    Console.WriteLine("You win :)");
}

if (total > 15)
{
    Console.WriteLine("you lose");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    total += 2;
    Console.WriteLine("congratulations you rolled doubles");
}
if(roll1 == roll2 && roll2 == roll3)
{
   total += 4;
   Console.WriteLine("Congratulations triples you get 4 extra points");
}

Console.WriteLine($"Dice roll {roll1} + {roll2} + {roll3} = {total}");

