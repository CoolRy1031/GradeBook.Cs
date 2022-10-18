// See https://aka.ms/new-console-template for more information

var book = new Book("Ryan's Grade Book");

while(true)
{
  Console.WriteLine("Enter a grade or 'q' to quit");
  var input = Console.ReadLine();
  if(input == "q")
  {
    break;
  }
  var grade = double.Parse(input);
  book.AddGrade(grade);
}


var stats = book.ShowStatistics();

Console.WriteLine($"The Lowest grade is {stats.Low}");
Console.WriteLine($"The Highest grade is {stats.High}");
Console.WriteLine($"The Average grade is {stats.Average}");
Console.WriteLine($"The Letter grade is {stats.Letter}");

