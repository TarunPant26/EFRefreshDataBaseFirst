using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRefreshDBFirstApproch
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DBFirstEntities();

            var post = new Post()
            {
                Title = "FirstPost",
                DatePublished = DateTime.Now,
                Body = "This is Database First Blog",
                PostID = 1
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
