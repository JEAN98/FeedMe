using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeApi.ClasesDTO
{
    public class PeriodTypeDTO
    {
        public int PeriodId { get; set; }
       
        public string PeriodName { get; set; }
    
        public Nullable<int> Number { get; set; }
    }
}