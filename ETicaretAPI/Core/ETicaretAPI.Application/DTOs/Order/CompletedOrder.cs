using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTOs.Order
{
    public class CompletedOrderDTO
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
    }
}
