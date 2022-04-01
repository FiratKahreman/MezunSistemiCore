using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Picture
    {
        [Key]
        public int PictureId { get; set; }
        public string Description { get; set; }
        
    }
}
