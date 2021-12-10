using client_form.Models;
using client_form.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace client_form.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(Client client)
        {
            ClientService service = new ClientService();

            try
            {
                service.InsertClient(client);
                ViewBag.status = true;
                ViewBag.Message = "Hola mensaje";
            }
            catch (Exception es)
            {
                ViewBag.status = false;
                ViewBag.Message = $"{es.Message}";
            }

            return View("Index");
        }
    }
}