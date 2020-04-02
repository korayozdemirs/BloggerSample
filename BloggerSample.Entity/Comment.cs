using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Entity
{
    public class Comment
    {
        public Comment()
        {
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        [ForeignKey("Article")]
        public Nullable<int> ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
