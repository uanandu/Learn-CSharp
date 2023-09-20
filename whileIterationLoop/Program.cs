// See https://aka.ms/new-console-template for more information

// Exercise 1: do-while statements
Random random = new Random();

int current = 0;

do {
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// Exercise 2: While statements
int currentNumber = random.Next(1, 11);
while (currentNumber >= 3)
{
    Console.WriteLine(currentNumber);
    currentNumber = random.Next(1, 11);
}
Console.WriteLine($"Last number: {currentNumber}");

// Challenge
int hero = 10;
int monster = 10;

// set random value - already set up
Random dice = new Random();

do {
    int roll = dice.Next(1,11);
    
    // for monster
    monster -=roll; // each roll we reduce the roll number from monster
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <=0) continue; // if monster health is 0

    // hero 
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0); // we play as long as both hero and monster are above 0
