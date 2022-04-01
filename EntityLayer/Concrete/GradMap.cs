using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GradMap
    {
        [Key]
        public int GradMapId { get; set; }
        public string Coordinates { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
    }
}
