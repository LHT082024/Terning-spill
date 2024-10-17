Random random = new Random();


int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll {roll1} + {roll2} + {roll3} = {total}");

