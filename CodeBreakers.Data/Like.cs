﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreakers.Data
{
    public class Like
    {
        [ForeignKey("Author")]
        [Required]
        public Guid UserId { get; set; }
        public virtual User Author { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

    }
}