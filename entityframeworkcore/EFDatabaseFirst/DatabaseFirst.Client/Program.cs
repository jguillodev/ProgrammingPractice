using DatabaseFirst.ScaffoldModels;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Linq;
using System.Threading;

namespace DatabaseFirst.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext()) 
            {
                //Create and save a new Blog
                Console.WriteLine("Enter a name for a new Blog");
                var name = Console.ReadLine();

                var blog = new Blogs { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var OrderBlogsByName = db.Blogs.OrderBy(b => b.Name);
                Console.WriteLine("All blogs in the Database: ");
                foreach (var item in OrderBlogsByName) 
                {
                    Console.WriteLine(item.Name);
                }

            }
        }
    }
}
