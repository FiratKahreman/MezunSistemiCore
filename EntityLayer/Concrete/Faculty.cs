using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string Location { get; set; }
    }
}
