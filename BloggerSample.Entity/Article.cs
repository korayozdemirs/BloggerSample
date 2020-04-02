using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int NumberofReadings { get; set; }
        public int NumberofLikes { get; set; }

    }
}
