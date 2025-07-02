using CustomAuthenticationFilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationFilterDemo.DataAccess
{
    public class UserService
    {
        UserDBContext context_ref;

        public UserService()
        {
            context_ref = new UserDBContext();
        }

        public List<UserDetails> GetUsers()
        {
            return context_ref.Users.ToList();
        }

        public bool AuthenticateUser(UserDetails enteredData)
        {
            UserDetails user = context_ref.Users.FirstOrDefault(u=>u.Name == enteredData.Name && u.Passowrd == enteredData.Passowrd);

            return user == null ? false:true;
        }
    }
}