internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayOfIntegers = [1, 2, 3, 4];

        foreach (int num in arrayOfIntegers)
        {
            Console.WriteLine(num);
        }

        foreach (char character in "hello world!")
        {
            Console.WriteLine(character);
        }
        Console.WriteLine(arrayOfIntegers.Length);

        var employeeType = EmployeeType.Manager;

        Console.WriteLine((int)employeeType);

        var myTuple = (42, "Hello", true);
        Console.WriteLine(myTuple);

        var personInfo = (Age: 30, Name: "Alice", IsEmployed: true);

        Console.WriteLine(personInfo.Name);


        var personInfo2 = GetEmployee();
        Console.WriteLine(personInfo2);



    }

    // named tuples
    private static (int Age, string Name) GetEmployee() // return multiple values from a method
    {
        return (30, "Alice");
    }
}

// enums have an underlying type int by default, can be declared as a type
enum EmployeeType
{
    Manager = 2,
    Supervisor = 3,
    Worker = 4
}

// public static class Math
// {
//     public static int AddNumbers(int a, int b)
//     {
//         return a + b;
//     }
// }
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         static int addNumbers(int a, int b)
//         {
//             return 0;
//         }
//         int a = 1;
//         int b = 2;

//         int c = AddNumbers(1);
//         Console.WriteLine("Hello, World!??!!!!??");
//         Console.WriteLine(c);
//     }

//     public static int AddNumbers(int a, int b = 5) // default value, value parameter
//     {
//         return a + b;
//     }

//     public static void PrintMessage() // just does stuff, usually does processing
//     {

//     }

//     public static int AddNumbers(int a, int b, int c) // signature, name and params, method overloading
//     {
//         return a + b;
//     }

//     // public static int AddNumbers(string name params int[] integers) // signature, name and params, method overloading, params allows infinite number of parameters, comes at the end like optional parameters
//     // {
//     //     return a + b;
//     // }

// // a static method is a helper method that does not rely on anything in the class, utility functions
//     public static bool isEven(int number)
//     {
//         if (number % 2 == 0)
//         {
//             return true;
//         }
//         return false;
//     }
// }


// // internal class Program // class declaration
// // {
// //     public const int TotalScore = 100;
// //     private static void Main(string[] args) // main method
// //     { // there is a style guide for semantics

// //         Console.WriteLine("Hello World of C#, again LOL!");

// //         // Variable declaration
// //         int numberOfTimes = 5;

// //         // can use var
// //         var numOfTimes = 6; // must be initialized though
// //         //numOfTimes = "dalfjd";
// //         object nTimes = 3; // all types inherit from object

// //         int x, y, z; // can declare multiple variables

// //         const int MaxScore = 100; // compiler time static variable, only good for using value types, cannot set reference types to consts, can be put in different scopes like class scope or method scope

// //         if (true)
// //         {
// //             int numberOfN = 5;
// //         }

// //         //numberOfN

// //         // all variables go out of scope outside of the block they are in

// //         // value type like int and bool and have default values
// //         // can convert value types by declaring as object, theere are implications

// //         // value types are passed by copy

// //         object referenceType = null;


// //         int[] arrayOfIntegers = [1, 2, 3, 4]; // fixed, cannot say var

// //         foreach (char character in "hello world")
// //         {
// //             Console.WriteLine(character);
// //         }

// //         Console.WriteLine(arrayOfIntegers.Length); // get length of array

// //         int[,] twoDimensionalArray = new int[2, 3]; // 2 rows, 3 columns
// //         Console.WriteLine(twoDimensionalArray.GetLength(0)); // get number of rows
// //         Console.WriteLine(twoDimensionalArray.GetLength(1)); // get number of columns

// //         var employeeType = EmployeeType.Manager;
// //         Console.WriteLine(employeeType); // Manager

// //         // can cast enum to int
// //         Console.WriteLine((int)employeeType); // 2
// //         int employeeTwoType = (int)EmployeeType.Worker;
// //         Console.WriteLine(employeeTwoType); // 8
// //         Console.WriteLine("Get back to work!");

// //         Console.WriteLine("I am loving C# again!");


// //         Console.WriteLine("Yes, I am really loving C# again!");
// //         Console.WriteLine("Java still rocks!");

// //         // I am editing from the terminal!!!



// //     } 
// // }

// // enum EmployeeType // underlying type is int by default
// // {
// //     Manager = 2,
// //     Supervisor = 4,
// //     Worker = 8
// // }

// // class SeparateClass
// // {
// //     public void TestMethod()
// //     {
// //         Console.WriteLine(Program.TotalScore);
// //     }
// // }