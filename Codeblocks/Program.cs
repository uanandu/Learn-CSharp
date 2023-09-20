// See https://aka.ms/new-console-template for more information

// Exercise 1
bool flag = true;
int value = 0;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Outside of code block: {value}");

// Exercise 2
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
int position = 0;


foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       found = true;
       position = Array.IndexOf(numbers, number);
    }

}

if (found) 
{
    Console.WriteLine($"Set contains 42 at position {position+1}");

}

Console.WriteLine($"Total: {total}");