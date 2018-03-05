using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab_2.Models;

namespace Lab_2.Controllers
{
    public class intController : Controller
    {
        // GET: int
        public ActionResult Index()
        {
            var path = @"C:\Users\Luis\Downloads\document.json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<ArbolInt>(contenido);
            DataInt.Instance.a1 = arbol;
            var cadena = JsonConvert.SerializeObject(arbol);

            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // GET: int/Details/5
        public ActionResult Details(int id)
        {
            TempData["inorden"] = DataInt.Instance.a1.inorderRec(DataInt.Instance.a1);
            TempData["preorden"] = DataInt.Instance.a1.preorderRec(DataInt.Instance.a1);
            TempData["postorden"] = DataInt.Instance.a1.postorderRec(DataInt.Instance.a1);

            return View("index");
            
        }

        // GET: int/Create
        public ActionResult Create1(string id)
        {
            ArbolInt aux = new ArbolInt();
            aux.valor = int.Parse(id);
            DataInt.Instance.a1.Insert(DataInt.Instance.a1, aux);
            var cadena = JsonConvert.SerializeObject(DataInt.Instance.a1);
            var tra = DataInt.Instance.a1;
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista




            return View();
        }

        // POST: int/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: int/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: int/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: int/Delete/5
        public ActionResult Delete1(string id)
        {
            ArbolInt aux = new ArbolInt();         
            
            aux.valor = int.Parse(id);
            var arbol = DataInt.Instance.a1;

            bool v1 = DataInt.Instance.a1.delete(DataInt.Instance.a1, aux);
            var cadena = JsonConvert.SerializeObject(DataInt.Instance.a1);
            var tra = DataInt.Instance.a1;
            if (v1)
            {
                TempData["Succes"] = "Se elimino el nodo" + " " + id;
            }
            else
            {
                TempData["Succes"] = "El nodo ingresado no existe(o no sirve mi eliminacion)";
            }
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // POST: int/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
