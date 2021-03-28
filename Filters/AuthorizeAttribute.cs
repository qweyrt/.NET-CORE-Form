using System;
using Microsoft.AspNetCore.Mvc;

namespace Ctrlr.Filters
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(string permission)
        : base(type: typeof(AuthorizeActionFilter))
        {
            Arguments= new Object[] {permission};
        }
    }
}