using System.Collections;
using System.IO;
namespace Practice2
{
    public class Books : DictionaryBase
    {
        public Books() { }

        public int Add(string isbn, Book newBook)
        {
            int rc = -1;
            if(!Dictionary.Contains(isbn))
            {
                Dictionary.Add(isbn, newBook);
                rc = 0;
            }

            return rc;
        }

        public void Remove(string isbn)
        {
            Dictionary.Remove(isbn);
        }

        public Book this[int bookIndex]
        {
            get { return (Book)Dictionary[bookIndex] ; }
            set { Dictionary[bookIndex] = value as Book; }
        }

        public void WriteLine()
        {
            FileStream myFile = new FileStream("BookList.txt", FileMode.Create);
            StreamWriter bookWriter = new StreamWriter(myFile);

            foreach(DictionaryEntry obj in Dictionary)
            {
                bookWriter.WriteLine(obj.Key.ToString() + " : " + ((Book)obj.Value).Name);
            }
            bookWriter.Close();
        }
    }
}
