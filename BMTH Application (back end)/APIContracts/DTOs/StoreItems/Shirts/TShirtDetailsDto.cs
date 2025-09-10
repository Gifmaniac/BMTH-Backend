using APIContracts.DTOs.StoreItems.Common;
using Contracts.Enums;

namespace APIContracts.DTOs.StoreItems.Shirts
{
    public class TShirtDetailsDto : StoreItemDto
    {
        public TShirtDetailsDto(int id, string name, decimal price, int quantity) : base(id, name, price, quantity)
        {
        }

        public Sizes Size { get; set; }
        public string Color { get; set; }
    }
}
