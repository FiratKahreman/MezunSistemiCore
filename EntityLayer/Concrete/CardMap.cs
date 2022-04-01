using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class CardMap
    {
        [Key]
        public int CardMapId { get; set; }
        public string Coordinates { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
    }
}
