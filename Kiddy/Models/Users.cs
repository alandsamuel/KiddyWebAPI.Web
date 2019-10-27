using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiddy.Models
{
    //public partial class User
    //{
    //    public int ID { get; set; }
    //    public string UserID { get; set; }
    //    public string password { get; set; }
    //    public string CreatedBy { get; set; }
    //    public System.DateTime CreatedOn { get; set; }
    //    public string ModifiedBy { get; set; }
    //    public System.DateTime ModifiedOn { get; set; }
    //    public bool RowStatus { get; set; }
    //}

    public class UsersLogin
    {
        [Required]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$")]
        public string UserID { get; set; }

        [Required]
        [RegularExpression(@"(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))(?=(1)(?=.*\d)|.*[^A-Za-z0-9])^.*$")]
        public string password { get; set; }
    }

    public class UsersID : Base.BaseRequest
    {
        public int ID { get; set; }
    }

    public class UsersRegister
    {
        [Required]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$")]
        public string UserID { get; set; }

        [Required]
        [RegularExpression(@"(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))(?=(1)(?=.*\d)|.*[^A-Za-z0-9])^.*$")]
        public string password { get; set; }

        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }
    }

    public class UserUpdate : Base.BaseRequest
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$")]
        public string UserID { get; set; }
        [Required]
        [RegularExpression(@"(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))(?=(1)(?=.*\d)|.*[^A-Za-z0-9])^.*$")]
        public string password { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool RowStatus { get; set; }
    }

    public class UserResponse : BaseResponse
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string password { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool RowStatus { get; set; }
        public string Email { get; set; }
    }
}