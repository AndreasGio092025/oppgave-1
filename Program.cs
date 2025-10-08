
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


    
    int year = 2025;
    int month = 12;

for (int day = 1; day <= 31; day++)
 {

    DateTime date = new DateTime(year, month, day);

    Console.WriteLine(date.ToString("d.M.yyyy"));

    if (date.DayOfWeek == DayOfWeek.Tuesday)
     {
        Console.WriteLine("good Tuesday");
     }
     else
     {
     Console.WriteLine("it's not Tuesday");

     }
    Console.WriteLine();
}

    



    




    