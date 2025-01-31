using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public PartnerType TypeName { get; set; }
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Addres { get; set; }
        public long INN { get; set; }
        public int Rank { get; set; } 
        public string? Logo { get; set; }

    }
}
