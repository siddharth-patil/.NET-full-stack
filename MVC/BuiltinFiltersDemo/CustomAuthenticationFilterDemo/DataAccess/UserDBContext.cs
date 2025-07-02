using CustomAuthenticationFilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomAuthenticationFilterDemo.DataAccess
{
    public class UserDBContext:DbContext
    {
        public UserDBContext():base("UserDBContext")
        {
            
        }
        
        public DbSet<UserDetails> Users {  get; set; }
    }
}