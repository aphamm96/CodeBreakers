﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreakers.Data
{
    public class Post
    {
       [Key]
        public int PostId { get; set; }
        
        [Required]
            public string Title { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Your Post")]
        public string PostText { get; set; }
        [Required]
        public User PostAuthor { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
      //  public DateTimeOffset ModifiedUtc { get; set; }
    }
}
