﻿
using LessonMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail Detail { get; set; }
        public ValentineContent ValentineContent { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Blog> Blogs { get; set; }
        public BlogSection BlogSection { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<InstaCarouselItem> InstaCarouselItems { get; set; }
    }
}

