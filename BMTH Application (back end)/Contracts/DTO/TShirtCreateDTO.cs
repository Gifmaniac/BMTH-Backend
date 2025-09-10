using Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTO
{
    public class TShirtCreateDTO
    {
        public Sizes size { get; set; }
        public string Color { get; set; }
    }
}
