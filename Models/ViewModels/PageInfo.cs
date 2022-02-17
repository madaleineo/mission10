﻿using System;

namespace onlinebookstore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }

        public int BooksPerPage { get; set; }

        public int CurrentPage { get; set; }

        //figure out how many pages are needed

        public int TotalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
