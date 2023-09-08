// See https://aka.ms/new-console-template for more information

//Unit: 2 - array//
//#######//
// Here we created an array of 3 strings
/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// Here we declare the values inside the array by using curly braces
/*
string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"\nReassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/
//------------------------------------------------------------------------//

//Unit: 3 - foreach//
//#######//

/*

// String array
string[] names = { "Rowena", "Robin", "Bao" };

// to iterate through the names array:
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Integer array
int[] inventory = {200, 450, 700, 175, 250};

// to iterate through the numbers array:
foreach (int item in inventory){
    Console.WriteLine(item);
}

// Add variable to sum the value of each element in the array
int[] list = { 200, 450, 700, 175, 250 };
// initial sum
int sum = 0;
foreach (int item in list){
    sum+=item;
}

Console.WriteLine($"We {sum} items in the inventory.");

// Show count and display corresponding item and final sum
int[] inventoryNew = { 200, 450, 700, 175, 250 };
int newSum = 0;
int count = 0;

foreach (int item in inventoryNew){
    newSum+=item;
    count++;
    Console.WriteLine($"Bin {count} = {item} items (Running total: {newSum})");
}

Console.WriteLine($"We {newSum} items in the inventory.");

*/
/*----------------------------------------------------------*/

// Code Challenge//
//###############//

// Declared a string arraty and assigned values to it.
string[] OrderIDList = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string item in OrderIDList)
{
    if (item.StartsWith("B")){
        Console.WriteLine($"The name {item} starts with 'B'!.\n It could be a fraud. \n Double-check necessary!!!");
    } 
}
