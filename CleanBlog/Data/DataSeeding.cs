using CleanBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Data
{
    public class DataSeeding
    {
        private readonly BlogDbContext _context;

        public DataSeeding(BlogDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (_context.Database.GetPendingMigrations().Count() == 0)
            {
                if (_context.Abouts.Count() == 0)
                {
                    _context.Abouts.AddRange(About);
                  
                }
                if (_context.Blogs.Count() == 0)
                {
                    _context.Blogs.AddRange(Blogs);
                }
                _context.SaveChanges();
            }
        }

        public About[] About =
        {
            new About() {
                Title = "Haqqimizda.",
                Description = "",
                PhotoURL = "",
                CreatedDate = DateTime.Now,
            }
        };

        public Blog[] Blogs =
        {
            new Blog() {
                Title = "Basliq 1",
                SubTitle = "Basliq 1 ucun subtitle",
                Description= "Soz",
                PhotoURL= "https://cdn.pixabay.com/photo/2022/05/31/14/17/sea-7233669_960_720.jpg",
                CreatedDate= DateTime.Now,
            },
            new Blog() {
                Title = "Basliq 2",
                SubTitle = "Basliq 2 ucun subtitle",
                Description= "Soz",
                PhotoURL= "https://cdn.pixabay.com/photo/2022/04/09/18/21/rocky-coast-7122028_960_720.jpg",
                CreatedDate= DateTime.Now,
            },
            new Blog() {
                Title = "Basliq 3",
                SubTitle = "Basliq 3 ucun subtitle",
                Description= "Soz",
                PhotoURL= "https://cdn.pixabay.com/photo/2021/11/30/08/24/strawberries-6834750_960_720.jpg",
                CreatedDate= DateTime.Now,
            },
        };
    }
}
