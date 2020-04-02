using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Browser { get; set; }
        public string IP { get; set; }

        [ForeignKey("Role")]
        public Nullable<int> RoleId { get; set; }
        public virtual Role Role { get; set; }

        [ForeignKey("UserDetail")]
        public Nullable<int> UserDetailId { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
