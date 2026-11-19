using System;
using System.Text;
using ConsoleApp1;



internal class Program
{
    static void Main(string[] args)
    {
        // task 1
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        Console.WriteLine("===================");

        // taks 2
        string s1 = "Clean Code";
        string s2 = "Clean Code";
        bool result = object.ReferenceEquals(s1, s2);
        Console.WriteLine(result);


        // task 3
        StringBuilder sb = new StringBuilder("");
        sb.Append("Book List");
        sb.Append(" updated");
        Console.WriteLine(sb);


        // task4
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb);

        // task5

        string title1 = "Clean Code";
        int pages = 464;
        Console.WriteLine("Book: " + title1 + ", Pages: " + pages);

        // task6

        Console.WriteLine($"Book: {title1}, Pages: {pages}");

        // task7

        Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title1, pages));

        // task8

        if (pages > 300)
            Console.WriteLine("Long Book");
        else { Console.WriteLine("short Book"); }

        // task 9 
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
            Console.WriteLine("You can borrow this book");

        // task 10

        title = "Refactoring";

        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");

                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;

            default:
                Console.WriteLine("NativeOverlapped heard of it");
                break;
        }

        // task 11
        string sizeLabel = pages > 300 ? sizeLabel = "Long Book" : sizeLabel = "short book";

        // task 12

        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }


        // task 13
        int j = 0;
        while (j < 3)
        {
            Console.WriteLine(books[j]);
            j++;
        }

        // taask 14 
        int k =0;
        do
        {
            Console.WriteLine("Checking book...");
            k++;
        } while (k < 3);


        // task15
        foreach (string Book in books)
        {
            Console.WriteLine(Book);
        }


        // task16
        for (int i = 0; i < 3; i++)
        {
            if (books[i] == "Refactoring")
                break;
            Console.WriteLine(books[i]);
        }

        // task 17
        for (int i = 0; i < 3; i++)
        {
            if (books[i] == "The Pragmatic Programmer")
                continue;
            Console.WriteLine(books[i]);
        }

        // task 18

        void PrintFirstBook(string[] array)
        {
            if(array.Length == 0)
            {
                return;
            }
            Console.WriteLine(array[0]);
        }
    }
}

// null forgivness operator