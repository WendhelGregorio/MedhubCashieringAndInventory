using MedhubCashieringAndInventory.Domain.Infrastructure;
using MedhubCashieringAndInventory.Domain.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedhubCashieringAndInventory.Domain.Models
{
    public class Delivery : BaseModel
    {
        public DateTime Date { get; set; }

        public Guid? UserId { get; set; }

        public Status Status { get; set; }

    }
}
