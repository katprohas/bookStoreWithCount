using System;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }
        public void SetId(int i)
        {
            _Id = i;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public void SetTitle(string t)
        {
            _Title = t;
        }

        public string GetAuthor()
        {
            return _Author;
        }
        public void SetAuthor(string a)
        {
            _Author = a;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public void SetTrans()
        {
            
            _transactions++;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetTitle("Adventures of Huckleberry Finn");
            book1.SetAuthor("Mark Twain");

            Book book2 = new Book();
            book2.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book's author: ");
            book2.SetAuthor(Console.ReadLine());

            Book book3 = new Book(3, "Around the World in 80 Days", "Jules Verne");
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempId = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Please enter the book's author: ");
            string tempAuthor = Console.ReadLine();

            Book book4 = new Book(tempId, tempTitle, tempAuthor);
            book4.SetTrans();

            Console.WriteLine($"There are {book1.GetTrans()} new transactions: ");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        static void displayBooks(Book book)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please see book details below: \n");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Title: {book.GetTitle()}");
            Console.WriteLine($"Author: {book.GetAuthor()}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }


    }
}

