using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
