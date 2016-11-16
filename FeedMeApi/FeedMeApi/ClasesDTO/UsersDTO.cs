using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeApi.ClasesDTO
{
    public class UsersDTO
    {
            
            public int UserId { get; set; }
            
            public string Email { get; set; }
            
            public string Passwordkey { get; set; }
            
            public Nullable<int> RoleId { get; set; }
            
            public Nullable<int> StoreId { get; set; }

        }
    }