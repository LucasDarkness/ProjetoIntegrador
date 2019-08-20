using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Database.Entity
{
    public class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        public int blogId { get; set; }
        public string Url { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
