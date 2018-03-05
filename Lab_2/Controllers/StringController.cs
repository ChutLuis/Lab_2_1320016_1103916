using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab_2.Models;
using System.IO;

namespace Lab_2.Controllers
{
    public class StringController : Controller
    {
        // GET: String
        public ActionResult Index()
        {
            
            var path = @"C:\Users\Luis\Downloads\document(1).json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<ArbolString>(contenido);
            DataString.Instance.a1=arbol;
            var cadena = JsonConvert.SerializeObject(arbol);
            
            


            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // GET: String/Details/5
        public ActionResult Details(int id)
        {
            TempData["inorden"] = DataString.Instance.a1.inorderRec(DataString.Instance.a1);
            TempData["preorden"] = DataString.Instance.a1.preorderRec(DataString.Instance.a1);
            TempData["postorden"] = DataString.Instance.a1.postorderRec(DataString.Instance.a1);

            return View("index");
        }

        // GET: String/Create
        public ActionResult Create1(string cadena1)
        {
            ArbolString aux = new ArbolString();
            aux.valor = cadena1;
            DataString.Instance.a1.Insert(DataString.Instance.a1, aux);
            var cadena = JsonConvert.SerializeObject(DataString.Instance.a1);
            var tra = DataString.Instance.a1;
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // POST: String/Create
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

        // GET: String/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: String/Edit/5
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

        // GET: String/Delete/5
        public ActionResult Delete1(string cadena1)
        {
            ArbolString aux = new ArbolString();          
            aux.valor = cadena1;
            var arbol = Data.Instance.a1;

            bool v1 = DataString.Instance.a1.delete(DataString.Instance.a1, aux);
            var cadena = JsonConvert.SerializeObject(DataString.Instance.a1);
            var tra = DataString.Instance.a1;
            if (v1)
            {
                TempData["Succes"] = "Se elimino el nodo" + " " + cadena1;
            }
            else
            {
                TempData["Succes"] = "El nodo ingresado no existe(o no sirve mi eliminacion)";
            }
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // POST: String/Delete/5
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
