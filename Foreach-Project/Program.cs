// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Student requested by the user - Name
string currentStudentName;

// Student requested by the user - marks
int[] currentStudentScores = new int[10];

// Student requested by the user - Grades
string currentStudentGrade = "";

// User input
Console.WriteLine("Please input Student name to continue...");
currentStudentName = Console.ReadLine();

// Console.WriteLine(currentStudentName);

foreach (string student in studentNames){
    currentStudentName = student;
    if (currentStudentName == Sophia){
        string sophiaSum = 0;
        string sophiaGrade
    }

}

// If we dont find the name, we break off the loop, get out and 
// ask the person to enter it again or tell them that this student isnt in the list