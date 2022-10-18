// See https://aka.ms/new-console-template for more information

var book = new Book("Ryan's Grade Book");
book.GradeAdded += OnGradeAdded;



while(true)
{
  Console.WriteLine("Enter a grade or 'q' to quit");
  var input = Console.ReadLine();
  if(input == "q")
  {
    break;
  }
  try
  {
    var grade = double.Parse(input);
    book.AddGrade(grade);
  }
  catch(ArgumentException ex)
  {
    Console.WriteLine(ex.Message);
  }
  catch(FormatException ex)
  {
    Console.WriteLine(ex.Message);
  }
  finally
  {
    Console.WriteLine("**");
  }
}


var stats = book.ShowStatistics();


Console.WriteLine($"For the Book Named {book.Name}");
Console.WriteLine($"The Lowest grade is {stats.Low}");
Console.WriteLine($"The Highest grade is {stats.High}");
Console.WriteLine($"The Average grade is {stats.Average}");
Console.WriteLine($"The Letter grade is {stats.Letter}");

static void OnGradeAdded(object sender, EventArgs e)
{
  Console.WriteLine("A grade was added");
}