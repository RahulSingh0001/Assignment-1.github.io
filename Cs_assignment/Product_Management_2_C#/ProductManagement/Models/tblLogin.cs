//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblLogin
    {
        public int Id { get; set; }
        public string username { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string password { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Id")]
        [Required(ErrorMessage = "Email Id required")]
        public string emailid { get; set; }
    }
}