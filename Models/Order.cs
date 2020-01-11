using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date {get; set; }
        public int Id { get; }

        public Order(string description, int price, string date)
        {
            Title = orderTitlle;
            Description = description;
            Price = orderPrice;
            Date = orderDate;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}