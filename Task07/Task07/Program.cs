using System;
using static System.Net.Mime.MediaTypeNames;


    namespace Task07
    {
        //Book class with properties
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string Language { get; set; }
            public int Circulation { get; set; }

            public Book(string title, string author, int year, string language, int circulation)
            {
                Title = title;
                Author = author;
                Year = year;
                Language = language;
                Circulation = circulation;
            }
        }

        //Library class with properties
        public class Library
        {
            private Book[] books;
            private int bookCount = 0;

            public Library()
            {
                books = new Book[2];
            }

            public int Count => bookCount;

            // Method to add a book to the library
            public void AddBook(Book book)
            {
                if (bookCount == books.Length)
                {

                    Book[] newBooks = new Book[books.Length + 1];
                    for (int i = 0; i < books.Length; i++)
                    {
                        newBooks[i] = books[i];
                    }
                    books = newBooks;
                }
                books[bookCount++] = book;
            }

            // Method to remove a book from the library
            public bool RemoveBook(Book book)
            {
                for (int i = 0; i < bookCount; i++)
                {
                    if (books[i] == book)
                    {
                        for (int j = i; j < bookCount - 1; j++)
                        {
                            books[j] = books[j + 1];
                        }
                        return true;
                    }
                }
                return false;
            }

            // Method to find and print books by title
            public void FindBook(string title)
            {
                bool found = false;
                for (int i = 0; i < bookCount; i++)
                {
                    // compare book titles 
                    if (books[i].Title == title)
                    {
                        Console.WriteLine(books[i].Title + " by " + books[i].Author);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No books found with that title.");
                }
            }

            // Method to print all books in the library
            public void PrintBooks()
            {
                if (bookCount == 0)
                {
                    Console.WriteLine("The library has no books.");
                }
                else
                {
                    for (int i = 0; i < bookCount; i++)
                    {
                        Console.WriteLine(books[i].Title + " by " + books[i].Author);
                    }
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Initialize a new library with default capacity
                Library library = new Library();

                // Predefined books to be added to the library
                library.AddBook(new Book("Book1", "T. Mann", 1950, "English", 7000));
                library.AddBook(new Book("Book 2", "W. Isaacson", 2011, "Spanish", 25000));
                library.AddBook(new Book("Book 3", "J. Rawling", 2005, "Georgian", 75000));

                // Print all books in the library
                Console.WriteLine("All books in the library:");
                library.PrintBooks();
                Console.WriteLine();

                // Print the number of books in the library
                Console.WriteLine("Total number of books: " + library.Count);
                Console.WriteLine();

                // Search for a book by title
                Console.WriteLine("Searching for 'Book 2':");
                library.FindBook("Book 2");
                Console.WriteLine();

                // Remove a book and display updated list
                Console.WriteLine("Removing 'Book 2' from the library.");
                library.RemoveBook(new Book("Book 2", "W. Isaacson", 2011, "Spanish", 25000));
                Console.WriteLine();

                Console.WriteLine("All books in the library after removal:");
                library.PrintBooks();
                Console.WriteLine("Total number of books: " + library.Count);

                //bolos mainc ver vahoreb meore cigns, cers romelia amogebuli, Tumca sabolooshi ver vigeb
            }
        }

    }


