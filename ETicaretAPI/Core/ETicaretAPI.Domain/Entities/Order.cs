using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        //public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public string OrderCode { get; set; }

        public Basket Basket { get; set; }
        //public ICollection<Product> Products { get; set; }
        //public Customer Customer { get; set; }
        public CompletedOrder CompletedOrder { get; set; }
    }
}
