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
        public ICollection<Message> Entry { get; set; }
        string Time = Timestamp(DateTime.Now);
        public static string Timestamp(DateTime value)
        {
            return value.ToString("YYMMDDHHmmss");
        }
}
}