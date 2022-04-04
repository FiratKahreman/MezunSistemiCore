using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
    public class Grad
    {
        [Key]
        public int GradId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool Working { get; set; } // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public bool GotCard { get; set; }

    }
}
