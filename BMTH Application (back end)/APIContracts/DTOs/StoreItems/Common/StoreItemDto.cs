using System.Diagnostics;
using System.Xml.Linq;

namespace APIContracts.DTOs.StoreItems.Common
{
    public class StoreItemDto
    {
        public StoreItemDto(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
    }
}
