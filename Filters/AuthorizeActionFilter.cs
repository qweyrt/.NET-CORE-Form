using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Ctrlr.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ctrlr.Filters
 {
     public class AuthorizeActionFilter : IAuthorizationFilter
     {
         public static List<Roles> roles = new List<Roles>(){
            new Roles(){RoleID=1,RoleName="Admin"}
           ,new Roles(){RoleID=2,RoleName="User"}
        };
        readonly string _permission;
        public AuthorizeActionFilter(string permission)
        {
            _permission = permission ;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
         {
             var GetRoleID = context.HttpContext.Session.GetString("RoleID");
             if (String.IsNullOrEmpty(GetRoleID))
             {
                GetRoleID="-1";
             }
             Roles  getRole = roles.SingleOrDefault(p => p.RoleID == Int32.Parse(GetRoleID));
             if (getRole==null)
             {
                 getRole = new Roles(){RoleID=2,RoleName="User"};
             }
             if (_permission!=getRole.RoleName || getRole==null)
             {
                 context.Result = new ForbidResult();
             }
         }
     }
 } 