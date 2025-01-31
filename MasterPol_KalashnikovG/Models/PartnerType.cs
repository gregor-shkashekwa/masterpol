using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Models
{
    public class PartnerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Partner> Partners { get; set; }
    }
}
