using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kiddy.Models.Base;

namespace Kiddy.Models
{
    //public partial class Shape
    //{
    //    public int ID { get; set; }
    //    public string shapeName { get; set; }
    //    public string Dimension { get; set; }
    //    public string Description { get; set; }
    //    public string CreatedBy { get; set; }
    //    public System.DateTime CreatedOn { get; set; }
    //    public string ModifiedBy { get; set; }
    //    public System.DateTime ModifiedOn { get; set; }
    //    public bool RowStatus { get; set; }
    //}

    public class ShapesResponse : BaseResponse
    {
        public string shapeName { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
    }

    public class ShapesID : BaseRequest
    {
        public int ID { get; set; }
    }

    public class ShapesRegister : BaseRequest
    {
        public string shapeName { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
    }

    public  class ShapesUpdate : BaseRequest
    {
        public int ID { get; set; }
        public string shapeName { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool RowStatus { get; set; }
    }
}