using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityCourseResultManagementSystem.Models;
using Vereyon.Web;

namespace UniversityCourseResultManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        ProjectDBContext Db = new ProjectDBContext();
        // GET: Department
        public ActionResult SaveDepartment()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SaveDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                Db.Departments.Add(department);
                Db.SaveChanges();
                FlashMessage.Confirmation("Department Successfully Saved");
            }
            return View();
        }

        public JsonResult IsCodeExits(string departmentCode)
        {
            var dept = Db.Departments.ToList();
            if (!dept.Any(x => x.DepartmentCode.ToLower() == departmentCode.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ShowAllDepartment()
        {
            var dept = Db.Departments.ToList();
            return View(dept);
        }

        public ActionResult ViewDetails()
        {
            ViewBag.DepartmentIds = new SelectList(Db.Departments, "DepartmentId", "DepartmentCode");
            return View();
        }
    }
}