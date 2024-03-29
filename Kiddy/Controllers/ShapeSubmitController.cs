﻿using System;
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
using Kiddy.Models.Base;
using Kiddy.Common;


namespace Kiddy.Controllers
{
    public class ShapeSubmitController : BaseController
    {
        KiddyEntities db = new KiddyEntities();
        public List<UsersShapeSave> GetusersShapeSaves([FromBody]BaseRequest request)
        {
            var userID = db.Users.Where(x => x.UserID == request.UserLogin && x.RowStatus != true).First();
            var GetShapesID = db.UserSavedDatas.Where(x => x.UsersID == userID.ID && x.RowStatus != true).ToList();

            List<UsersShapeSave> shapeSaves = new List<UsersShapeSave>();

            return shapeSaves;
        }

        // POST: api/ShapeSubmit
        public shapeSubmitResponse Post([FromBody]shapesSubmitRequest submit)
        {
            shapeSubmitResponse response = new shapeSubmitResponse();
            response.listShapes = new List<shapeCalculateAreas>();
            string[] submitValue = submit.UserInput.Split('|');
            if (submitValue.Count() == 2)
            {
                List<ShapesArea> shapes = db.Shapes.Where(x => x.needParameter == submitValue.Count() && x.RowStatus != true).Select(x => new ShapesArea
                {
                    shapeName = x.shapeName,
                    Description = x.Description,
                    Dimension = x.Dimension,
                    NeedParameter = x.needParameter
                }).ToList();

                foreach (var item in shapes)
                {

                    shapeCalculateAreas areas = new shapeCalculateAreas();
                    Areanator calculate = new Areanator();

                    areas.Area = calculate.sumArea(item.Dimension, submit.UserInput);
                    areas.shapeName = item.shapeName;
                    areas.Description = item.Description;
                    areas.Dimension = item.Dimension;
                    

                    response.listShapes.Add(areas);
                }
            }

            return response;

        }

    }
}
