using CRUD_With_CF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
   
        //
        // GET: /Emp/

        public class CRUDController : Controller
        {
            private Emp_Context db = new Emp_Context();

            //
            // GET: /CRUD/

            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(Emp emp)
            {
                if (ModelState.IsValid)
                {
                    db.Emp.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("Display");
                }
                return View(emp);
            }

            public ActionResult Edit(Int32 id)
            {
                Emp emp = db.Emp.Find(id);
                if (emp == null)
                {
                    Response.Write("There is some error in fetching the data");
                }
                return View(emp);

            }
            [HttpPost]
            public ActionResult Edit(Emp emp)
            {

                if (ModelState.IsValid)
                {
                    db.Entry(emp).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Display");
                }
                return View(emp);
            }

            public ActionResult Delete(Int32 id)
            {
                Emp emp = db.Emp.Find(id);
                if (emp == null)
                {
                    Response.Write("There is some error in fetching data");
                }
                return View(emp);
            }
            [HttpPost, ActionName("Delete")]
            public ActionResult DeleteConfirmed(Int32 id)
            {
                Emp emp = db.Emp.Find(id);
                db.Emp.Remove(emp);
                db.SaveChanges();
                return RedirectToAction("Display");
            }

            public ActionResult Display()
            {
                return View(db.Emp.ToList());
            }
            [HttpPost]//just to check
            public ActionResult Display(List<Emp> employeee, FormCollection form)
            {

                return View(db.Emp.ToList());
            }


            public ActionResult GetData(Int32 id)
            {
                Emp emp = db.Emp.Find(id);
                if (emp == null)
                {
                    Response.Write("There is Some error in fetching data ");
                }
                return View(emp);
            }

            public ActionResult Country()
            {
                ViewData["Country"] = db.Country.ToList();
                return View();
                // db.Country.Select(x => new Country { CntName }).ToList();
                // var selecteddata = db.Country.Where(data => inputValues.Contains(data.CntName)).Distinct();
                //db.Country.Select("EmpName").ToList();
                //db.Country.Select(item => new Country
                //{
                //    CntName = item.CntName,
                //}).ToList();

            }


            public JsonResult GetStates(int id)
            {

                var q = from p in db.State
                        where p.CntCode == id
                        select p;
                return Json(q);

                // return Json(new SelectList(states, "Value", "Text"));
            }


            public JsonResult GetCity(int id)
            {

                var q = from p in db.City
                        where p.StaCode == id
                        select p;
                return Json(q);
            }

      

 
}
