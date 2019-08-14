using MedhubCashieringAndInventory.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedhubCashieringAndInventory.Domain.Models
{
    class SaleItem : BaseModel
    {
        public Guid? ProductId { get; set; }

        public Guid? SaleId { get; set; }

        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }


    }
}
