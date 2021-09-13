using System;
using System.IO;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book = new Books();
            Book obj = new Book("Ea", "abc");
            Console.WriteLine(book.Add(obj.SerialNo, obj));
            Console.WriteLine(book.Add(obj.SerialNo, obj));
        }
    }

}
