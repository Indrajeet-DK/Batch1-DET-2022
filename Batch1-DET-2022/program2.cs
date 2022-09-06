//using Batch1_DET_2022.Data;
//using Batch1_DET_2022.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class CodeFStartUp
//    {

//        static void Main()
//        {
//            AddNewBook();
//            Console.ReadLine();
//        }

//        private static void addNewBook()
//        {
//            var ctx = new BookContext();
//            Book book = new Book();
//            book.BookID = 1;
//            book.BookName = "EF core";
//            book.author = "jack";
//            book.price = 100;


//            try
//            {
//                ctx.Books.Add = (book);
//                ctx.SaveChanges();
//                Console.WriteLine(" new book added successfylly");

//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message);
//            }
//        }
//    }
//}
