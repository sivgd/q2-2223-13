using System;

namespace BooksProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Book AThousandNos = new Book("A Thousand No's", 48, "Educational", true, 4.7f, 0, true, true, true, "DJ Corchin", 1);
            AThousandNos.Read();
            Book CodeForBeginners = new Book("C++ For Beginners", 88, "Educational", true, 3.9f, 8, true, true, false, "Robert W. James", 1);
            CodeForBeginners.Bind();
        }
    }
}
