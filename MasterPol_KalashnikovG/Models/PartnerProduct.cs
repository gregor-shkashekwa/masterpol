using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Models
{
    public class PartnerProduct
    {
        public Product ProductName { get; set; }
        public Partner PartnerName { get; set; }
        public int Kolvo { get; set; }
        public DateTime date { get; set; }
    }
}
