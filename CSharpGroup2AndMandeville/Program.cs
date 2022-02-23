// See https://aka.ms/new-console-template for more information

// Declare global variables for use.
decimal salary = 0.0M;
int numberOfdays = 0;
DateTime employmentDate = DateTime.MinValue;
string[] carsOwned = new string[] { };
List<DateTime> dates = new List<DateTime>();

// try..catch used to try an operation and handle any errors gracefully
try
{
    // prompt for a value and store in variable
    Console.WriteLine("Enter Name: ");
    string name = Console.ReadLine();
    PrintName();
    ////name.Append('!');
    ////name.Trim();
    ////name.Trim('-');
    ////name = name.Trim(new char[] { '*', '-', ' ', '.' });
    ////" --*-Trevoir Williams-.-"
    ////"    Trevoir Williams        "
    ////    "Trevoir Williams"
    ////if (name.EndsWith('s'))
    ////{
    ////    Console.WriteLine("Name Ends With S");
    ////}
    ////var splitName = name.Split('-');
    ////Console.WriteLine($"Split name is: {splitName}");

    // Prompt for a value and store in an interger
    // This value needs to be converted in order to store in an int
    // int.Parse(..) might throw an exception if the inputted value
    // cannot be converted. 
    Console.WriteLine("Enter your Age: ");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your Employed State: ");
    bool employed = Convert.ToBoolean(Console.ReadLine());

    Console.WriteLine("Enter The Number of Cars You Have Owned: ");
    var numberOfCars = Convert.ToInt32(Console.ReadLine());

    if(numberOfCars > 0)
    {
        carsOwned = new string[numberOfCars];

        for (int i = 0; i < numberOfCars; i++)
        {
            Console.Write($"Enter The Type Car ({i+1}): ");
            carsOwned[i] = Console.ReadLine();
        }
        
        dates.Add(new DateTime());
        dates.Remove(new DateTime());
    }

    // IF statement checking a boolean before taking action
    if (employed)
    {
        Console.WriteLine("Enter your monthly salary: ");
        salary = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter The Number of Days You Work: ");
        numberOfdays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter The Date You Were Employed (yyyy-mm-dd): ");
        employmentDate = Convert.ToDateTime(Console.ReadLine());
    }

    Console.WriteLine("Name: " + name);
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Employment Status: {employed}");
    if (employed)
    {
        // Logic to show the salary as it adds up for each month
        var totalsalary = salary;
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Salary after Month {i + 1} is {totalsalary}");
            totalsalary += salary;
        }

        // Potential divide by zero exception
        var dailyRate = DailySalary();
        Console.WriteLine($"Your Daily Salary Rate is: {dailyRate}");
        Console.WriteLine($"Your Employment Date: {employmentDate}");
    }

    for (int i = 0; i < numberOfCars; i++)
    {
        Console.WriteLine($"Car Owned: " + carsOwned[i]);
    }
}
catch (Exception ex) // ex is an object that will store the details of any exception that might get thrown
{
    // Print a graceful message to the user without crashing the application
    Console.WriteLine($"{ex.Message}. Please Try Again Later. ");

    // Use throw when you want to crash the application
    ////throw;
}

var timeStamp = DateTime.Now;
Console.WriteLine($"Time of processing: {timeStamp}");
Console.WriteLine($"UTC Time of processing: {DateTime.UtcNow}");
Console.WriteLine($"Come back in two days: {timeStamp.AddDays(2)}");
Console.WriteLine($"It is the {timeStamp.DayOfYear}th day of the year");

Console.WriteLine("Thank you for your information!");


void PrintName() 
{
    Console.WriteLine("I AM THe PrintName Method!!");
}

decimal DailySalary()
{
    return salary / numberOfdays;
}

