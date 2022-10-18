// See https://aka.ms/new-console-template for more information

var book = new Book("Ryan's Grade Book");
book.AddGrade(89.1);
book.AddGrade(90.5);
book.AddGrade(77.5);

var stats = book.ShowStatistics();

Console.WriteLine($"The Lowest grade is {stats.Low}");
Console.WriteLine($"The Highest grade is {stats.High}");
Console.WriteLine($"The Average grade is {stats.Average}");
Console.WriteLine($"The Letter grade is {stats.Letter}");

