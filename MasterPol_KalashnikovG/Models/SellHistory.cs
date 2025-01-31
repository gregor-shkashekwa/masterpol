using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Models
{
    public class SellHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
        public int Count { get; set; } = 1;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
