using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message1 { get; set; }
        public int? Code { get; set; }
        public DateTime? DateLastTextSent { get; set; }
    }
}
