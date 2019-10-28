using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class UserResponse
    {
        public int UserResponseId { get; set; }
        public int? SurveyId { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public bool? OptIn { get; set; }
    }
}
