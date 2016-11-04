//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeedMeApi
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public Nullable<int> Discount { get; set; }
        public string DiscountDescription { get; set; }
        public Nullable<int> ActivationStatus { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Email { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> PeriodId { get; set; }
    
        public virtual PeriodType PeriodType { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
