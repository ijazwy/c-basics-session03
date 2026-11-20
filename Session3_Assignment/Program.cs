using System.Text;

namespace Session3_Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Every question setted into #region and #endregion to make it easy to test each question by commenting the
			// uncommented code inside any region  and run it to test the assignment question.
			// for best practice we can put every question inseparte class file later
			// waiting for any notes exist

			#region Q1
			string title = "clean code";

			string upperTitle = title.ToUpper();

			Console.WriteLine("Original title: " + title);
			Console.WriteLine("Uppercase title: " + upperTitle);

			#endregion

			#region Q2
			//string title1 = "Clean Code";
			//string title2 = "Clean Code";

			//bool isSameReference = ReferenceEquals(title1, title2);

			//Console.WriteLine(isSameReference);

			#endregion

			#region Q3 & Q4
			//Q3: Create a StringBuilder object with the initial value "Book List" and append the string.
			//StringBuilder sb = new StringBuilder();
			//sb.Append("Book List");
			//sb.Append(" - Updated");
			//Console.WriteLine(sb);

			////Q4: Replace "Book List" with "Library"
			//sb.Replace("Book List", "Library");
			//Console.WriteLine(sb);

			#endregion

			#region Q5, Q6, Q7
			//string title = "Clean Code";
			//int pages = 464;

			////string result = "Book: " + title + ", Pages: " + pages;

			////Console.WriteLine(result);

			////Q6
			////string resultInterpolation = $"Book: {title}, Pages: {pages}";
			////Console.WriteLine(resultInterpolation);

			////Q7
			//string resultStringFormat = string.Format("Book: {0}, Pages: {1}", title, pages);
			//Console.WriteLine(resultStringFormat);

			#endregion

			#region Q8
			//int pages = 464;

			//if (pages > 300)
			//{
			//	Console.WriteLine("Long Book");
			//}
			//else
			//{
			//	Console.WriteLine("Short Book");
			//}

			#endregion

			#region Q9
			//int pages = 464;
			//bool isAvailable = true;

			//if (pages > 300 && isAvailable)
			//{
			//	Console.WriteLine("You can borrow this book");
			//}

			#endregion

			#region Q10
			//string title = "Refactoring";
			//switch (title)
			//{
			//	case "Clean Code":
			//		Console.WriteLine("Great choice!");
			//		break;

			//	case "Refactoring":
			//		Console.WriteLine("Nice pick!");
			//		break;

			//	default:
			//		Console.WriteLine("Never heard of it");
			//		break;
			//}

			#endregion

			#region Q11
			//int pages = 464;
			//string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
			//Console.WriteLine(sizeLabel);

			#endregion

			#region Q12
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//for (int i = 0; i < books.Length; i++)
			//{
			//	Console.WriteLine($"{i + 1}. {books[i]}");
			//}

			#endregion

			#region Q13
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//int count = 0;
			//while (count < books.Length)
			//{
			//	Console.WriteLine(books[count]);
			//	count++;
			//}

			#endregion

			#region Q14
			//int count = 1;
			//do
			//{
			//	Console.WriteLine("Checking book...");
			//	count++;
			//}
			//while (count <= 3);

			#endregion

			#region Q15
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//foreach (string book in books)
			//{
			//	Console.WriteLine(book);
			//}

			#endregion

			#region Q16
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//foreach (string book in books)
			//{
			//	if (book == "Refactoring")
			//	{
			//		break;
			//	}

			//	Console.WriteLine(book);
			//}

			#endregion

			#region Q17
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//foreach (string book in books)
			//{
			//	if (book == "The Pragmatic Programmer")
			//	{
			//		continue;
			//	}

			//	Console.WriteLine(book);
			//}
			#endregion

			#region Q18
			//static void PrintFirstBook()
			//{
			//	string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//	if(books.Length == 0) return;
			//	Console.WriteLine(books[0]);
			//}
			//PrintFirstBook();

			#endregion
		}
	}
}
