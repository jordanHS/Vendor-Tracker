using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string OrderDescription { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Date { get; set; } 
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string orderDescription, int qty, int price, string date)
    {
      Title = title;
      OrderDescription = orderDescription;
      Quantity = qty;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
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