//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kiddy.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token
    {
        public int ID { get; set; }
        public string AccessToken { get; set; }
        public int UsersID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool RowStatus { get; set; }
    }
}
