using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class InvoiceFile : File
    {
        public decimal Price { get; set; }
    }
}
