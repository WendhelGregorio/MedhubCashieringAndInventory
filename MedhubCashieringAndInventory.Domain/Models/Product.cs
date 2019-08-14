using MedhubCashieringAndInventory.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedhubCashieringAndInventory.Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Barcode { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }
    }
}
