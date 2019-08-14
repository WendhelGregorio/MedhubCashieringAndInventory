using MedhubCashieringAndInventory.Domain.Infrastructure;
using MedhubCashieringAndInventory.Domain.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedhubCashieringAndInventory.Domain.Models
{
     public class User : BaseModel
        {
            public string Email { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string PassWord { get; set; }
            
            public int LoginTrial { get; set; }

            public Status UserStatus { get; set; }

            public string IsAdmin { get; set; }

        }
}
