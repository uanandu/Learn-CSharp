// See https://aka.ms/new-console-template for more information
// We created an object by the name random
Random random = new Random();

// The variable given here stores the value from Random.next()
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration <= 10){
    if (daysUntilExpiration <= 5){
        if (daysUntilExpiration == 1){
            discountPercentage += 20; 
            Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
        } 
        else if (daysUntilExpiration < 1){
            Console.WriteLine("Your subscription has expired.");
        }
        else {
            discountPercentage += 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
        }
    }
    else {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}
