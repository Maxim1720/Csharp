using System;
using System.Text;

namespace Laba6_2
{
    class Program
    {
        static void Main()
        {

        Up:
            Console.Write("Кол-во книг:");
            Book[] books = null;
            try
            {
                books = new Book[int.Parse(Console.ReadLine())];
            }
            catch (FormatException)
            {
                Console.WriteLine("----\nТребуется числовой ввод\n----");
                Console.ReadKey();
                Console.Clear();
                goto Up;
            }
            InitBooks(books);
            BookFillInf(books);
            
            int n;
        Up2:
            try {
                Console.Write("Кол-во наборов:");
                n = int.Parse(Console.ReadLine()); 
            }
            catch (FormatException)
            {
                Console.WriteLine("----\nТребуется числовой ввод\n----");
                Console.ReadKey();
                Console.Clear();
                goto Up2;
                
            }
            
            
            Kit[] kits = new Kit[n];

            for (int i = 0; i < n; i++)
            {
                kits[i] = new Kit();
            }




            int j = 0;
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].GetTitle() == (Book.Title)k)
                    {
                        kits[j++].PutBook(books[i]);

                        if (j == kits.Length)
                        {
                            j = 0;
                        }
                    }

                }
            }

            if (kits.Length > books.Length)
            {
                for (int i = 0; j < kits.Length; i++, j++)
                {
                    kits[j] = kits[i];
                }
            }

            for(int i = 0; i < kits.Length-1;i++)
            {
                for(int k = i + 1; k < kits.Length; k++)
                {
                    if (kits[i].GetKit().Length > kits[k].GetKit().Length)
                    {
                        kits[k].PutBook(OtherTitle(kits[k],kits[i]));
                        i++;
                    }
                }
            }


            for (int i = 0; i < kits.Length; i++)
            {
                Console.WriteLine("{0} Набор:", i + 1);
                for (int k = 0; k < kits[i].GetKit().Length; k++)
                {
                    Console.WriteLine("\t\"{0}\" {1} - {2},", kits[i].GetKit()[k].GetName(), kits[i].GetKit()[k].GetAuthor(), kits[i].GetKit()[k].GetTitle());
                }
                Console.WriteLine();
            }

            

        }
        static void InitBooks(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
            }
        }
        static void BookFillInf(Book[] kniga)
        {
            int i = 0;
        Begin:
            try
            {
                for (; i < kniga.Length; i++)
                {

                    Console.WriteLine("\t\t\t\t{0} Книга", i + 1);
                    Console.Write("Автор книги:");
                    kniga[i].SetAuthor(Console.ReadLine());
                    Console.Write("Название книги:");
                    kniga[i].SetName(Console.ReadLine());
                    Console.Write("Выберите тематику книги\n\n1.ужасы\n2.боевик\n3.приключения\n4.юмор\n5.фантастика\n\n>>");
                    kniga[i].SetTitle(Int32.Parse(Console.ReadLine()));
                    Console.Clear();
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("---\nВведите число\n---");
                Console.ReadKey();
                Console.Clear();
                goto Begin;


            }
            catch (ArgumentException)
            {

                Console.WriteLine("---\nПовторите вводsd\n---");
                Console.ReadKey();
                Console.Clear();
                goto Begin;

            }




        }

        static Book OtherTitle(Kit OurKit, Kit CheckKit)
        {
            for (int i = 0; i < OurKit.GetKit().Length; i++)
            {
                for (int j = 0; j < CheckKit.GetKit().Length; j++)
                {
                    if(OurKit.GetKit()[i].GetTitle() != CheckKit.GetKit()[j].GetTitle())
                    {
                        return CheckKit.GetKit()[j];
                    }
                }
            }
            return null;
        }


    }
}


