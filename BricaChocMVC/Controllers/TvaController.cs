using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BricachocBll;
using BricachocBo;

namespace BricaChocMVC.Controllers
{
    public class TvaController : Controller
    {
        // GET: Tva
        public ActionResult Index()
        {
            GestionnaireGererTva GesTva = new GestionnaireGererTva();
            ICollection<Tva> CollecTva = new Collection<Tva>();
            CollecTva = GesTva.ChargerLesTvas();
            return View(CollecTva);
        }

        // GET: Tva/Details/5
        public ActionResult Details(int id)
        {
            GestionnaireGererTva GesTva = new GestionnaireGererTva();
            Tva TvaById = GesTva.RechercherTva(id);
            return View(TvaById);
        }

        // GET: Tva/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tva/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                int codeAdd = Convert.ToInt32(collection["Code"]);
                decimal tauxAdd = Convert.ToDecimal(collection["Taux"]);
                Tva AddTva = new Tva() {Code = codeAdd, Taux = tauxAdd};
                GestionnaireGererTva GesTva = new GestionnaireGererTva();
                GesTva.CreerTva(AddTva);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tva/Edit/5
        public ActionResult Edit(int id)
        {
            GestionnaireGererTva GesTva = new GestionnaireGererTva();
            Tva TvaById = GesTva.RechercherTva(id);
            return View(TvaById);
        }

        // POST: Tva/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                int codeEdit = Convert.ToInt32(collection["Code"]);
                decimal tauxedit = Convert.ToDecimal(collection["Taux"]);
                Tva EditTva = new Tva() { Code = codeEdit, Taux = tauxedit };
                GestionnaireGererTva GesTva = new GestionnaireGererTva();
                GesTva.MettreAJourTva(EditTva);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tva/Delete/5
        public ActionResult Delete(int id)
        {
            GestionnaireGererTva GesTva = new GestionnaireGererTva();
            Tva TvaById = GesTva.RechercherTva(id);
            return View(TvaById);
        }

        // POST: Tva/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                GestionnaireGererTva GesTva = new GestionnaireGererTva();
                GesTva.Supprimer(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
