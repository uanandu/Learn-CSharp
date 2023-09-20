// See https://aka.ms/new-console-template for more information

// // Exercise 1: For Iteration loop - Basic

// for (int i = 0; i < 10; i++){
//     Console.WriteLine($"Hello, World!: x{i}");
// }

// // Exercise 2: For Iteration loop - array
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--){
//     Console.WriteLine(names[i]);
// }

// // Check the limitation of foreach iteration
// // foreach (var name in names)
// // {
// //     // Can't do this:
// //     if (name == "David") name = "Sammy";
// // }

// // SOLUTION: 
// for (int i = 0; i<names.Length; i++){
//     if (names[i] == "David"){
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names) 
// {
//     Console.WriteLine(name);
// }

// Challenge: FizzBuzz 

for (int i = 1; i < 100; i++){
    if (i%3 == 0  && i%5 == 0){
        Console.WriteLine($"{i} - FizzBuzz");
    } else if(i%5 == 0){
        Console.WriteLine($"{i} - Buzz");
    } else if(i%3 == 0){
        Console.WriteLine($"{i} - Fizz");
    } else {
        Console.WriteLine(i);
    }
}
