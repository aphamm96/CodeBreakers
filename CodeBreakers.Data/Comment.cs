using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreakers.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey("Author")]
        [Required]
        public Guid UserId { get; set; }
        public virtual User Author { get; set; }
    }
}
