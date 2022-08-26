namespace LibraryCatalog.Models
{
    public class UpdateBookRequestModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }
        public string PurchaseDate { get; set; }
    }
}
