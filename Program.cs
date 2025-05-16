internal class Program // class declaration
{
    public const int TotalScore = 100;
    private static void Main(string[] args) // main method
    { // there is a style guide for semantics

        Console.WriteLine("Hello World of C#, again LOL!");

        // Variable declaration
        int numberOfTimes = 5;

        // can use var
        var numOfTimes = 6; // must be initialized though
        //numOfTimes = "dalfjd";
        object nTimes = 3; // all types inherit from object

        int x, y, z; // can declare multiple variables

        const int MaxScore = 100; // compiler time static variable, only good for using value types, cannot set reference types to consts, can be put in different scopes like class scope or method scope

        if (true)
        {
            int numberOfN = 5;
        }

        //numberOfN

        // all variables go out of scope outside of the block they are in

        // value type like int and bool and have default values
        // can convert value types by declaring as object, theere are implications

        // value types are passed by copy

        object referenceType = null;


        int[] arrayOfIntegers = [1, 2, 3, 4]; // fixed, cannot say var

        foreach (char character in "hello world")
        {
            Console.WriteLine(character);
        }

        Console.WriteLine(arrayOfIntegers.Length); // get length of array

        int[,] twoDimensionalArray = new int[2, 3]; // 2 rows, 3 columns
        Console.WriteLine(twoDimensionalArray.GetLength(0)); // get number of rows
        Console.WriteLine(twoDimensionalArray.GetLength(1)); // get number of columns

        var employeeType = EmployeeType.Manager;
        Console.WriteLine(employeeType); // Manager

        // can cast enum to int
        Console.WriteLine((int)employeeType); // 2
        int employeeTwoType = (int)EmployeeType.Worker;
        Console.WriteLine(employeeTwoType); // 8
        Console.WriteLine("Get back to work!");

        Console.WriteLine("I am loving C# again!");


        Console.WriteLine("Yes, I am really loving C# again!");
        Console.WriteLine("Java still rocks!");

        // I am editing from the terminal!!!



    } 
}

enum EmployeeType // underlying type is int by default
{
    Manager = 2,
    Supervisor = 4,
    Worker = 8
}

class SeparateClass
{
    public void TestMethod()
    {
        Console.WriteLine(Program.TotalScore);
    }
}