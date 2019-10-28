using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class UserCoupon
    {
        public int UserCouponId { get; set; }
        public int? UserResponseId { get; set; }
        public int? CouponCode { get; set; }
        public string MessageText { get; set; }
        public DateTime? DateGenerated { get; set; }
        public DateTime? DateRedeemed { get; set; }
    }
}
