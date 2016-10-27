using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chatter.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<User> Following { get; set; }
        public ICollection<User> Followers { get; set; }

        [ForeignKey("Message")]
        public int MessageID { get; set; }
        public virtual Message Message { get; set; }
    }

}