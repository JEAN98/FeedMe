using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIDesignFeedme.Models
{
    public class ChangeCoupon
    {
         
       
        public int CouponId { get; set; }
 
        public Nullable<int> Discount { get; set; }
    
        public string DiscountDescription { get; set; }
     
        public Nullable<int> ActivationStatus { get; set; }

       
        public string Email { get; set; }
     
        public Nullable<int> Amount { get; set; }
    
        public Nullable<System.DateTime> CreateDateTime { get; set; }
      
        public Nullable<int> StoreId { get; set; }
        
        public Nullable<int> PeriodId { get; set; }
       
        //public virtual PeriodType PeriodType { get; set; }
       
        //public virtual Store Store { get; set; }
     
        //public virtual User User { get; set; }
    }
}

