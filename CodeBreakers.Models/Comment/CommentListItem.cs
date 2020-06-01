using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreakers.Models.Comment
{
    public class CommentListItem
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }
}
