using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Enums;

namespace Contracts.Entities
{
    public class TShirt : Merchandise
    {
        public Sizes size { get; set; }
        public string Color { get; set; }

    }
}
