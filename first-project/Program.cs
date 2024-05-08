using Information; //for class bookinfo
namespace project;

class Book
{
    static void Main()
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        List<BookInfo> bookList = new List<BookInfo>();
        BookInfo book1 = new BookInfo();
        book1.BookName = "oxford";
        book1.ISBN = "1000";
        book1.Price = 17000;
        book1.AuthorName = "Ruth Gains";
        bookList.Add(book1);

        BookInfo book2 = new BookInfo();
        book2.BookName = "grammar";
        book2.ISBN = "1001";
        book2.Price = 5000;
        book2.AuthorName = "Raymond Murphy";
        bookList.Add(book2);

        BookInfo book3 = new BookInfo();
        book3.BookName = "verbs";
        book3.ISBN = "1002";
        book3.Price = 9000;
        book3.AuthorName = "Stuart Redman";
        bookList.Add(book3);

        BookInfo book4 = new BookInfo();
        book4.BookName = "c++";
        book4.ISBN = "1003";
        book4.Price = 18000;
        book4.AuthorName = "javad vahidy & Moghadam";
        bookList.Add(book4);

        Console.WriteLine("enter a number: ");
        int a = int.Parse(Console.ReadLine());


        if (a == 1)
        {
            BookInfo book5 = new BookInfo();
            Console.Write("book name : ");
            book5.BookName = Console.ReadLine();
            Console.Write("book ISBN : ");---
            book5.ISBN = Console.ReadLine();
            Console.Write("book price : ");
            book5.Price = int.Parse(Console.ReadLine());
            Console.Write("bookAuthor : ");
            book5.AuthorName = Console.ReadLine();
            bookList.Add(book5);

        }
        else if (a == 2)
        {
            Console.WriteLine("enter name of your book to see details  : ");
            string bookName = Console.ReadLine();
            foreach (BookInfo item in bookList)
            {
                if (bookName == item.BookName)
                {
                    Console.WriteLine("\tName : {0},\tISBN : {1}\t,Price : {2} ", item.BookName, item.ISBN, item.Price);
                }

                else
                {
                    Console.WriteLine("  Oops! I can't find any book with this name!");
                    break;
                }


            }

        }
        else if (a == 3)
        {
            foreach (BookInfo item in bookList)
            {
                Console.WriteLine("** Name :{0} ", item.BookName);
                Console.WriteLine();
                Console.WriteLine("Price : {0}", item.Price);
                Console.WriteLine();
                Console.WriteLine("Authorname :{0}  ", item.AuthorName);
                Console.WriteLine();
                Console.WriteLine("ISBN :{0} ", item.ISBN);
                Console.WriteLine();
            }
        }
        else if (a == 4)
        {
            string inputIsbn;
            Console.WriteLine("Enter ISBN : ");
            inputIsbn = Console.ReadLine();
            foreach (BookInfo item in bookList)
            {
                if (inputIsbn == item.ISBN)
                {
                    bookList.Remove(item);
                    Console.WriteLine("removing this item is succesfully!");
                }
                else
                {
                    Console.WriteLine("not valid!");
                    break;
                }

            }
        }
        else if (a == 5)
        {
            int mostExpensive = book1.Price;
            string e = book1.BookName;
            foreach (BookInfo b in bookList)
            {
                if (b.Price > mostExpensive)
                {
                    mostExpensive = b.Price;
                    e = b.BookName;
                }
            }
            Console.WriteLine("Our most expensive book is : {0} ", e);
        }
        else if (a == 6)
        {
            int cheapest = book1.Price;

            string ch = book1.BookName;
            foreach (BookInfo b in bookList)
            {
                if (b.Price < cheapest)
                {
                    cheapest = b.Price;
                    ch = b.BookName;
                }
            }
            Console.WriteLine("Our cheapest book is : {0}", ch);
        }
        else if (a == 7)
        {

            Console.WriteLine("The number of our books is : {0}", bookList.Count);
        }
        else if (a == 8)
        {
            //noooo
        }
        else if (a == 9)
        {
            int priceBetween;
            string name;
            Console.WriteLine("enter price 1 : ");
            int p1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter price 2 : ");
            int p2 = Convert.ToInt16(Console.ReadLine());
            foreach (BookInfo item in bookList)
            {
                if (p1 < item.Price && item.Price < p2)
                {
                    priceBetween = item.Price;
                    name = item.BookName;
                    Console.WriteLine("* name : {0},  price : {1}", name, priceBetween);
                }
            }
        }
        else if (a == 0)
        {
            Console.WriteLine("exit done!");
        }
        else
        {
            Console.WriteLine(" The number is not valid !!! ");
        }
    }
}