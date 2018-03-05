using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab_2.Models;
using ClassLibrary;

namespace Lab_2.Controllers
{
    public class ArbolController : Controller
    {
        // GET: Arbol
        
        public ActionResult Index()
        {
            var path = @"C:\Users\Luis\Downloads\document.json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<Arbol>(contenido);
            Data.Instance.a1 = arbol;
            var cadena = JsonConvert.SerializeObject(arbol);
            
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            
            TempData.Keep();
            
            return View();
        }
              // GET: Arbol/Details/5
        public ActionResult Details()
        {
            TempData["inorden"] = Data.Instance.a1.inorderRec(Data.Instance.a1);
            TempData["preorden"] = Data.Instance.a1.preorderRec(Data.Instance.a1);
            TempData["postorden"] = Data.Instance.a1.postorderRec(Data.Instance.a1);          

            return View("index");
        }

        // GET: Arbol/Create
        public ActionResult Create1(string Pais, string Grupo)
        {
            Arbol aux = new Arbol();
            Arbol.Pais p1 = new Arbol.Pais();
            p1.nombre = Pais;
           p1.Grupo = Grupo;
            aux.valor = p1;
            Data.Instance.a1.Insert(Data.Instance.a1,aux);
            var cadena = JsonConvert.SerializeObject(Data.Instance.a1);
            var tra = Data.Instance.a1;
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            



            return View();
        }

        private object TryCast(object p1, object p2)
        {
            throw new NotImplementedException();
        }

        // POST: Arbol/Create
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

        // GET: Arbol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Arbol/Edit/5
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

        // GET: Arbol/Delete/5
        public ActionResult Delete1(string Pais, string Grupo)
        {
            Arbol aux = new Arbol();
            Arbol.Pais p1 = new Arbol.Pais();
            p1.nombre = Pais;
            p1.Grupo = Grupo;
            aux.valor = p1;            
            var arbol = Data.Instance.a1;
            
            bool v1 = Data.Instance.a1.delete(Data.Instance.a1 , aux);
            var cadena = JsonConvert.SerializeObject(Data.Instance.a1);
            var tra = Data.Instance.a1;
            if (v1)
            {
                TempData["Succes"] = "Se elimino el nodo" + " " + Pais + " " + Grupo;
            }
            else
            {
                TempData["Succes"] = "El nodo ingresado no existe(o no sirve mi eliminacion)";
            }
            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // POST: Arbol/Delete/5
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
