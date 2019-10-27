using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Kiddy.Models.Entity;
using Kiddy.Models;

namespace Kiddy.Controllers
{
    public class GetAllShapesController : BaseController
    {
        private KiddyEntities db = new KiddyEntities();
        BaseController bC = new BaseController();

        // GET: api/GetAllShapes
        public IQueryable<Shape> GetShapes([FromBody]UserToken userToken)
        {
            List<Shape> result = new List<Shape>();
            if (bC.validateToken(userToken.AccessToken, userToken.UserID))
            {
                result = db.Database.SqlQuery<Shape>("SELECT * FROM SHAPES").ToList();
            }
            return result.AsQueryable();
        }

        // GET: api/GetAllShapes/5
        [ResponseType(typeof(Shape))]
        public ShapesResponse GetShapes([FromBody]ShapesID shapesID)
        {
            ShapesResponse shape = new ShapesResponse();
            if (!bC.validateToken(shapesID.userToken, shapesID.UserLogin))
            {
                shape.Message = "ERROR";
                shape.statusCode = HttpStatusCode.Unauthorized;
                shape.aknowledge = 0;
                return shape;
            }
            Shape dbShape = db.Shapes.Where<Shape>(x=> x.ID == shapesID.ID).OrderByDescending(x => x.ID).FirstOrDefault();
            if (shape != null)
            {
                shape.shapeName = dbShape.shapeName;
                shape.Description = dbShape.Description;
                shape.Dimension = dbShape.Dimension;
                shape.statusCode = HttpStatusCode.OK;
                shape.aknowledge = 1;
                shape.Message = "Success Get Data";
                return shape;
            }

            shape.statusCode = HttpStatusCode.BadRequest;
            shape.aknowledge = 0;
            shape.Message = "Failed Get Data";
            return shape;
        }

    }
}