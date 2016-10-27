using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chatter.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Messages { get; set; }
        public DateTime Timestamp  { get; set; }
}
}