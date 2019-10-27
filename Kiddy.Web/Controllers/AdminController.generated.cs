// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

namespace Kiddy.Web.Controllers
{
    public partial class AdminController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public AdminController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected AdminController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(Task<IActionResult> taskResult)
        {
            return RedirectToPage(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(Task<IActionResult> taskResult)
        {
            return RedirectToPagePermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Details()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Edit()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Delete()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public AdminController Actions => MVC.Admin;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Admin";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Admin";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Details = "Details";
            public readonly string Create = "Create";
            public readonly string Edit = "Edit";
            public readonly string Delete = "Delete";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Details = "Details";
            public const string Create = "Create";
            public const string Edit = "Edit";
            public const string Delete = "Delete";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
            }
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_AdminController : Kiddy.Web.Controllers.AdminController
    {
        public R4MVC_AdminController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void IndexOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Index()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Details(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DetailsOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Create()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, Microsoft.AspNetCore.Http.IFormCollection collection);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Create(Microsoft.AspNetCore.Http.IFormCollection collection)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            CreateOverride(callInfo, collection);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Edit(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id, Microsoft.AspNetCore.Http.IFormCollection collection);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Edit(int id, Microsoft.AspNetCore.Http.IFormCollection collection)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            EditOverride(callInfo, id, collection);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Delete(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DeleteOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id, Microsoft.AspNetCore.Http.IFormCollection collection);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult Delete(int id, Microsoft.AspNetCore.Http.IFormCollection collection)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            DeleteOverride(callInfo, id, collection);
            return callInfo;
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
