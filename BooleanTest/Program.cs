// See https://aka.ms/new-console-template for more information

//"Admin|Manager";
Console.WriteLine("Please enter your permission");
string permission = Console.ReadLine();

// Level
Console.WriteLine("Please enter your level");
int level = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You are {permission} with a level {level} clearence!");

if (permission.Contains("Admin") || permission.Contains("Manager")){
    if (permission.Contains("Admin")){
        if (level > 55){
            Console.WriteLine("Welcome, Super Admin user.");
        } else {
            Console.WriteLine("Welcome, Admin user.");
        }
    }
    else if (permission.Contains("Manager")){
        if (level >= 20){
            Console.WriteLine("Contact an Admin for access.");
        } else {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
} 
else {
    Console.WriteLine("You do not have sufficient privileges.");
}