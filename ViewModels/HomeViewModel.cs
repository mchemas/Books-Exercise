﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;

namespace Books.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
        }

        public string Title { get; set; }
        public List<Book> Books { get; set; }

    }
}
