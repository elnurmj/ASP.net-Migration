using LessonMigration.Data;
using LessonMigration.Models;
using LessonMigration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            ValentineContent valentineContent = await _context.ValentineContents.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            List<Product> products = await _context.Products.Where(p => p.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.Images)
                .OrderByDescending(m => m.Id)
                .Take(8)
                .ToListAsync();
            List<Expert> experts = await _context.Experts
                .Where(p => p.IsDeleted == false)
                .Include(p => p.FlwExpertSection)
                .ToListAsync();
            List<Blog> blogs = await _context.Blogs
                .Where(p => p.IsDeleted == false)
                .ToListAsync();
            BlogSection blogSection = await _context.BlogSection
                .Where(p => p.IsDeleted == false)
                .FirstOrDefaultAsync();
            List<Testimonial> testimonials = await _context.Testimonials
                .Where(p => p.IsDeleted == false)
                .ToListAsync();
            List<InstaCarouselItem> instaCarouselItems = await _context.InstaCarouselItems
               .Where(p => p.IsDeleted == false)
               .ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                ValentineContent = valentineContent,
                Categories = categories,
                Products = products,
                Experts = experts,
                Blogs = blogs,
                BlogSection = blogSection,
                Testimonials = testimonials,
                InstaCarouselItems = instaCarouselItems

            };

            return View(homeVM);
        }
    }
}

