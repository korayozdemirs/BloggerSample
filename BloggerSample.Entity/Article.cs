using BloggerSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Entity
{
    public class Article : IEntity
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int NumberofReadings { get; set; }
        public int NumberofLikes { get; set; }
        public bool IsRelease { get; set; }

        [ForeignKey("Category")]
        public Nullable<int> CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
