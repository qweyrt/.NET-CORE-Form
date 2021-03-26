using System;
using System.ComponentModel.DataAnnotations;
namespace Ctrlr.Models
{
    public class User
    {
        public int UserID { get; set;}
        [Required]
        public String UserName { get; set;}
        [Required]
        public String Password { get; set;}
        public string RoleID { get; set;}
        public string FullName()
        {
            return this.UserName;
        }
    }
}
