﻿using BloggerSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Entity
{
    public class UserDetail : IEntity
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Sex { get; set; }
        public string Vocation { get; set; }
     
    }
}
