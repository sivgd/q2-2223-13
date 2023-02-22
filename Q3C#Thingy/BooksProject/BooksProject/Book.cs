using System;
using System.Collections.Generic;
using System.Text;

namespace BooksProject
{
   public class Book
   {
        public string Title;
        public int NumberOfPages;
        public string Genre;
        public bool IsFiction;
        public float RatingOfBook;
        public int Chapters;
        public bool HasPictures;
        public bool IsHardcover;
        public bool HasTextOnBack;
        public string Author;
        public int CurrentPage;

        public Book(string title, int numberOfPages, string genre, bool isFiction, float ratingOfBook, int chapters, bool hasPictures, bool isHardcover, bool hasTextOnBack, string author, int currentPage)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            Genre = genre;
            IsFiction = isFiction;
            RatingOfBook = ratingOfBook;
            Chapters = chapters;
            HasPictures = hasPictures;
            IsHardcover = isHardcover;
            HasTextOnBack = hasTextOnBack;
            Author = author;
            CurrentPage = currentPage;
        }


        //Methods
        public void Read()
        {

           
            CurrentPage++;
            if (CurrentPage >= NumberOfPages)
            {

                Console.WriteLine("Congratulations, you finished {0}!", Title);

                return;

            }
            else
            {
                Console.WriteLine("You turn the page.");




            }






        }


        public void Bind()
        {

            IsHardcover = true;

            Console.WriteLine("You bind the book, the book is now hardcover!");

            if (IsHardcover == true)
            {
                Console.WriteLine("The book is already hardcover!");
                return;



            }





        }
    }
}
