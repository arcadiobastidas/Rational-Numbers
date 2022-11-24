using Rational_Numbers;

Console.WriteLine("Please enter 2 rational equations: ");

//Get user input

    //Fist equation
    Console.Write("First Numerator: ");
    int firstNumerator = int.Parse(Console.ReadLine());
    Console.Write("First Denominator: ");
    int firstDenominator = int.Parse(Console.ReadLine());

    //Second Equation
    Console.Write("Second Numerator: ");
    int secondNumerator = int.Parse(Console.ReadLine());
    Console.Write("Second Denominator: ");
    int secondDenominator = int.Parse(Console.ReadLine());
    Console.WriteLine();

  
//Initilaize objects for operations
Rational RationalA = new Rational(firstNumerator, firstDenominator);
Rational RationalB = new Rational(secondNumerator, secondDenominator);
Rational Result;

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
            Result.ResolveEquation(Result);
            Console.WriteLine("______________");
            break;
        case 2:
            Console.WriteLine("Substraction Results: \n");
            Result = RationalA.Substract(RationalB);
            Console.WriteLine(Result.ToString());
            Result.ResolveEquation(Result);
            Console.WriteLine("______________");
            break;
        case 3:
            Console.WriteLine("Multiplication Results: \n");
            Result = RationalA.Multiply(RationalB);
            Console.WriteLine(Result.ToString());
            Result.ResolveEquation(Result);
            Console.WriteLine("______________");
            break;
        case 4:
            Console.WriteLine("Division Results: \n");
            Result = RationalA.Division(RationalB);
            Console.WriteLine(Result.ToString());
            Result.ResolveEquation(Result);
            Console.WriteLine("______________");
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
    Console.WriteLine(" 1. Sum \n 2. Substract \n 3. Multiply \n 4.Divide");
    

}