using System;

namespace BookStoreApp.Models
{
    public class Purchase
    {
        public Guid PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public Guid BookId { get; set; }
        public DateTime date { get; set; }
    }
}