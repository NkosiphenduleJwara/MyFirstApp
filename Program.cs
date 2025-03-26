internal class Program
{

    private static void Main(string[] args)
    {
        int[] arrayOfIntegers = [1, 2, 3, 4]; // fixed, cannot say var

        foreach (char character in "hello world") {
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
        int employeeTwoType = (int) EmployeeType.Worker;
        Console.WriteLine(employeeTwoType); // 8
        Console.WriteLine("Get back to work!");

        Console.WriteLine("I am loving C# again!");

        
        Console.WriteLine("Yes, I am really loving C# again!");
        Console.WriteLine("Java still rocks!");
        

        
    } 
}

enum EmployeeType // underlying type is int by default
{
    Manager = 2,
    Supervisor = 4,
    Worker = 8
}