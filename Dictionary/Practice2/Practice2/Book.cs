using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Book
    {
        public string SerialNo { get; set; }
        public string Name { get; set; }

        public Book(string name, string isbn)
        {
            SerialNo = isbn;
            Name = name;
        }

        public override string ToString()
        {
            return "ISBN: " + SerialNo + " Book Name: " + Name;
        }
    }
}
