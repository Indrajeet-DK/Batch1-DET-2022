using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach
    {

        static void Main()
        {
            //Updatebook();
            // DeleteBook();
            //AddNewBook();
            // GetAllBooks();
            // AddnewcustomerAndOrder();
          //  GetAllCustomersWithOrder_ExplicitLoading();
            //GetAllCustomersWithOrder_EagerLoading();
            Console.ReadLine(); 
        }


        ////------------------------------------------------Add
        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 3;
        //    book.BookName = "The Run Machine";
        //    book.author = "virat";
        //    book.price = 1000;





        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" new book added successfylly");

        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}



        ////------------------------------delete

        //private static void DeleteBook()
        //{
        //   var ctx = new BookContext();

        //    try
        //    {
        //        Book book = new Book();
        //        book.BookID = 1;

        //        ctx.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //    }



        ////--------------------------------------update


        //public static void Updatebook()
        //{
        //    var ctx = new BookContext();
        //    var Book = ctx.Book.Where(e => e.BookID == 3).SingleOrDefault();

        //    Book.author = "kohli";
        //    ctx.Update(Book);
        //    ctx.SaveChanges();
        //    Console.WriteLine("updated");
        //}

        ////--------------------------------get all books



        //private static void GetAllBooks()
        //{
        //    var ctx = new BookContext();
        //    var books = ctx.Book;

        //    foreach (var book in books) 
        //    {
        //        Console.WriteLine(book.BookName);
        //    }
        //}



        private static void AddnewcustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "indrajeet";
            customer.Age = 21;

            Order ord = new Order();
            ord.Order_ID = 777;
            ord.Amount = 5000;
            ord.OrderDate = DateTime.Now;

            //List<Order> myorders = new List<Order>();
            //myorders.Add(ord);
            //customer.Orders = myorders;

            ord.cust = customer;
            try
            {
                //ctx.Customer.Add(customer); //Orders
                ctx.Order.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("Customer and order is created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }

        ////----------------------------------------------------------------
        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customer.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //--------------------------------------------

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customer;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}



