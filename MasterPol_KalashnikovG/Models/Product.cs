using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Models
{
    public class Product
    {
        public int Id { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public int MinPrice { get; set; }
        public List<SellHistory> SellHistories {get; set; }
    }
}
