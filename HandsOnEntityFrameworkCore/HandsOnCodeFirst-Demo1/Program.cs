using System;
using HandsOnCodeFirst_Demo1.DBAccess;
using HandsOnCodeFirst_Demo1.Entities;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnCodeFirst_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(MyContext db=new MyContext())
            {
                //add record to product table
                //Product product = new Product() { Pname = "Mouse", Price = 450 };
                //db.Products.Add(product);
                //db.SaveChanges();//call every time while updating table 
                //fetch record
                //using primary key value
                Product p = db.Products.Find(10);
                if (p != null)
                    Console.WriteLine($"{p.Pid} {p.Pname} {p.Price}");
                else
                    Console.WriteLine("Invalid Product id");
                //serch product using non primary key column
                p = db.Products.SingleOrDefault(i => i.Pname == "Mouse");
                if (p != null)
                    Console.WriteLine($"{p.Pid} {p.Pname} {p.Price}");
                else
                    Console.WriteLine("Invalid Product Name");
                //return multiple records
                List<Product> list = db.Products.ToList();
                list = (from i in list
                        where i.Price > 100
                        select i).ToList();
                list = db.Products.Where(i => i.Price > 100).ToList();
                foreach(var item in list)
                    Console.WriteLine($"{item.Pid} {item.Pname} {item.Price}");
            }
        }
    }
}
