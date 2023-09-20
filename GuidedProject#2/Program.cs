﻿// See https://aka.ms/new-console-template for more information

// ourAnimals array has:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Variables
int maxPets = 8;
string? readResult; // it has to be a string.
// we facilitate it for the menuselection
string menuSelection = "";

// Array to store data
string[,] ourAnimals = new string[maxPets, 6];
// It is a two-D array with 8 rows and 6 columns
for (int i = 0; i <= maxPets; i++)
{
    // Data stored
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    // WE add the animals to the ourAnimals array
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

}
// Menu option - here we use a do...while loop as since each time
// the user makes choice the main menu is refreshed 
// display the top-level menu options

// Console.Clear();

// Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
// Console.WriteLine(" 1. List all of our current pet information");
// Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
// Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
// Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
// Console.WriteLine(" 5. Edit an animal’s age");
// Console.WriteLine(" 6. Edit an animal’s personality description");
// Console.WriteLine(" 7. Display all cats with a specified characteristic");
// Console.WriteLine(" 8. Display all dogs with a specified characteristic");
// Console.WriteLine();
// Console.WriteLine("Enter your selection number (or type Exit to exit the program)");


// readResult = Console.ReadLine();
// if (readResult != null)
// {
//     menuSelection = readResult.ToLower();
// }

// int mySelection = int.Parse(menuSelection);

// if (mySelection <= 8){
//     Console.WriteLine($"You selected menu option {mySelection}.");
//     Console.WriteLine("Press the Enter key to continue");
// } else {
//     Console.WriteLine("You have not entered a valid selection. Please re-run the program and try again.");
// }

// // pause code execution
// readResult = Console.ReadLine();

// switch (mySelection)
// {
//     case 1:
//         // List all of our current pet information
//         for (int animal=0; animal <= maxPets; animal++){
//             if (ourAnimals[animal,0] != "ID #: "){
//                 Console.WriteLine(ourAnimals[animal, 0]);
//             }
//         }

//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 2:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Add a new animal friend to the ourAnimals array");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 3:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Ensure animal ages and physical descriptions are complete");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 4:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Ensure animal nicknames and personality descriptions are complete");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 5:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Edit an animal’s age");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 6:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Edit an animal’s personality description");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 7:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Display all cats with a specified characteristic");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

//     case 8:
//         // Add a new animal friend to the ourAnimals array
//         Console.WriteLine("Display all dogs with a specified characteristic");
//         Console.WriteLine("Press the Enter key to continue.");
//         readResult = Console.ReadLine();
//         break;

// }

