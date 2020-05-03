using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_2
{

    class Book
    {


        public Book() { }
        public enum Title
        {
            ужасы,
            боевик,
            приключения,
            юмор,
            фантастика
        };

        string Author;
        string Name;
        Title title = new Title();






        public void SetTitle(int a)
        {


            if (a < 1 || a > 5)
            {
                throw new ArgumentException();

            }
            this.title = (Title)(--a);



        }
        public Title GetTitle()
        {
            return this.title;
        }



        public void SetName(string Name)
        {
            if (Name == "")
            {
                throw new ArgumentException();
            }
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }


        public void SetAuthor(string Author)
        {
            if (Author == "")
            {
                throw new ArgumentException();
            }
            this.Author = Author;
        }
        public string GetAuthor()
        {
            return this.Author;
        }
    }
}
