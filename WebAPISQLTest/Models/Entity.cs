using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class Entity
    {
        public int EntityId { get; set; }
        public int? CategoryId { get; set; }
        public string EntityName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
