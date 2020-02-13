using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDeclaration.Core.Models
{
    public class StoreModel
    {
        public int StoreId { get; set; }
        public int StoreType { get; set; }
        public string Name { get; set; }
        public string FullName { get { return StoreId + "." + Name; } }
    }
}
