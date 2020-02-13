using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDeclaration.Core.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Supplier { get; set; }
        public string Manufacturer { get; set; }
        public int ExpiryDay { get; set; }
        public string ManufacturerCountry { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int DeclarationType { get; set; }
        public int Amount { get; set; }
    }
}
