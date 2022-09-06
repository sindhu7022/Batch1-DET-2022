using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach

    {
        public static void Main()
        {
            //AddNewBook();
            // DeleteBook();
            // GetAllBooks();
            //UpdateBook();
            //  AddnewCustomerandOrders();
            //  GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
           // GetAllCustomersWithOrder_EagerLoading();
                Console.ReadLine();
            

        }
        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 2;
        //    book.BookName = "EFG Core funda";
        //    book.author = "adam";
        //    book.price = 200;


        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}



        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();
        //    try
        //    {
        //        Books.BookName = " basics of EFCore";
        //        ctx.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("updated successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void DeleteBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();
        //    try
        //    {

        //        ctx.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book is removed");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void GetAllBooks()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books;
        //    foreach (var book in Books)
        //    {
        //        Console.WriteLine(book.BookName +" " );
        //    }
        //}
        private static void AddnewCustomerandOrders()
        {

            var ctx = new BookContext();
            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "sindhu";
            customer.Age = 22;

            Order ord = new Order();
            ord.Order_ID = 100;
            ord.Amount = 2000;
            ord.OrderDate = DateTime.Now;

            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("  updated successfuly");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

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
        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }
    }
