using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "UserModelname")]
        public string UserName{ get;set;}
 
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(100,ErrorMessage = "The{0} must be at least {2} characters long.",MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name= "Password")]
        public string Password{ get;set;}
 
        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name= "Confirmpassword")]
        [Compare("Password",ErrorMessage = "Thepassword and confirmation password do not match.")]
        public string ConfirmPassword{ get;set;} 
    }
}