using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        [Key]
        public int DiscountsId { get; set; }
        public int UsedDiscountsOnMonth { get; set; }
        public int UsedDiscountsOnAll { get; set; }
        public int RemainingDiscounts { get; set; }
    }
}
