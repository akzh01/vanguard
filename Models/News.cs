﻿using System;
namespace Vanguard.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public News()
        {
        }
    }
}
