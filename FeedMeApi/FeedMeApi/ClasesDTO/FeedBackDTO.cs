using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeApi.ClasesDTO
{
    public class FeedBackDTO
    {
        
        public int FeedBackId { get; set; }
        
        public Nullable<int> StoreId { get; set; }
        
        public Nullable<int> Face { get; set; }
        
        public string Opinion { get; set; }
        
        public Nullable<System.DateTime> CreationDate { get; set; }

    }

}