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
    public class ShapesController : ApiController
    {
        KiddyEntities db = new KiddyEntities();
        BaseController bC = new BaseController();

        // POST: api/Shapes
        public BaseResponse Post([FromBody]ShapesRegister shapesRegister)
        {
            BaseResponse baseResponse = new BaseResponse();
            if (!ModelState.IsValid)
            {
                baseResponse.Message = "Model Not Valid";
                baseResponse.statusCode = HttpStatusCode.BadRequest;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            if (!bC.validateToken(shapesRegister.userToken, shapesRegister.UserLogin))
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.Unauthorized;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            Shape shape = new Shape();
            shape.shapeName = shapesRegister.shapeName;
            shape.CreatedBy = shapesRegister.UserLogin;
            shape.Description = shapesRegister.Description;
            shape.Dimension = shapesRegister.Dimension;
            shape.CreatedOn = DateTime.Now;
            shape.ModifiedBy = "";
            shape.CreatedOn = new DateTime(1900, 01, 01);
            shape.RowStatus = false;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                baseResponse.statusCode = HttpStatusCode.BadRequest;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            baseResponse.Message = "Success Make Data";
            baseResponse.statusCode = HttpStatusCode.OK;
            baseResponse.aknowledge = 1;
            return baseResponse;
        }

        // PUT: api/Shapes/5
        public BaseResponse Put([FromBody]ShapesUpdate shapesUpdate)
        {
            BaseResponse baseResponse = new BaseResponse();

            if (!bC.validateToken(shapesUpdate.userToken, shapesUpdate.UserLogin))
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.Unauthorized;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            var updateShapes = db.Shapes.Where(x => x.ID == shapesUpdate.ID && x.RowStatus != true).FirstOrDefault();
            if (updateShapes != null)
            {
                updateShapes.shapeName = shapesUpdate.shapeName;
                updateShapes.Description = shapesUpdate.Description;
                updateShapes.ModifiedOn = DateTime.Now;
                updateShapes.ModifiedBy = shapesUpdate.UserLogin;
                updateShapes.RowStatus = shapesUpdate.RowStatus;

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }
            }
            else
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.BadRequest;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            baseResponse.Message = "Success";
            baseResponse.statusCode = HttpStatusCode.OK;
            baseResponse.aknowledge = 1;
            return baseResponse;
        }

        // DELETE: api/Shapes/5
        public BaseResponse Delete([FromBody]ShapesID shapesID)
        {
            BaseResponse baseResponse = new BaseResponse();

            if (!bC.validateToken(shapesID.userToken, shapesID.UserLogin))
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.Unauthorized;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            var updateShapes = db.Shapes.Where(x => x.ID == shapesID.ID && x.RowStatus != true).FirstOrDefault();
            if (updateShapes != null)
            {
                updateShapes.RowStatus = true;


                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }
            }
            else
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.BadRequest;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            baseResponse.Message = "Success";
            baseResponse.statusCode = HttpStatusCode.OK;
            baseResponse.aknowledge = 1;
            return baseResponse;

        }
    }
}
