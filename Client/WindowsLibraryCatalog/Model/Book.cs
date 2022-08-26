using System;

namespace WindowsFormsApp1
{
    internal class Book
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }
        public string PurchaseDate { get; set; }
    }
}
