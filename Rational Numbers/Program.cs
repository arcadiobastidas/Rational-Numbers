using Rational_Numbers;

//Initilaize objects for operations
var RationalA = new Rational();
var RationalB = new Rational();
var Result = new Rational();

//Set object values
Console.WriteLine("Enter first Rational: ");
RationalA.Ask();

Console.WriteLine("\nEnter second Rational: ");
RationalB.Ask();

//Ask for results precision
Console.Write("\nSet results decimal precision: ");
int resultsPrecision = int.Parse(Console.ReadLine());

//Switch operations
int choice;
do
{
    DisplayMenu();
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Sum Results: \n");
            Result = RationalA.Sum(RationalB);
            Console.WriteLine(Result.ToString());
            Console.WriteLine(Result.ResolveEquation(resultsPrecision));
            Console.WriteLine("______________");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine("Substraction Results: \n");
            Result = RationalA.Substract(RationalB);
            Console.WriteLine(Result.ToString());
            Console.WriteLine(Result.ResolveEquation(resultsPrecision));
            Console.WriteLine("______________");
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine("Multiplication Results: \n");
            Result = RationalA.Multiply(RationalB);
            Console.WriteLine(Result.ToString());
            Console.WriteLine(Result.ResolveEquation(resultsPrecision));
            Console.WriteLine("______________");
            Console.WriteLine();
            break;

        case 4:
            Console.WriteLine("Division Results: \n");
            Result = RationalA.Division(RationalB);
            Console.WriteLine(Result.ToString());
            Result.ResolveEquation(2);
            Console.WriteLine(Result.ResolveEquation(resultsPrecision));
            Console.WriteLine("______________");
            Console.WriteLine();
            break;

        case 5:
            Console.WriteLine("Goodbye");
            System.Environment.Exit(1);
            break;

        default:
            Console.WriteLine("Enter a valid number");
            Console.WriteLine("______________");
            break;
    }
} while (choice != 5);

void DisplayMenu()
{
    //Display Menu of Operations
    Console.WriteLine("Choose an arithmetic operation: ");
    Console.WriteLine(" 1. Sum \n 2. Substract \n 3. Multiply \n 4.Divide \n 5. Exit");
}