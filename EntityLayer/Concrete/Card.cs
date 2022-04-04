using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Discount Discount { get; set; }
        public string GradType { get; set; } 

    }
}
