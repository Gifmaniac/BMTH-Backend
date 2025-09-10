using Contracts.Enums;

namespace APIContracts.DTO
{
    public class TShirtCreate
    {
        public Sizes Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
    }
}
